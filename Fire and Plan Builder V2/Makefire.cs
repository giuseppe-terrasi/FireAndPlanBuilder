using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace Fire_and_Plan_Builder_V2
{
    public static class Makefire
    {
        public static string filePath = "";

        public static XmlDocument doc = new XmlDocument();

        public static bool CreateFile(string path)
        {
            try
            {
                XmlTextWriter writer = new XmlTextWriter(path, Encoding.GetEncoding("ISO-8859-1"));
                writer.Formatting = Formatting.Indented;
                writer.WriteStartDocument();
                writer.WriteStartElement("FSData");
                writer.WriteStartAttribute("version");
                writer.WriteString("9.0");
                writer.WriteEndAttribute();

                writer.WriteStartAttribute("xmlns:xsi");
                writer.WriteString("http://www.w3.org/2001/XMLSchema-instance");
                writer.WriteEndAttribute();

                writer.WriteStartAttribute("xsi:noNamespaceSchemaLocation");
                writer.WriteString("bglcomp.xsd");
                writer.WriteEndAttribute();
                writer.Close();

                filePath = path;
                return true;
            }
            catch (Exception)
            {
                filePath = "";
                return false;
            }
        }

        public static DialogResult LoadFile()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "XML | *.xml";
            DialogResult result;
            result = openFile.ShowDialog();
            filePath = openFile.FileName;

            if (result == DialogResult.OK)
            {
               // XmlDocument xDoc = new XmlDocument();
                doc.Load(filePath);
               
            }
            return result;

        }

        public static bool InsertAreaInComment(string area)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(filePath);

                XmlNodeList comments = doc.SelectNodes("//comment()");

                foreach (XmlNode n in comments)
                {
                    if (n.InnerText.Contains("Area:"))
                    {
                        n.ParentNode.RemoveChild(n);
                    }
                    
                }

                XmlComment comment = doc.CreateComment("Area: " + area);
                XmlElement root = doc.DocumentElement;
                doc.InsertBefore(comment, root);
                doc.Save(filePath);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public static bool InsertPositionInComment(string position)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(filePath);

                XmlNodeList comments = doc.SelectNodes("//comment()");

                foreach (XmlNode n in comments)
                {
                    if (n.InnerText.Contains("Posizione:"))
                    {
                        n.ParentNode.RemoveChild(n);
                    }

                }

                XmlComment comment = doc.CreateComment("Posizione: " + position);
                XmlElement root = doc.DocumentElement;
                doc.InsertBefore(comment, root);
                doc.Save(filePath);

                return true;
            }
            catch
            {
                return false;
            }

        }

        public static string GetAreaFromComment()
        {
            try
            {

                XmlDocument doc = new XmlDocument();
                doc.Load(filePath);

                string area = "";

                XmlNodeList comments = doc.SelectNodes("//comment()");

                foreach (XmlNode n in comments)
                {
                    if (n.InnerText.Contains("Area:"))
                    {
                        area = n.Value;
                    }
                  
                }
                return area;
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static string GetPositionFromComment()
        {
            try
            {

                XmlDocument doc = new XmlDocument();
                doc.Load(filePath);

                string position = "";

                XmlNodeList comments = doc.SelectNodes("//comment()");

                foreach (XmlNode n in comments)
                {
                    if (n.InnerText.Contains("Posizione:"))
                    {
                        position = n.Value;
                    }

                }
                return position;
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static bool InsertTypeMapInComment(string mapType)
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(filePath);

                XmlNodeList comments = doc.SelectNodes("//comment()");

                foreach (XmlNode n in comments)
                {
                    if (n.InnerText.Contains("Mappa:"))
                    {
                        n.ParentNode.RemoveChild(n);
                    }

                }

                XmlComment comment = doc.CreateComment("Mappa: " + mapType);
                XmlElement root = doc.DocumentElement;
                doc.InsertBefore(comment, root);
                doc.Save(filePath);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static string GetMapTypeFromComment()
        {
            try
            {

                XmlDocument doc = new XmlDocument();
                doc.Load(filePath);

                string MapType = "";

                XmlNodeList comments = doc.SelectNodes("//comment()");

                foreach (XmlNode n in comments)
                {
                    if (n.InnerText.Contains("Mappa:"))
                    {
                        MapType = n.Value;
                    }

                }
                return MapType;
            }
            catch (Exception)
            {
                return "";
            }
        }

        private static double Y(SceneryObject P1, SceneryObject P2, double x)
        {
            return (((x - P1.Lat) * (P2.Lng - P1.Lng)) / (P2.Lat - P1.Lat)) + P1.Lng;
        }

        private static double Distance(SceneryObject start, SceneryObject end)
        {
            return Math.Sqrt(Math.Pow((end.Lat - start.Lat) + (end.Lng - start.Lng), 2));
        }

        private static double Pendenza(SceneryObject start,SceneryObject end)
        {
            double ret = 0;
            try
            {
                ret = (end.Lng - start.Lng) / (end.Lat - start.Lat);
                return ret;
            }
            catch
            {
                return 100000000;
            }
        }

        private static SceneryObject CreateObject(SceneryObject rifObj, double lat, double lon)
        {
            if(rifObj is Fire)
            {
                return new Fire(rifObj.Nome,lat, lon);
            }
            else if(rifObj is Smoke)
            {
                return new Smoke(rifObj.Nome, lat, lon);
            }
            else if(rifObj is Autocisterna)
            {
                return new Autocisterna(lat, lon);
            }
            else
            {
                return new CustomObject(((CustomObject)rifObj).Type, rifObj.Nome, lat, lon, rifObj.Marker.Type);
            }
        }

        public static List<SceneryObject> CreateLineFire(SceneryObject start, SceneryObject end)
        { 
            List<SceneryObject> points = new List<SceneryObject>();
 
            double lat = start.Lat;
            double lon = start.Lng;
            double x = 0;
            double m = Pendenza(start, end);
            points.Add(start);

            double d = Distance(start, end);
            double alpha = Math.Atan(m);
            if(m != 100000000)
            {
                if((alpha >= 45 && alpha <= 135) || (alpha >= -45 || alpha <= -135) )
                {
                    x = d * (d * 1.5);
                }
                else
                {
                    x = d * (d * 1);
                }
                    
            }
            else
            {
                x = d * (d * 0.75);
            }
            if (lat < end.Lat)
            {
                while (x < 1e-05)
                {
                    x *= 10;
                }

                while (lat < end.Lat)
                {
                    lat += x;//Convert.ToDouble("0,0000930"); 
                    lon = Y(start, end, lat);

                    if (lat != 0 && lon != 0)
                    {
                        points.Add( CreateObject(start,lat,lon) /*new Fire(start.Nome, lat, lon*/);
                    }
                }
            }
            else
            {
                while(x < 1e-05)
                {
                    x *= 10;
                }
               
                while (lat > end.Lat)
                {
                    lat -= x;//Convert.ToDouble("0,0000930"); 
                    lon = Y(start, end, lat);

                    if (lat != 0 && lon != 0)
                    {
                        points.Add(CreateObject(start, lat, lon) /*new Fire(start.Nome, lat, lon)*/);
                    }
                }
            }
            points.Add(end);

            return points;

        }
    }
}

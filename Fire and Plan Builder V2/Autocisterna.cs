using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using GMap.NET;
using GMap.NET.WindowsForms.Markers;

namespace Fire_and_Plan_Builder_V2
{
    public class Autocisterna : SceneryObject
    {
        public Autocisterna(double lat,double lon) : base("c545a2a411d2e2ec1000849c2ae60c5a", lat,lon)
        {
            marker = new GMarkerGoogle(new PointLatLng(lat, lon), GMarkerGoogleType.yellow);
        }

        public Autocisterna(Autocisterna a) : this(a.lat, a.lon) { }
        new public string Nome 
        {
            get { return "Autocisterna"; }
        }

        public string NomeEffetto
        {
            get { return name; }
        }

        public override bool AddToXml(string path)
        {
            if (!IsAddedToXml)
            {
                try
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(path);

                    XmlElement newSceneryObject = doc.CreateElement("SceneryObject");

                    newSceneryObject.SetAttribute("lat", lat.ToString().Replace(",", "."));
                    newSceneryObject.SetAttribute("lon", lon.ToString().Replace(",", "."));
                    newSceneryObject.SetAttribute("alt", "0");
                    newSceneryObject.SetAttribute("pitch", "0");
                    newSceneryObject.SetAttribute("bank", "0");
                    newSceneryObject.SetAttribute("heading", "0");
                    newSceneryObject.SetAttribute("altitudeIsAgl", "TRUE");
                    newSceneryObject.SetAttribute("imageComplexity", "SPARSE");

                    XmlElement LibraryObject = doc.CreateElement("LibraryObject");

                    LibraryObject.SetAttribute("name", NomeEffetto);
                    LibraryObject.SetAttribute("scale", "1.0");

                    newSceneryObject.AppendChild(LibraryObject);
                    doc.DocumentElement.AppendChild(newSceneryObject);
                    doc.Save(path);

                    IsAddedToXml = true;

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            
        }

        public override bool RemoveFromXml(string path)
        {
            if (IsAddedToXml)
            {
                try
                {
                    XmlDocument xDoc = new XmlDocument();
                    xDoc.Load(path);

                    foreach (XmlElement el in xDoc.SelectNodes("FSData/SceneryObject"))
                    {
                        if (el.Attributes[0].Value == lat.ToString().Replace(",", ".") && el.Attributes[1].Value == lon.ToString().Replace(",", "."))
                        {
                            el.ParentNode.RemoveChild(el);
                            IsAddedToXml = false;
                            break;
                        }
                    }
                    xDoc.Save(path);
                    IsAddedToXml = false;

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return "Autocisterna: " + lat.ToString() + "," + lon.ToString();
        }

        public override SceneryObject Clone()
        {
            return new Autocisterna(this);
        }
    }
}

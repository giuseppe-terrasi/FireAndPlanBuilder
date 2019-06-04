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
    public class Smoke : SceneryObject
    {
        private string altitude;

        public Smoke(string name, double lat, double lon) : base(name, lat, lon)
        {
            marker = new GMarkerGoogle(new PointLatLng(lat, lon), GMarkerGoogleType.red);
            altitude = "-1000";
        }

        public Smoke(Smoke s) : base(s.name, s.lat, s.lon)
        {
            altitude = s.altitude;
        }

        public string Altezza
        {
            get { return altitude; }
            set { altitude = value; }
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

                    newSceneryObject.SetAttribute("lat", GetXmlStringLat());
                    newSceneryObject.SetAttribute("lon", GetXmlStringLon());
                    newSceneryObject.SetAttribute("alt", altitude);
                    newSceneryObject.SetAttribute("pitch", "0");
                    newSceneryObject.SetAttribute("bank", "0");
                    newSceneryObject.SetAttribute("heading", "0");
                    newSceneryObject.SetAttribute("altitudeIsAgl", "TRUE");
                    newSceneryObject.SetAttribute("imageComplexity", "SPARSE");

                    XmlElement Effect = doc.CreateElement("Effect");

                    Effect.SetAttribute("effectName", name);
                    newSceneryObject.AppendChild(Effect);

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
                        if (el.Attributes[0].Value == GetXmlStringLat() && el.Attributes[1].Value == GetXmlStringLon())
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

        public override SceneryObject Clone()
        {
            return new Smoke(this);
        }
    }
}

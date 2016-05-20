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
    public class Waypoint : SceneryObject
    {
        public Waypoint(double lat, double lon) : base("Waypoint", lat,lon)
        {
            marker = new GMarkerGoogle(new PointLatLng(lat, lon), GMarkerGoogleType.green);
            //solo un test
        }

        public Waypoint(Waypoint w) : this(w.lat, w.lon) { }

        public override bool AddToXml(string path)
        {
            if (!IsAddedToXml)
            {
                try
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load(path);
                    XmlElement newWaypoint = doc.CreateElement("Waypoint");

                    newWaypoint.SetAttribute("lat", lat.ToString().Replace(",", "."));
                    newWaypoint.SetAttribute("lon", lon.ToString().Replace(",", "."));
                    newWaypoint.SetAttribute("waypointType", "NAMED");
                    newWaypoint.SetAttribute("magvar", "4.0");
                    newWaypoint.SetAttribute("waypointRegion", "LI");
                    newWaypoint.SetAttribute("waypointIdent", "FIRE");

                    doc.DocumentElement.AppendChild(newWaypoint);
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
        public override string ToString()
        {
            return name + ": " + lat.ToString() + "," + lon.ToString();
        }
        public override bool RemoveFromXml(string path)
        {
            if (IsAddedToXml)
            {
                try
                {
                    XmlDocument xDoc = new XmlDocument();
                    xDoc.Load(path);

                    foreach (XmlElement el in xDoc.SelectNodes("FSData/Waypoint"))
                    {
                        if (el.Attributes[0].Value == lat.ToString().Replace(",", ".") && el.Attributes[1].Value == lon.ToString().Replace(",", "."))
                        {
                            el.ParentNode.RemoveChild(el);
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
            return new Waypoint(this);
        }

    }
}

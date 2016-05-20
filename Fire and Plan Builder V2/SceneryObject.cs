using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using GMap.NET;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;

namespace Fire_and_Plan_Builder_V2
{
    public abstract class SceneryObject
    {
        protected string name;
        protected double lat;
        protected double lon;
        protected GMarkerGoogle marker;
        protected bool IsAddedToXml = false;

        public string Nome
        {
            get { return name; }
            set { name = value; }
        }
        public double Lat
        {
            get { return lat; }
            set { lat = value; }
        }
        public double Lng
        {
            get { return lon; }
            set { lon = value; }
        }
        public GMarkerGoogle Marker
        {
            get { return marker; }
        }

        public SceneryObject(string name,double lat,double lon)
        {
            this.name = name;
            this.lat = lat;
            this.lon = lon;
        }

        public SceneryObject(SceneryObject n)
        {
            this.name = n.name;
            this.lat = n.lat;
            this.lon = n.lon;
            this.marker = n.marker;
        }

        abstract public bool AddToXml(string path);
        public abstract bool RemoveFromXml(string path);
    
        public void AddMarkerToMap(ref GMapOverlay overlay)
        {
            overlay.Markers.Add(marker);
        }
        public void RemoveMarkerFromMap(ref GMapOverlay overlay)
        {
            overlay.Markers.Remove(marker);
        }
        abstract public override string ToString();
        public bool ContainsMarker(GMarkerGoogle marker)
        {
            if (this.marker == marker) return true;
            else return false;
        }
        public void MarkAsAddedToXml()
        {
            if (!IsAddedToXml) IsAddedToXml = true;
        }

        abstract public SceneryObject Clone();
    }
 }

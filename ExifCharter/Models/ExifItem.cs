using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExifCharter.Models
{
    public class ExifItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        private DateTime time;
        public DateTime Date { get {return this.time.Date; } set { this.time = value; } }
        public DateTime DateTime;
        public string Time { get {return this.time.ToString("HH:mm:ss");} set {} }
        public string Model { get; set; }
        [Browsable(false)]
        public decimal Altitude { get; set; }
        public decimal AltitudeRelative { get; set; }
        [Browsable(false)]
        public string Lat { get; set; }
        [Browsable(false)]
        public string Lon { get; set; }
        public double LatDeg {
            get
            {
                var y = SpatialManager.DmsStringToDd(Lat);
                return y;
            }
        }
        public double LonDeg {
            get
            {
                var x = SpatialManager.DmsStringToDd(Lon);
                return x;
            }
        }
        [Browsable(false)]
        public double Y
        {
            get
            {
                var y = SpatialManager.WGS84toUTM(LatDeg,LonDeg)[1];
                return y;
            }
        }
        [Browsable(false)]
        public double X
        {
            get
            {
                var x = SpatialManager.WGS84toUTM(LatDeg, LonDeg)[0];
                return x;
            }
        }
        public decimal CameraPitch { get; set; }
        private decimal _cameraHeading;
        public decimal CameraHeading { get { return GetAbsoluteHeading(this._cameraHeading); } set { this._cameraHeading = value; } }

        private decimal _droneHeading;
        public decimal DroneHeading { get { return GetAbsoluteHeading(this._droneHeading); } set { this._droneHeading = value; } }

        [Browsable(false)]
        public decimal HeadingDiff { 
            get {
                var diff = DroneHeading - CameraHeading;
                if (diff<-180 || diff > 180)
                {
                    diff = diff + 360;
                }
                return diff;
            } 
            set {
            } 
        }        

        //CAMERA parameters
        public double EV { get; set; }
        public double ImageHeight { get; set; }
        public double ImageWidth { get; set; }

        [Browsable(false)]
        public string FilePath { get; set; }
        private decimal GetAbsoluteHeading(decimal heading)
        {
            decimal toReturn = heading;
            if (toReturn < 0) toReturn = toReturn + 360; 
            return toReturn;
        }

        //Overlap
        public double FrontOverlap { get; set; }
        [Browsable(false)]
        public double VerticalOverlap { get; set; }
        public double TimeFromPrevious { get; set; }
        public decimal HeadingOffset { get; set; }

        public string SelfData { get; set; }
    }
}

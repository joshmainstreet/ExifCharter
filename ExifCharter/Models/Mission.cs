using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ExifCharter.Models
{
    public class Mission
    {
        [DisplayName("Drone")]
        public string drone { get; set; }
        [Browsable(false)]
        public string camera { get; set; }
        [Browsable(false)]
        public string id { get; set; }
        //[Browsable(false)]
        [DisplayName("Country")]
        public string country { get; set; }
        [DisplayName("Status")]
        public string state { get; set; }
        [DisplayName("Mission type")]
        public string missionType { get; set; }
        [DisplayName("Date")]
        public DateTime date { get; set; }
        [DisplayName("Time start")]
        public DateTime timeStart { get; set; }
        [DisplayName("Time end")]
        public DateTime timeEnd { get; set; }
        [DisplayName("Expected img")]
        public int? imagesExpected { get; set; }
        [DisplayName("EV")]
        public string EV { get; set; }
        [DisplayName("Front Ovlp")]
        public double frontOverlap { get; set; }
        [DisplayName("Vert Ovlp")]
        public double verticalOverlap { get; set; }


        [Browsable(false)]
        public int imagesActual { get; set; }
        [Browsable(false)]
        public int? timeExpected { get; set; }
        [Browsable(false)]
        public int timeActual { get; set; }
        [Browsable(false)]
        public double timeAccuracy {
            get { return (double)timeActual / (double)timeExpected; }
            set { } }
        [Browsable(false)]
        public double latMin { get; set; }
        [Browsable(false)]
        public double latMax { get; set; }
        [Browsable(false)]
        public double lonMin { get; set; }
        [Browsable(false)]
        public double lonMax { get; set; }
        [Browsable(false)]
        public string survey_region { get; set; }
        
        
        [Browsable(false)]
        public List<ExifItem> Images { get; set; }
        
    }
}

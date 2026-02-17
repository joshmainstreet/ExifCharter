using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ExifCharter.Models;
using System.Text.RegularExpressions;

namespace ExifCharter
{
    public static class Mixpanel
    {
        public static List<dynamic> GetMissionsFromMixpanelJSON(string filePath) //To be changed
        {
            string text = System.IO.File.ReadAllText(filePath);
            List<dynamic> missions = JsonConvert.DeserializeObject<List<dynamic>>(text);
            return missions;
        }

        public static List<dynamic> GetMissionsFromLogs(string filePath) //To be changed
        {
            // Define a regular expression for repeated words.
            Regex rx = new Regex(@"CaptureSDK - Mission event: {.*}", RegexOptions.Multiline | RegexOptions.IgnoreCase);
            string text = System.IO.File.ReadAllText(filePath);

            // Find matches.
            MatchCollection matches = rx.Matches(text);
            List<dynamic> resultsList = new List<dynamic>();
            var currentResult = "[";
            for (var i = 0; i < matches.Count; i++){
                currentResult += matches[i].ToString().Replace("CaptureSDK - Mission event: ", @"{""properties"": ") + "}";
                if (i != matches.Count - 1)
                    currentResult += ",";                                
            }
            currentResult += "]";
            List<dynamic> missions = JsonConvert.DeserializeObject<List<dynamic>>(currentResult);
            return missions;
        }

        public static List<Mission> ConvertToMissions(List<dynamic> missionsRaw)
        {
            List<Mission> missions = new List<Mission>();
            var a = missionsRaw.FirstOrDefault(x => x.properties.surveyregion_center_latitude == null);
            foreach(dynamic missionRaw in missionsRaw)
            {
                Mission mission = new Mission();
                mission.drone = missionRaw.properties.drone;
                mission.camera = missionRaw.properties.camera;                
                mission.missionType = missionRaw.properties.scan_mission_type;
                mission.timeStart = UnixTimeToDateTime(Convert.ToInt64(missionRaw.properties.mission_datetime) - Convert.ToInt64(missionRaw.properties.actual_flight_time_sec/2));
                mission.timeEnd = UnixTimeToDateTime(Convert.ToInt64(missionRaw.properties.mission_datetime) + Convert.ToInt64(missionRaw.properties.actual_flight_time_sec/2));
                mission.date = mission.timeStart.Date;
                mission.imagesActual = missionRaw.properties.actual_image_count;
                mission.imagesExpected = missionRaw.properties.expected_image_count;
                mission.timeActual = missionRaw.properties.actual_flight_time_sec;
                mission.timeExpected = missionRaw.properties.expected_flight_time_sec;
                mission.state = missionRaw.properties.state;
                mission.country = missionRaw.properties.country;
                mission.EV = missionRaw.properties.setting_exposure_compensation;
                if(mission.missionType == "cylinder_cell_tower")
                    mission.verticalOverlap = missionRaw.properties.setting_front_overlap;
                if (mission.missionType == "grid")
                    mission.frontOverlap = missionRaw.properties.setting_front_overlap;
                var surveyRegion = missionRaw.properties.surveyregion_outline;
                if (surveyRegion != null)
                {
                    var coords = surveyRegion.ToString().Split(',');
                    mission.latMax = GetEvenOdd(new List<string>(coords), true).Max();
                    mission.latMin = GetEvenOdd(new List<string>(coords), true).Min();
                    mission.lonMax = GetEvenOdd(new List<string>(coords), false).Max();
                    mission.lonMin = GetEvenOdd(new List<string>(coords), false).Min();
                    if (mission.latMax==0)
                        mission.latMax = 0;
                }
                missions.Add(mission);
                //Asign images to mission
                //mission.latMin = missionRaw.properties.surveyregion_outline
            }
            return missions;
        }

        private static List<double> GetEvenOdd(List<string> coords, bool pair)
        {
            List<double> output = new List<double>();
            foreach (var i in coords)
            {
                if (coords.IndexOf(i) % 2 == 0 && pair)
                    output.Add(Convert.ToDouble(i));
                if (coords.IndexOf(i) % 2 != 0 && pair == false)
                    output.Add(Convert.ToDouble(i));
            }                
            return output;
        }

        public static DateTime UnixTimeToDateTime(long unixtime)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixtime).ToLocalTime();
            return dtDateTime;
        }
    }
}

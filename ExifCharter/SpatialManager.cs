using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proj4Net;
using DotSpatial.Projections;
using System.Text.RegularExpressions;
using ExifCharter.Models;

namespace ExifCharter
{
    public static class SpatialManager
    {
        public static double[] WGS84toUTM(double lat, double lon)
        {
            double[] xy = { Convert.ToDouble(lon), Convert.ToDouble(lat) };
            double[] toConvert = new double[2];
            double[] z = new double[1];
            z[0] = 0;
            toConvert[0] = lon;
            toConvert[1] = lat;
            //string utm = "+proj=utm +zone=30 +ellps=WGS84 +datum=WGS84 +units=m +no_defs ";
            string utm = "+proj=utm +zone=30 +ellps=WGS84 +datum=WGS84 +units=m +no_defs ";

            ProjectionInfo src = KnownCoordinateSystems.Geographic.World.WGS1984;
            //ProjectionInfo trg = KnownCoordinateSystems.Projected.UtmWgs1984.WGS1984ComplexUTMZone30N;
            //ProjectionInfo src = ProjectionInfo.FromProj4String(wgs84);
            ProjectionInfo trg = ProjectionInfo.FromProj4String(utm);

            Reproject.ReprojectPoints(toConvert, z, src, trg, 0, 1);
            return toConvert;
        }

        public static double DmsStringToDd(string raw)
        {
            var dms = Regex.Split(raw, @"[^0-9\.]+").Where(c => c != "." && c.Trim() != "").ToList();
            var toReturn= Convert.ToDouble(dms[0]) + (Convert.ToDouble(dms[1]) / 60) + (Convert.ToDouble(dms[2]) / 3600);
            if (raw.StartsWith("-")){
                toReturn = -toReturn;
            }
            return toReturn;
        }

        public static string AnafiAiString(string raw1)
        {
            string raw = raw1.Remove(raw1.Length - 1);
            double degrees = Convert.ToDouble(raw.Split(',')[0]);
            double minutes = Math.Floor(Convert.ToDouble(raw.Split(',')[1]));
            double seconds = Convert.ToDouble(raw.Split(',')[1]) % 1 * 60;
            if (raw1.Last() == 'W' || raw1.Last() == 'S')
                degrees = -degrees;
            string strToReturn = degrees.ToString() + "," + minutes.ToString() + "," + seconds.ToString();
            return strToReturn;
        }

        public static double[] UTMtoWGS84(double Y, double X)
        {
            double[] xy = { Convert.ToDouble(X), Convert.ToDouble(Y) };
            double[] toConvert = new double[2];
            double[] z = new double[1];
            z[0] = 0;
            toConvert[0] = X;
            toConvert[1] = Y;
            //string utm = "+proj=utm +zone=30 +ellps=WGS84 +datum=WGS84 +units=m +no_defs ";
            string utm = "+proj=utm +zone=30 +ellps=WGS84 +datum=WGS84 +units=m +no_defs ";

            ProjectionInfo trg = KnownCoordinateSystems.Geographic.World.WGS1984;
            //ProjectionInfo trg = KnownCoordinateSystems.Projected.UtmWgs1984.WGS1984ComplexUTMZone30N;
            //ProjectionInfo src = ProjectionInfo.FromProj4String(wgs84);
            ProjectionInfo src = ProjectionInfo.FromProj4String(utm);

            Reproject.ReprojectPoints(toConvert, z, src, trg, 0, 1);
            return toConvert;
        }

        public static double GetMissionRadius(List<ExifItem> images)
        {
            //Get first item
            var image0 = images[0];
            List<double> distances = new List<double>();
            foreach(ExifItem item in images)
            {
                var distAB = Math.Pow(Math.Pow(image0.X - item.X, 2) + Math.Pow(image0.Y - item.Y, 2), 0.5);
                distances.Add(distAB);
            }
            return distances.Max()/2;
        }
    }
}

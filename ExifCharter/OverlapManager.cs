using ExifCharter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExifCharter
{
    public static class OverlapManager
    {
        // Given 2 images provides the front overlap
        public static double GetFrontOverlap(ExifItem img_1, ExifItem img_2, Camera camera, double altRelative)
        {
            //Calculate the overlap
            //Distance between images
            var GSD = (camera.SensorWidth * altRelative * 100) / (camera.FocalLength * camera.ImageWidth);
            var dH = (GSD * camera.ImageHeight) / 100;
            var distAB = Math.Pow(Math.Pow(img_1.X - img_2.X,2) + Math.Pow(img_1.Y - img_2.Y,2),0.5);
            double overlap = 1 - (distAB / dH);

            return overlap;
        }

        public static double GetFrontOverlap(double distImages, double distTarget, Camera camera)
        {
            //Calculate the overlap
            //Distance between images
            var GSD = (camera.SensorWidth * distTarget * 100) / (camera.FocalLength * camera.ImageWidth);
            var dH = (GSD * camera.ImageHeight) / 100;
            double overlap = 1 - (distImages / dH);

            return overlap;
        }

        public static double GetVerticalOverlap(ExifItem img_1, ExifItem img_2, Camera camera, double radius)
        {
            //Calculate the overlap
            //Distance between images
            var GSD = (camera.SensorWidth * (radius-1) * 100) / (camera.FocalLength * camera.ImageWidth);
            var dH = (GSD * camera.ImageHeight) / 100;
            var distAB = Math.Abs(img_2.AltitudeRelative - img_1.AltitudeRelative);
            double overlap = 1 - (Convert.ToDouble(distAB) / dH);

            return overlap;
        }

        public static List<ExifItem> ComputeTimeFromPrevious(List<ExifItem> cameras)
        {
            int index = 0;
            foreach (ExifItem img in cameras)
            {
                index = cameras.IndexOf(img);
                if (index == 0)
                    img.TimeFromPrevious = 2;
                else                   
                    img.TimeFromPrevious = (img.DateTime - cameras[index-1].DateTime).TotalSeconds;
            }
            return cameras;
        }
    }
}

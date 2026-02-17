using ExifCharter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExifCharter
{
    public class Camera
    {
        public double SensorWidth;
        public double FocalLength;
        public double ImageWidth;
        public double ImageHeight;
        public string Name;
        public string Code;

        //Creates a new camera based on the camera name
        public Camera (string model)
        {
            switch (model)
            {
                case "FC6310S": // Phantom 4 Pro V2
                    this.SensorWidth = 12.8333;
                    this.FocalLength = 8.6;
                    this.ImageWidth = 5472;
                    this.ImageHeight = 3648;
                    this.Name = "Phantom 4 Pro V2";
                    this.Code = model;
                    break;
                case "FC6310": // Phantom 4 Pro
                    this.SensorWidth = 12.8333;
                    this.FocalLength = 8.6;
                    this.ImageWidth = 5472;
                    this.ImageHeight = 3648;
                    this.Name = "Phantom 4 Pro";
                    this.Code = model;
                    break;
                case "FC2204": // Mavic 2 Zoom
                    this.SensorWidth = 6.396;
                    this.FocalLength = 4.4;
                    this.ImageWidth = 4000;
                    this.ImageHeight = 3000;
                    this.Name = "Mavic 2 Zoom";
                    this.Code = model;
                    break;
                case "L1D-20c": // Mavic 2 Pro
                    this.SensorWidth = 13.2;
                    this.FocalLength = 10.3;
                    this.ImageWidth = 5472;
                    this.ImageHeight = 3648;
                    this.Name = "Mavic 2 Pro";
                    this.Code = model;
                    break;
                case "FC6510": // Zenmuse X4S
                    this.SensorWidth = 13.2;
                    this.FocalLength = 8.8;
                    this.ImageWidth = 5472;
                    this.ImageHeight = 3648;
                    this.Name = "Zenmuse X4S";
                    this.Code = model;
                    break;
                case "FC6520": // Zenmuse X5S
                    this.SensorWidth = 17.5;
                    this.FocalLength = 15;
                    this.ImageWidth = 5280;
                    this.ImageHeight = 3956;
                    this.Name = "Zenmuse X5S";
                    this.Code = model;
                    break;
                case "ZenmuseP1": // Zenmuse P1
                    this.SensorWidth = 35;
                    this.FocalLength = 35;
                    this.ImageWidth = 8192;
                    this.ImageHeight = 5460;
                    this.Name = "Zenmuse P1";
                    this.Code = model;
                    break;
                case "Anafi": // Anafi 4K 
                    this.SensorWidth = 6.194;
                    this.FocalLength = 4.0244;
                    this.ImageWidth = 4608;
                    this.ImageHeight = 3456;
                    this.Name = "Anafi 4K";
                    this.Code = model;
                    break;
                case "AnafiThermal": // Anafi Thermal
                    this.SensorWidth = 6.194;
                    this.FocalLength = 4.0244;
                    this.ImageWidth = 4608;
                    this.ImageHeight = 3456;
                    this.Name = "Anafi Thermal";
                    this.Code = model;
                    break;
                case "ANAFI Ai": // Anafi Ai
                    this.SensorWidth = 6.66311;
                    this.FocalLength = 5.27;
                    this.ImageWidth = 8000;
                    this.ImageHeight = 6000;
                    this.Name = "Anafi Ai";
                    this.Code = model;
                    break;
            }
        }
    }
}

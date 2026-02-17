using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExifCharter.Models;
using MetadataExtractor;
using System.IO;
using MetadataExtractor.Formats.Xmp;
using System.Windows.Forms;

namespace ExifCharter
{
    static class DataManager
    {
        //Get exif data from files        
        public static List<ExifItem> GetExif(string folder, bool subDirectories)
        {
            string[] files = null;
            if(subDirectories)
                files = System.IO.Directory.GetFiles(folder, "*.jpg", SearchOption.AllDirectories);
            else
                files = System.IO.Directory.GetFiles(folder, "*.jpg");
            
            var outData = new List<ExifItem>();
            foreach (var file in files) {
                var newItem = new ExifItem();
                var directories = ImageMetadataReader.ReadMetadata(file);

                foreach (var directory in directories)
                {
                    foreach (var tag in directory.Tags)
                    {
                        // Assigns the different values to the Exif item
                        var desc = tag.Description;
                        switch (tag.Name)
                        {
                            case "File Name":
                                newItem.Name = desc;
                                break;
                            case "Model":
                                newItem.Model = desc;
                                break;
                            case "Date/Time Original":
                                newItem.DateTime = Convert.ToDateTime(desc.Substring(0, 10).Replace(':', '/') + " " + desc.Substring(11));
                                newItem.Date = Convert.ToDateTime(desc.Substring(0,10).Replace(':','/')+" " + desc.Substring(11));
                                break;
                            case "GPS Latitude":
                                newItem.Lat = desc;
                                break;
                            case "GPS Longitude":
                                newItem.Lon = desc;
                                break;
                            case "GPS Altitude":
                                newItem.Altitude = Convert.ToDecimal(desc.Split(' ')[0]); 
                                break;
                            case "Camera Pitch":
                                newItem.CameraPitch = Convert.ToDecimal(desc);
                                break;
                            case "Camera Yaw":
                                newItem.CameraHeading = Convert.ToDecimal(desc);
                                break;
                            case "Aircraft Yaw":
                                newItem.DroneHeading = Convert.ToDecimal(desc);
                                break;
                            case "Exposure Bias Value":
                                if (desc.IndexOf("/") != -1)
                                {
                                    //Mavic 2 Pro brings the normal value
                                    var a = Convert.ToDouble(desc.Split('/')[0]);
                                    var b = Convert.ToDouble(desc.Split('/')[1].Split(' ')[0]);
                                    newItem.EV = a / b;
                                }
                                else
                                {
                                    //Phantom 4 Pro brings fractionary value
                                    newItem.EV = Convert.ToDouble(desc.Split(' ')[0]);
                                }                                
                                break;
                            case "Image Height":
                                newItem.ImageHeight = Convert.ToDouble(desc.Split(' ')[0]);
                                break;
                            case "Image Width":
                                newItem.ImageWidth = Convert.ToDouble(desc.Split(' ')[0]);
                                break;

                        }

                        //XMP works different
                        var xmpDirectory = directories.OfType<XmpDirectory>().FirstOrDefault();
                        foreach (var property in xmpDirectory.XmpMeta.Properties)
                        {
                            //Console.WriteLine(property.Path);
                            switch (property.Path) {
                                case "drone-dji:SelfData":
                                    newItem.SelfData = property.Value;
                                    break;
                                case "drone-dji:RelativeAltitude":
                                    newItem.AltitudeRelative = Convert.ToDecimal(property.Value);
                                    break;
                                case "Camera:AboveGroundAltitude":
                                    var a = Convert.ToDouble(property.Value.Split('/')[0]);
                                    var b = Convert.ToDouble(property.Value.Split('/')[1].Split(' ')[0]);
                                    newItem.AltitudeRelative = Convert.ToDecimal(a / b);
                                    break;
                                case "drone-dji:GimbalPitchDegree":
                                case "drone-parrot:CameraPitchDegree":
                                    newItem.CameraPitch = Convert.ToDecimal(property.Value);
                                    break;
                                case "drone-dji:GimbalYawDegree":
                                case "drone-parrot:CameraYawDegree":
                                    newItem.CameraHeading = Convert.ToDecimal(property.Value);
                                    break;
                                case "drone-dji:FlightYawDegree":
                                case "drone-parrot:DroneYawDegree":
                                    newItem.DroneHeading = Convert.ToDecimal(property.Value);
                                    break;
                                case "exif:GPSLatitude":
                                    newItem.Lat = SpatialManager.AnafiAiString(property.Value);
                                    break;
                                case "exif:GPSLongitude":
                                    newItem.Lon = SpatialManager.AnafiAiString(property.Value);
                                    break;
                            }
                        }
                    }
                    if (directory.HasError)
                    {
                        foreach (var error in directory.Errors)
                            Console.WriteLine($"ERROR: {error}");
                    }
                }
                newItem.ID = outData.Count + 1;
                newItem.FilePath = file;
                outData.Add(newItem);
            }
            return outData;
        }
    }
}

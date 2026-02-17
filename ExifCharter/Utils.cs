using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExifCharter
{
    public static class Utils
    {
        public static List<Camera> GetCameraList()
        {
            List<Camera> cameraList = new List<Camera>();
            cameraList.Add(new Camera("FC6310S"));
            cameraList.Add(new Camera("FC6310"));
            cameraList.Add(new Camera("FC2204"));
            cameraList.Add(new Camera("L1D-20c"));
            cameraList.Add(new Camera("FC6510"));
            cameraList.Add(new Camera("ZenmuseP1"));
            cameraList.Add(new Camera("Anafi"));
            cameraList.Add(new Camera("AnafiThermal"));
            cameraList.Add(new Camera("ANAFI Ai"));

            return cameraList;
        }
    }
}

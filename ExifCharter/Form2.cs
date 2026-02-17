using ExifCharter.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExifCharter
{
    public partial class Form2 : Form
    {
        List<ExifItem> imageSet;
        ExifItem currentImage;
        int offSetImage;
        public Form2(List<ExifItem> currentdata)
        {
            InitializeComponent();
            if (currentdata != null)
            {
                this.imageSet = new List<ExifItem>();
                this.imageSet = currentdata;
                this.currentImage = imageSet[150];
                offSetImage = 0;
                this.pictureBox1.Image = new Bitmap(currentImage.FilePath);
            }            
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "Up":
                    ShowImageUp();
                    break;
                case "Down":
                    ShowImageDown();
                    break;
                case "Left":
                    ShowImageLeft();
                    break;
                case "Right":
                    ShowImageRight();
                    break;
            }
        }

        private void ShowImageUp()
        {
            //Filter by angle
            //var sameAngle = imageSet.Where(x => Math.Abs(x.AltitudeRelative - currentImage.AltitudeRelative) < 2).ToList();
            var newList = new List<ExifItem>();
            decimal refHeading = this.currentImage.CameraHeading;
            decimal currentHeading = 0;
            foreach (ExifItem item in this.imageSet)
            {
                currentHeading = item.CameraHeading;
                item.HeadingOffset = Math.Abs(currentHeading - refHeading);
            }
            var nextImage = this.imageSet.Where(x => x.AltitudeRelative - this.currentImage.AltitudeRelative > 2 &&
                                                 x.AltitudeRelative - this.currentImage.AltitudeRelative < 6).OrderBy(x => x.HeadingOffset).ToList();
            if (nextImage.Count > 1)
            {
                this.pictureBox1.Image.Dispose();
                this.pictureBox1.Image = new Bitmap(nextImage[1].FilePath);
                this.currentImage = nextImage[1];
            }
        }
        private void ShowImageDown()
        {
            var newList = new List<ExifItem>();
            decimal refHeading = this.currentImage.CameraHeading;
            decimal currentHeading = 0;
            foreach (ExifItem item in this.imageSet)
            {
                currentHeading = item.CameraHeading;
                item.HeadingOffset = Math.Abs(currentHeading - refHeading);
            }

            var nextImage = this.imageSet.Where(x => x.AltitudeRelative - this.currentImage.AltitudeRelative < -2 &&
                                                 x.AltitudeRelative - this.currentImage.AltitudeRelative > -6).OrderBy(x => x.HeadingOffset).ToList();
            if (nextImage.Count > 1)
            {
                this.pictureBox1.Image.Dispose();
                this.pictureBox1.Image = new Bitmap(nextImage[1].FilePath);
                this.currentImage = nextImage[1];
            }            
        }
        private void ShowImageLeft()
        {
            //Filter by height
            var sameHeight = imageSet.Where(x => Math.Abs(x.AltitudeRelative - currentImage.AltitudeRelative) < 2).ToList();
            var newList = new List<ExifItem>();
            decimal refHeading = this.currentImage.CameraHeading;
            decimal currentHeading = 0;
            foreach (ExifItem item in sameHeight)
            {
                currentHeading = item.CameraHeading;
                if (refHeading > currentHeading)
                    currentHeading = currentHeading + 360;
                item.HeadingOffset = currentHeading - refHeading;
            }
            var nextImage = sameHeight.OrderBy(x => x.HeadingOffset - 30).ToList()[1];
            this.pictureBox1.Image.Dispose();
            this.pictureBox1.Image = new Bitmap(nextImage.FilePath);
            this.currentImage = nextImage;
        }
        private void ShowImageRight()
        {
            //Filter by height
            var sameHeight = imageSet.Where(x => Math.Abs(x.AltitudeRelative - currentImage.AltitudeRelative) < 2).ToList();
            var newList = new List<ExifItem>();
            decimal refHeading = this.currentImage.CameraHeading;
            decimal currentHeading = 0;
            foreach (ExifItem item in sameHeight)
            {
                currentHeading = item.CameraHeading;
                if (refHeading < currentHeading)
                    currentHeading = currentHeading - 360;
                item.HeadingOffset = refHeading - currentHeading;
            }
            var nextImage = sameHeight.OrderBy(x => x.HeadingOffset - 30).ToList()[1];
            this.pictureBox1.Image.Dispose();
            this.pictureBox1.Image = new Bitmap(nextImage.FilePath);
            this.currentImage = nextImage;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ExifItem camera = currentImage;
            Process.Start(camera.FilePath);
        }
    }
}

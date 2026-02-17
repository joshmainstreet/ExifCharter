using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ExifCharter.Models;

namespace ExifCharter
{
    public partial class Form1 : Form
    {
        private Controller controller;
        public Form1()
        {
            InitializeComponent();
            this.treeView2.ExpandAll();
            this.textBox1.Text = @"Path to image directory";
            this.textBox2.Text = @"C:\Users\Jose de la Calle\source\repos\ExifCharter\ExifCharter\Refs\Missions.json";
            //this.textBox2.Text = @"Path to missions file";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Initialize controller and configure controls
            controller = new Controller(this,this.textBox1.Text);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(KeyEvent);
            this.cmbType.SelectedText = "ALL";
            this.cmbDrone.SelectedText = "ALL";
            this.cmbState.SelectedText = "ALL";
            this.cmbCountry.SelectedText = "ALL";
        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            controller.UpdateChart(e.Node.Text);
        }

        //Selects the image that has been clicked from the graph
        private void crtExifChart_MouseClick(object sender, MouseEventArgs e)
        {
            var r = crtExifChart.HitTest(e.X, e.Y);
            if (r.ChartElementType == ChartElementType.DataPoint)
            {
                DataPoint p = (DataPoint)r.Object;
                int index = r.PointIndex;
                //If the ctrl key is pressed and the numbre of selected rows = 1, 
                if (ModifierKeys.HasFlag(Keys.Control) && this.dgvCurrentData.SelectedRows.Count==1 && ModifierKeys.HasFlag(Keys.Shift))
                {
                    //add all the images in between
                    var a = this.dgvCurrentData.SelectedRows[0].DataBoundItem as ExifItem;
                    var firstID = a.ID;
                    var b = this.dgvCurrentData.Rows[index].DataBoundItem as ExifItem;
                    var secondID = b.ID;
                    var rowList = new List<DataGridViewRow>();
                    controller.updateMode = false;
                    foreach (DataGridViewRow item in this.dgvCurrentData.Rows)
                    {
                        var currentID = item.DataBoundItem as ExifItem;
                        if (currentID.ID>=firstID && currentID.ID <= secondID)
                            item.Selected = true;
                    }
                    controller.updateMode = true;
                }
                else
                {   
                    //If just control is pressed, keep just the selected ones
                    if(!ModifierKeys.HasFlag(Keys.Control))
                        this.dgvCurrentData.ClearSelection();
                    this.dgvCurrentData.Rows[index].Selected = true;
                    this.dgvCurrentData.FirstDisplayedScrollingRowIndex = this.dgvCurrentData.SelectedRows[0].Index;
                }                
            }
        }

        //Filter images per mission on mission click
        private void dgvMissions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            controller.LoadDataFromImages(this.dgvMissions.SelectedRows[0].DataBoundItem as Mission);            
        }

        //Retreives the data from the JSON file
        private void btnUpdateMissions_Click(object sender, EventArgs e)
        {                        
            var fromLogs = this.checkBox1.Checked;
            int offset = Convert.ToInt32(this.txbOffset.Text);
            controller.GetMissions(this.textBox2.Text, offset, fromLogs);
            this.dgvMissions.Columns["timeStart"].DefaultCellStyle.Format = "HH:mm:ss";
            this.dgvMissions.Columns["timeEnd"].DefaultCellStyle.Format = "HH:mm:ss";                
        }

        //Retrieves the data from the selected image folder
        private void btnUpdateImages_Click(object sender, EventArgs e)
        {
            controller.SubFolderSearch = this.checkBox2.Checked;
            var folder = this.textBox1.Text;
            if (Directory.Exists(folder))
            {
                this.controller.Folder = folder;
                controller.LoadDataFromImages();
                this.dgvMissions.ClearSelection();
                ConfigurationManager.AppSettings.Set("defaultImageFolder",folder);
            }
            else
                MessageBox.Show("Directory not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cmbType_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            //Clear filter
            controller.LoadDataFromImages();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            controller.LoadMissionsFromImages();
            //if (surveyRegion != null)
            //{
            //    var coords = surveyRegion.ToString().Split(',');
            //    mission.latMax = GetEvenOdd(new List<string>(coords), true).Max();
            //    mission.latMin = GetEvenOdd(new List<string>(coords), true).Min();
            //    mission.lonMax = GetEvenOdd(new List<string>(coords), false).Max();
            //    mission.lonMin = GetEvenOdd(new List<string>(coords), false).Min();

            //}
        }

        private void dgvCurrentData_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //MessageBox.Show(e.Node.Text);
            if(controller!=null && this.treeView2.SelectedNode!= null)
                controller.UpdateChart(this.treeView2.SelectedNode.Text);
            this.lblNumberImages.Text = "Images: " + this.dgvCurrentData.Rows.Count.ToString();
        }

        public double zoom = 1;



        private void GetImage(string direction)
        {
            try
            {
                var images = controller.CurrentData;
                ExifItem camera = dgvCurrentData.SelectedRows[0].DataBoundItem as ExifItem;
                //Select from images the next heading that is more than 10º difference from actual and with the more similar height
                List<ExifItem> newImages = new List<ExifItem>();
                ExifItem item = new ExifItem();
                if (direction == "left" || direction == "right")
                {
                    if (direction == "left")
                        newImages = images.Where(x => x.DroneHeading - camera.DroneHeading > 40 && x.DroneHeading - camera.DroneHeading < 50).ToList();
                    else if (direction == "right")
                        newImages = images.Where(x => x.DroneHeading - camera.DroneHeading < -40 && x.DroneHeading - camera.DroneHeading > -50).ToList();

                    item = newImages.OrderBy(x => Math.Abs(camera.AltitudeRelative - x.AltitudeRelative)).First();
                }

                if (direction == "up" || direction == "down")
                {
                    newImages = images.Where(x => x.DroneHeading - camera.DroneHeading > -5 && x.DroneHeading - camera.DroneHeading < 5).ToList();
                    if (direction == "up")
                        item = newImages.Where(x => camera.AltitudeRelative - x.AltitudeRelative < 0).OrderBy(x => Math.Abs(camera.AltitudeRelative - x.AltitudeRelative)).First();
                    else
                        item = newImages.Where(x => camera.AltitudeRelative - x.AltitudeRelative > 0).OrderBy(x => Math.Abs(camera.AltitudeRelative - x.AltitudeRelative)).First();
                }
                picImageBox.ImageLocation = item.FilePath;
                dgvCurrentData.ClearSelection();
                foreach (DataGridViewRow row in dgvCurrentData.Rows)
                    if (row.Cells[0].Value.ToString() == item.ID.ToString())
                        row.Selected = true;
            }
            catch{}                                    
        }
        private void KeyEvent(object sender, KeyEventArgs e) //Keyup Event 
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    GetImage("down");
                    break;
                case Keys.Up:
                    GetImage("up");
                    break;
                case Keys.Left:
                    GetImage("left");
                    break;
                case Keys.Right:
                    GetImage("right");
                    break;
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //Filter missions
            controller.FilterMissions(this.cmbType.Text, this.cmbDrone.Text, this.cmbState.Text, this.cmbCountry.Text);
        }

        //Remove selected list of items from the grid
        private void btnRemoveImages_Click(object sender, EventArgs e)
        {
            try
            {
                var toDelete = new List<int>();
                foreach (DataGridViewRow row in dgvCurrentData.SelectedRows)
                    toDelete.Add((int)row.Cells[0].Value);
                controller.CurrentData = controller.CurrentData.Where(x => !toDelete.Contains(x.ID)).ToList();
                dgvCurrentData.DataSource = controller.CurrentData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No images selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                 
        }

        //Export via copy the selected images to the selected folder
        private void btnCopyImages_Click(object sender, EventArgs e)
        {
            try
            {
                var fsd = new FolderBrowserDialog();
                var targetFolder = "";
                if (fsd.ShowDialog() == DialogResult.OK)
                {
                    targetFolder = fsd.SelectedPath;
                    foreach (ExifItem imageFile in controller.CurrentData)
                        System.IO.File.Copy(imageFile.FilePath, targetFolder + "//" + imageFile.Name, false);
                    MessageBox.Show(controller.CurrentData.Count().ToString() + " Images exported", "Export completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting images", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
        }

        

        //Open missions file
        private void button2_Click(object sender, EventArgs e)
        {
            string appPath = Environment.CurrentDirectory;
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string sFile = System.IO.Path.Combine(sCurrentDirectory, @"..\..\..\ExifCharter\Refs\Missions.json");
            string sFilePath = Path.GetFullPath(sFile);
            string fileName = @"C:\Users\Jose de la Calle\source\repos\ExifCharter\ExifCharter\Refs\Missions.json";
            Process.Start(fileName);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string fileName = @"C:\Users\Jose de la Calle\source\repos\ExifCharter\ExifCharter\Refs\MixpanelQuery.txt";
            Process.Start(fileName);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe", "https://mixpanel.com/project/470965/view/56495/app/jql-console#new");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                var toDelete = new List<int>();
                foreach (DataGridViewRow row in dgvCurrentData.SelectedRows)
                    toDelete.Add((int)row.Cells[0].Value);
                controller.CurrentData = controller.CurrentData.Where(x => toDelete.Contains(x.ID)).ToList();
                dgvCurrentData.DataSource = controller.CurrentData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No images selected", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void picImageBox_DoubleClick(object sender, EventArgs e)
        {
            ExifItem camera = dgvCurrentData.SelectedRows[0].DataBoundItem as ExifItem;
            Process.Start(camera.FilePath);
        }

        //Applies a time offset to all missions in the list
        private void btnAply_Click(object sender, EventArgs e)
        {
            int offset = Convert.ToInt32(this.txbOffset.Text);
            var missions = controller.Missions;
            foreach(Mission mission in missions){
                mission.timeStart = mission.timeStart.AddHours(offset);
                mission.timeEnd = mission.timeEnd.AddHours(offset);
            }
            dgvMissions.DataSource = missions;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Define a regular expression for repeated words.
            Regex rx = new Regex(@"CaptureSDK - Mission event: {.*}",
              RegexOptions.Multiline | RegexOptions.IgnoreCase);

            string text = System.IO.File.ReadAllText(@"path to file");
            
            // Find matches.
            MatchCollection matches = rx.Matches(text);
            var a = matches[0];
            for(var i=0;i<matches.Count;i++)
            {
                a = matches[i];
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            var spatialForm = new Form2(controller.CurrentData);
            spatialForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var overlapForm = new frmOverlapCalc();
            overlapForm.Show();

        }
    }
}

using ExifCharter.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace ExifCharter
{
    class Controller
    {
        public List<ExifItem> CurrentData { get; set; } //Current set of images 
        private List<ExifItem> CurrentSelection { get; set; } //Current selected images
        private Form View;
        private DataGridView Grid;
        private DataGridView GridMissions;
        private ComboBox MissionTypes;
        private ComboBox MissionID;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private PictureBox ImageBox;
        private List<dynamic> RawMissions;
        public List<Mission> Missions;
        private Camera Camera;
        public string Folder;
        public DateTime TimeStart;
        public DateTime TimeEnd;
        public bool SubFolderSearch;
        public bool updateMode;

        public Controller(Form view, string folder)
        {
            //Set view
            this.View = view;
            this.Grid = (DataGridView)this.View.Controls.Find("dgvCurrentData",true)[0];
            this.GridMissions = (DataGridView)this.View.Controls.Find("dgvMissions", true)[0];
            this.MissionTypes = (ComboBox)this.View.Controls.Find("cmbType", true)[0];
            this.MissionID = (ComboBox)this.View.Controls.Find("cmbDrone", true)[0];
            this.Chart = (System.Windows.Forms.DataVisualization.Charting.Chart)this.View.Controls.Find("crtExifChart", true)[0];
            this.ImageBox = (PictureBox)this.View.Controls.Find("picImageBox", true)[0];
            this.Grid.AutoGenerateColumns = true;
            this.Grid.SelectionChanged += new EventHandler(UpdateImage);
            this.RawMissions = new List<dynamic>();
            this.Missions = new List<Mission>();
            this.Folder = folder;
            this.updateMode = true;
            //UpdateView();
        }

        

        public void UpdateView()
        {
            //Read the folder and extract exif into this.currentdata
            LoadDataFromImages();
            UpdateChart("HeadingDiff");
        }

        //Reads and loads the current exif data
        public void LoadDataFromImages(Mission missionFilter = null)
        {
            this.CurrentData = DataManager.GetExif(this.Folder,this.SubFolderSearch);
            this.CurrentData = this.CurrentData.OrderBy(x => x.Time).ToList();
            //If mission is selected filer by mission
            if (missionFilter != null)
            {
                this.CurrentData = this.CurrentData.Where(
                    x => x.DateTime < missionFilter.timeEnd
                    && x.DateTime > missionFilter.timeStart).ToList();
            }
            //If there are results
            if (this.CurrentData.Count != 0)
            {
                this.Camera = new Camera(CurrentData[0].Model);
                this.GetFrontOverlap();
                this.GetVerticalOverlap();
                this.TimeStart = CurrentData.Min(x => x.DateTime);
                this.TimeEnd = CurrentData.Max(x => x.DateTime);
            }
            else
            {
                MessageBox.Show("No images found", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var source = new BindingSource();
            source.DataSource = this.CurrentData;
            this.Grid.DataSource = source;
            this.Grid.Refresh();
        }        
        
        public void FilterMissions(string type, string drone, string state, string country)
        {
            if(type!="ALL")
                this.Missions = this.Missions.Where(x => x.missionType == type).ToList();
            if (drone != "ALL")
                this.Missions = this.Missions.Where(x => x.drone == drone).ToList();
            if (state != "ALL")
                this.Missions = this.Missions.Where(x => x.state == state).ToList();
            if (country != "ALL")
                this.Missions = this.Missions.Where(x => x.country == country).ToList();
            var source = new BindingSource();
            source.DataSource = this.Missions;
            this.GridMissions.DataSource = source;
            this.GridMissions.Refresh();
        }

        public void UpdateChart(string field)
        {            
            if (field== "Time estimation")
            {
                this.Chart.DataSource = this.Missions;
                this.Chart.Series["StandardLine"].XValueMember = "";
                this.Chart.Series["StandardLine"].YValueMembers = "timeAccuracy";
            }
            else if (field == "Time interval")
            {
                CurrentData = OverlapManager.ComputeTimeFromPrevious(CurrentData);
                this.Chart.DataSource = CurrentData;
                this.Chart.Series["StandardLine"].XValueMember = "ID";
                this.Chart.Series["StandardLine"].YValueMembers = "TimeFromPrevious"; 
            }
            else
            {
                this.Chart.DataSource = CurrentData;
                this.Chart.Series["StandardLine"].XValueMember = "Time";
                this.Chart.Series["StandardLine"].YValueMembers = field;
            }            
            this.Chart.Series["StandardLine"].YValueType = ChartValueType.Auto;
            this.Chart.ChartAreas[0].AxisY.IsStartedFromZero = false;
            this.Chart.DataBind();
        }

        public void UpdateRays(){
            
        }

        //Returns all the missions
        public void GetMissions(string filePath, int timeOffset, bool fromLogs)
        {            
            if(!fromLogs)
                this.RawMissions = Mixpanel.GetMissionsFromMixpanelJSON(filePath);
            else
                this.RawMissions = Mixpanel.GetMissionsFromLogs(filePath);
            this.Missions = Mixpanel.ConvertToMissions(this.RawMissions);
            this.Missions = this.Missions.Where(x => x.missionType != null).ToList();
            //Aplicar time offset
            this.Missions = ApplyMissionTimeOffset(this.Missions,timeOffset);
            //Cargar misiones en grid
            var source = new BindingSource();
            source.DataSource = this.Missions;
            this.GridMissions.DataSource = source;
            this.GridMissions.Refresh();
        }

        public void UpdateMisisons()
        {

        }


        public void LoadMissionsFromImages()
        {

            //Obtener timestamp de imágenes
            var a = 0;
            var totalEnd = this.CurrentData.Max(x => x.DateTime);
            var totalStart = this.CurrentData.Min(x => x.DateTime);
            List<Mission> filteredMissions = new List<Mission>();
            foreach (Mission mission in this.Missions)
            {
                //Get number of images inside survey_region
                var containsImages = this.CurrentData.FirstOrDefault(x => x.LatDeg >= mission.latMin-1
                && x.LatDeg <= mission.latMax+1
                && x.LonDeg >= mission.lonMin-1
                && x.LonDeg <= mission.lonMax+1)!=null;
                //Get number of images on time
                var onTime = this.CurrentData.FirstOrDefault(x => x.DateTime >= (mission.timeStart.AddSeconds(-5))
                && x.DateTime <= mission.timeEnd.AddSeconds(5)) != null;
                //if (containsImages && onTime => it needs to be fixed, some missions report 0 lat lon
                if (onTime)
                    filteredMissions.Add(mission);
                else
                    a = 0;
            }
            var source = new BindingSource();
            source.DataSource = filteredMissions;
            this.Missions = filteredMissions;
            this.GridMissions.DataSource = source;
            this.GridMissions.Refresh();            
        }

        private void  UpdateImage(object sender, EventArgs args)
        {
            if (this.Grid.SelectedRows.Count > 0 && updateMode == true)
            {
                var firstRow = this.Grid.SelectedRows[this.Grid.SelectedRows.Count-1];
                this.ImageBox.Image = Image.FromFile(CurrentData.FirstOrDefault(x => x.ID == Convert.ToInt32(firstRow.Cells["ID"].Value)).FilePath);                 
            }

        }        

        internal void GetFrontOverlap()
        {
            foreach (ExifItem item in this.CurrentData)
            {
                if (CurrentData.IndexOf(item) != 0)
                {
                    var itemPrevious = CurrentData[CurrentData.IndexOf(item) - 1];
                    var avgAlt = (itemPrevious.AltitudeRelative + item.AltitudeRelative)/ 2;
                    item.FrontOverlap = OverlapManager.GetFrontOverlap(itemPrevious, item, this.Camera, Convert.ToDouble(avgAlt));
                }
            }
            if(CurrentData.Count>1)
                CurrentData[0].FrontOverlap = CurrentData[1].FrontOverlap;
        }

        internal void GetVerticalOverlap()
        {
            var radius = SpatialManager.GetMissionRadius(CurrentData);
            foreach (ExifItem item in this.CurrentData)
            {
                if (CurrentData.IndexOf(item) != 0)
                {
                    var itemPrevious = CurrentData[CurrentData.IndexOf(item) - 1];
                    item.VerticalOverlap = OverlapManager.GetVerticalOverlap(itemPrevious, item, this.Camera, radius);
                }
            }
            if (CurrentData.Count > 1)
                CurrentData[0].VerticalOverlap = CurrentData[1].VerticalOverlap;
        }

        internal void paintLines()
        {
            double totalX = 0;
            double totalY = 0;
            int count = CurrentData.Count();
            foreach (ExifItem image in CurrentData)
            {
                totalY += image.Y;
                totalX += image.X;                
            }
            var centerX = totalX / count;
            var centerY = totalY / count;            
        }

        //Applies a time offset to the missions based on the selected offset
        public List<Mission> ApplyMissionTimeOffset(List<Mission> missions, int offset)           
        {
            foreach (Mission mission in this.Missions)
            {
                mission.timeStart = mission.timeStart.AddHours(offset);
                mission.timeEnd = mission.timeEnd.AddHours(offset);
            }
            return missions;
        }
    }
}

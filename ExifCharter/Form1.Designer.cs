namespace ExifCharter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("DroneHeading");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("HeadingDiff");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Altitude");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("EV");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("AltitudeRelative");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("CameraPitch");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("ImageHeight");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("ImageWidth");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Time interval");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Generic", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("FrontOverlap");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Grid", new System.Windows.Forms.TreeNode[] {
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("VerticalOverlap");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Cylinder", new System.Windows.Forms.TreeNode[] {
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Images", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode12,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Time estimation");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Missions", new System.Windows.Forms.TreeNode[] {
            treeNode16});
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvCurrentData = new System.Windows.Forms.DataGridView();
            this.picImageBox = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbOffset = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFilterMissions = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDrone = new System.Windows.Forms.ComboBox();
            this.lblDrone = new System.Windows.Forms.Label();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.btnClearMissionFilter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdateImages = new System.Windows.Forms.Button();
            this.lblSource = new System.Windows.Forms.Label();
            this.btnUpdateMissions = new System.Windows.Forms.Button();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.dgvMissions = new System.Windows.Forms.DataGridView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.crtExifChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.lblNumberImages = new System.Windows.Forms.Label();
            this.btnCopyImages = new System.Windows.Forms.Button();
            this.btnRemoveImages = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMissions)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crtExifChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCurrentData
            // 
            this.dgvCurrentData.AllowUserToAddRows = false;
            this.dgvCurrentData.AllowUserToOrderColumns = true;
            this.dgvCurrentData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            this.dgvCurrentData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCurrentData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCurrentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrentData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCurrentData.Location = new System.Drawing.Point(0, 0);
            this.dgvCurrentData.Margin = new System.Windows.Forms.Padding(1);
            this.dgvCurrentData.Name = "dgvCurrentData";
            this.dgvCurrentData.ReadOnly = true;
            this.dgvCurrentData.RowHeadersVisible = false;
            this.dgvCurrentData.RowHeadersWidth = 102;
            this.dgvCurrentData.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvCurrentData.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCurrentData.RowTemplate.Height = 30;
            this.dgvCurrentData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCurrentData.Size = new System.Drawing.Size(1040, 322);
            this.dgvCurrentData.TabIndex = 1;
            this.dgvCurrentData.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvCurrentData_DataBindingComplete);
            // 
            // picImageBox
            // 
            this.picImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picImageBox.Location = new System.Drawing.Point(0, 0);
            this.picImageBox.Margin = new System.Windows.Forms.Padding(1);
            this.picImageBox.Name = "picImageBox";
            this.picImageBox.Size = new System.Drawing.Size(495, 363);
            this.picImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImageBox.TabIndex = 2;
            this.picImageBox.TabStop = false;
            this.picImageBox.DoubleClick += new System.EventHandler(this.picImageBox_DoubleClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(1);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1540, 845);
            this.splitContainer1.SplitterDistance = 480;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 3;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(1);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer4);
            this.splitContainer3.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.panel1);
            this.splitContainer3.Size = new System.Drawing.Size(1540, 480);
            this.splitContainer3.SplitterDistance = 748;
            this.splitContainer3.SplitterWidth = 5;
            this.splitContainer3.TabIndex = 3;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Margin = new System.Windows.Forms.Padding(1);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.textBox2);
            this.splitContainer4.Panel1.Controls.Add(this.textBox1);
            this.splitContainer4.Panel1.Controls.Add(this.label4);
            this.splitContainer4.Panel1.Controls.Add(this.label1);
            this.splitContainer4.Panel1.Controls.Add(this.cmbType);
            this.splitContainer4.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer4.Panel1.Controls.Add(this.splitContainer5);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.dgvMissions);
            this.splitContainer4.Size = new System.Drawing.Size(748, 480);
            this.splitContainer4.SplitterDistance = 291;
            this.splitContainer4.SplitterWidth = 2;
            this.splitContainer4.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.AllowDrop = true;
            this.textBox2.Location = new System.Drawing.Point(61, 101);
            this.textBox2.Margin = new System.Windows.Forms.Padding(1);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(393, 20);
            this.textBox2.TabIndex = 34;
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Location = new System.Drawing.Point(61, 38);
            this.textBox1.Margin = new System.Windows.Forms.Padding(1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(393, 20);
            this.textBox1.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Dataset";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Missions";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "ALL",
            "orbit_cell_tower",
            "cylinder_standalone",
            "single_vertical_cell_tower",
            "underneath_orbit_cell_tower",
            "orbit_standalone",
            "cylinder_cell_tower",
            "grid"});
            this.cmbType.Location = new System.Drawing.Point(115, 175);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(229, 21);
            this.cmbType.TabIndex = 27;
            this.cmbType.SelectedValueChanged += new System.EventHandler(this.cmbType_SelectedValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txbOffset);
            this.groupBox1.Controls.Add(this.lblCountry);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnFilterMissions);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbDrone);
            this.groupBox1.Controls.Add(this.lblDrone);
            this.groupBox1.Controls.Add(this.cmbState);
            this.groupBox1.Controls.Add(this.cmbCountry);
            this.groupBox1.Controls.Add(this.btnClearMissionFilter);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(17, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 127);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter missions";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 93);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Time offset (hours)";
            // 
            // txbOffset
            // 
            this.txbOffset.Location = new System.Drawing.Point(115, 90);
            this.txbOffset.Name = "txbOffset";
            this.txbOffset.Size = new System.Drawing.Size(56, 20);
            this.txbOffset.TabIndex = 45;
            this.txbOffset.Text = "0";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(354, 53);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 13);
            this.lblCountry.TabIndex = 44;
            this.lblCountry.Text = "Country";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(357, 86);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 26);
            this.button1.TabIndex = 37;
            this.button1.Text = "From images";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnFilterMissions
            // 
            this.btnFilterMissions.Location = new System.Drawing.Point(270, 87);
            this.btnFilterMissions.Margin = new System.Windows.Forms.Padding(1);
            this.btnFilterMissions.Name = "btnFilterMissions";
            this.btnFilterMissions.Size = new System.Drawing.Size(74, 25);
            this.btnFilterMissions.TabIndex = 35;
            this.btnFilterMissions.Text = "FIlter";
            this.btnFilterMissions.UseVisualStyleBackColor = true;
            this.btnFilterMissions.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Status";
            // 
            // cmbDrone
            // 
            this.cmbDrone.FormattingEnabled = true;
            this.cmbDrone.Items.AddRange(new object[] {
            "ALL",
            "Phantom 4 Pro",
            "Phantom4 Pro V2",
            "Mavic 2 Pro",
            "Mavic 2 Zoom",
            "Matrice 200",
            "Matrice 210",
            "Matrice 210 RTK",
            "Matrice 200 V2",
            "Matrice 210 V2",
            "Matrice 210 RTK V2",
            "Anafi 4K",
            "Anafi Thermal",
            "Anafi Ai"});
            this.cmbDrone.Location = new System.Drawing.Point(98, 50);
            this.cmbDrone.Name = "cmbDrone";
            this.cmbDrone.Size = new System.Drawing.Size(229, 21);
            this.cmbDrone.TabIndex = 31;
            // 
            // lblDrone
            // 
            this.lblDrone.AutoSize = true;
            this.lblDrone.Location = new System.Drawing.Point(17, 53);
            this.lblDrone.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblDrone.Name = "lblDrone";
            this.lblDrone.Size = new System.Drawing.Size(67, 13);
            this.lblDrone.TabIndex = 30;
            this.lblDrone.Text = "Drone model";
            // 
            // cmbState
            // 
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Items.AddRange(new object[] {
            "ALL",
            "Success",
            "Paused"});
            this.cmbState.Location = new System.Drawing.Point(407, 18);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(104, 21);
            this.cmbState.TabIndex = 40;
            // 
            // cmbCountry
            // 
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Items.AddRange(new object[] {
            "ALL",
            "ES"});
            this.cmbCountry.Location = new System.Drawing.Point(407, 50);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(104, 21);
            this.cmbCountry.TabIndex = 44;
            // 
            // btnClearMissionFilter
            // 
            this.btnClearMissionFilter.Location = new System.Drawing.Point(454, 86);
            this.btnClearMissionFilter.Margin = new System.Windows.Forms.Padding(1);
            this.btnClearMissionFilter.Name = "btnClearMissionFilter";
            this.btnClearMissionFilter.Size = new System.Drawing.Size(63, 26);
            this.btnClearMissionFilter.TabIndex = 36;
            this.btnClearMissionFilter.Text = "Clear filter";
            this.btnClearMissionFilter.UseVisualStyleBackColor = true;
            this.btnClearMissionFilter.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Mission type";
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.checkBox2);
            this.splitContainer5.Panel1.Controls.Add(this.checkBox1);
            this.splitContainer5.Panel1.Controls.Add(this.button4);
            this.splitContainer5.Panel1.Controls.Add(this.button3);
            this.splitContainer5.Panel1.Controls.Add(this.button2);
            this.splitContainer5.Panel1.Controls.Add(this.label5);
            this.splitContainer5.Panel1.Controls.Add(this.btnUpdateImages);
            this.splitContainer5.Panel1.Controls.Add(this.lblSource);
            this.splitContainer5.Panel1.Controls.Add(this.btnUpdateMissions);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.treeView2);
            this.splitContainer5.Size = new System.Drawing.Size(748, 291);
            this.splitContainer5.SplitterDistance = 553;
            this.splitContainer5.TabIndex = 43;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(358, 62);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(96, 17);
            this.checkBox2.TabIndex = 37;
            this.checkBox2.Text = "Sub-directories";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(132, 133);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(71, 17);
            this.checkBox1.TabIndex = 36;
            this.checkBox1.Text = "From logs";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(217, 129);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 34;
            this.button4.Text = "Mixpanel JQL";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(379, 129);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Query";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(298, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Missions file";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 104);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Source";
            // 
            // btnUpdateImages
            // 
            this.btnUpdateImages.Location = new System.Drawing.Point(471, 34);
            this.btnUpdateImages.Margin = new System.Windows.Forms.Padding(1);
            this.btnUpdateImages.Name = "btnUpdateImages";
            this.btnUpdateImages.Size = new System.Drawing.Size(63, 26);
            this.btnUpdateImages.TabIndex = 25;
            this.btnUpdateImages.Text = "Update";
            this.btnUpdateImages.UseVisualStyleBackColor = true;
            this.btnUpdateImages.Click += new System.EventHandler(this.btnUpdateImages_Click);
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(14, 41);
            this.lblSource.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(41, 13);
            this.lblSource.TabIndex = 23;
            this.lblSource.Text = "Source";
            // 
            // btnUpdateMissions
            // 
            this.btnUpdateMissions.Location = new System.Drawing.Point(471, 97);
            this.btnUpdateMissions.Margin = new System.Windows.Forms.Padding(1);
            this.btnUpdateMissions.Name = "btnUpdateMissions";
            this.btnUpdateMissions.Size = new System.Drawing.Size(63, 26);
            this.btnUpdateMissions.TabIndex = 26;
            this.btnUpdateMissions.Text = "Update";
            this.btnUpdateMissions.UseVisualStyleBackColor = true;
            this.btnUpdateMissions.Click += new System.EventHandler(this.btnUpdateMissions_Click);
            // 
            // treeView2
            // 
            this.treeView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView2.Location = new System.Drawing.Point(0, 0);
            this.treeView2.Margin = new System.Windows.Forms.Padding(1);
            this.treeView2.Name = "treeView2";
            treeNode1.Name = "ndeDroneHeading";
            treeNode1.Text = "DroneHeading";
            treeNode2.Name = "ndeHeadingDiff";
            treeNode2.Text = "HeadingDiff";
            treeNode2.ToolTipText = "Shows the difference between camera and drone heading values";
            treeNode3.Name = "ndeAltitude";
            treeNode3.Text = "Altitude";
            treeNode4.Name = "ndeDronePitch";
            treeNode4.Text = "EV";
            treeNode5.Name = "ndeAltitudeRelative";
            treeNode5.Text = "AltitudeRelative";
            treeNode6.Name = "ndeCameraPitch";
            treeNode6.Text = "CameraPitch";
            treeNode7.Name = "ndeImageHeight";
            treeNode7.Text = "ImageHeight";
            treeNode8.Name = "ndeImageWidth";
            treeNode8.Text = "ImageWidth";
            treeNode9.Name = "ndeTimeInterval";
            treeNode9.Text = "Time interval";
            treeNode10.Name = "ndeGeneric";
            treeNode10.Text = "Generic";
            treeNode11.Name = "ndeOverlap";
            treeNode11.Text = "FrontOverlap";
            treeNode12.Name = "ndeGrid";
            treeNode12.Text = "Grid";
            treeNode13.Name = "ndeVertOverlap";
            treeNode13.Text = "VerticalOverlap";
            treeNode14.Name = "ndeCylinder";
            treeNode14.Text = "Cylinder";
            treeNode15.Name = "ndeImages";
            treeNode15.Text = "Images";
            treeNode16.Name = "ndeTimeEstimation";
            treeNode16.Text = "Time estimation";
            treeNode17.Name = "ndeMissions";
            treeNode17.Text = "Missions";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode17});
            this.treeView2.Size = new System.Drawing.Size(191, 291);
            this.treeView2.TabIndex = 1;
            this.treeView2.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView2_AfterSelect);
            // 
            // dgvMissions
            // 
            this.dgvMissions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMissions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMissions.Location = new System.Drawing.Point(0, 0);
            this.dgvMissions.Name = "dgvMissions";
            this.dgvMissions.ReadOnly = true;
            this.dgvMissions.RowHeadersVisible = false;
            this.dgvMissions.RowHeadersWidth = 102;
            this.dgvMissions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMissions.Size = new System.Drawing.Size(748, 187);
            this.dgvMissions.TabIndex = 0;
            this.dgvMissions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMissions_CellClick);
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(1);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(748, 480);
            this.treeView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.crtExifChart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 480);
            this.panel1.TabIndex = 3;
            // 
            // crtExifChart
            // 
            this.crtExifChart.BorderlineColor = System.Drawing.Color.Black;
            this.crtExifChart.BorderlineWidth = 3;
            chartArea1.AxisY.MinorTickMark.Enabled = true;
            chartArea1.Name = "ChartArea1";
            this.crtExifChart.ChartAreas.Add(chartArea1);
            this.crtExifChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crtExifChart.Location = new System.Drawing.Point(0, 0);
            this.crtExifChart.Margin = new System.Windows.Forms.Padding(1);
            this.crtExifChart.Name = "crtExifChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.MarkerBorderColor = System.Drawing.Color.Black;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "StandardLine";
            this.crtExifChart.Series.Add(series1);
            this.crtExifChart.Size = new System.Drawing.Size(787, 480);
            this.crtExifChart.TabIndex = 4;
            this.crtExifChart.Text = "chart1";
            this.crtExifChart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.crtExifChart_MouseClick);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(1);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.picImageBox);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer6);
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer7);
            this.splitContainer2.Size = new System.Drawing.Size(1540, 363);
            this.splitContainer2.SplitterDistance = 495;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 3;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer6.Location = new System.Drawing.Point(0, 0);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.button7);
            this.splitContainer6.Panel1.Controls.Add(this.button6);
            this.splitContainer6.Panel1.Controls.Add(this.button5);
            this.splitContainer6.Panel1.Controls.Add(this.lblNumberImages);
            this.splitContainer6.Panel1.Controls.Add(this.btnCopyImages);
            this.splitContainer6.Panel1.Controls.Add(this.btnRemoveImages);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.progressBar1);
            this.splitContainer6.Panel2.Controls.Add(this.dgvCurrentData);
            this.splitContainer6.Size = new System.Drawing.Size(1040, 363);
            this.splitContainer6.SplitterDistance = 37;
            this.splitContainer6.TabIndex = 2;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(552, 7);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(87, 30);
            this.button7.TabIndex = 9;
            this.button7.Text = "Overlap calc.";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(429, 7);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(105, 30);
            this.button6.TabIndex = 3;
            this.button6.Text = "Spatial navigation";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(234, 7);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 30);
            this.button5.TabIndex = 8;
            this.button5.Text = "Filter selection";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblNumberImages
            // 
            this.lblNumberImages.AutoSize = true;
            this.lblNumberImages.Location = new System.Drawing.Point(3, 13);
            this.lblNumberImages.Name = "lblNumberImages";
            this.lblNumberImages.Size = new System.Drawing.Size(104, 13);
            this.lblNumberImages.TabIndex = 0;
            this.lblNumberImages.Text = "Number of images: 0";
            // 
            // btnCopyImages
            // 
            this.btnCopyImages.FlatAppearance.BorderSize = 0;
            this.btnCopyImages.Location = new System.Drawing.Point(336, 7);
            this.btnCopyImages.Name = "btnCopyImages";
            this.btnCopyImages.Size = new System.Drawing.Size(69, 30);
            this.btnCopyImages.TabIndex = 1;
            this.btnCopyImages.Text = "Export";
            this.btnCopyImages.UseVisualStyleBackColor = true;
            this.btnCopyImages.Click += new System.EventHandler(this.btnCopyImages_Click);
            // 
            // btnRemoveImages
            // 
            this.btnRemoveImages.FlatAppearance.BorderSize = 0;
            this.btnRemoveImages.Location = new System.Drawing.Point(123, 7);
            this.btnRemoveImages.Name = "btnRemoveImages";
            this.btnRemoveImages.Size = new System.Drawing.Size(105, 30);
            this.btnRemoveImages.TabIndex = 0;
            this.btnRemoveImages.Text = "Remove selection";
            this.btnRemoveImages.UseVisualStyleBackColor = true;
            this.btnRemoveImages.Click += new System.EventHandler(this.btnRemoveImages_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(367, 138);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(498, 119);
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Visible = false;
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.Location = new System.Drawing.Point(0, 0);
            this.splitContainer7.Name = "splitContainer7";
            this.splitContainer7.Size = new System.Drawing.Size(1040, 363);
            this.splitContainer7.SplitterDistance = 344;
            this.splitContainer7.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1540, 845);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "ExifCharter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrentData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImageBox)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel1.PerformLayout();
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMissions)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.crtExifChart)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel1.PerformLayout();
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCurrentData;
        private System.Windows.Forms.PictureBox picImageBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvMissions;
        private System.Windows.Forms.Button btnClearMissionFilter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnFilterMissions;
        private System.Windows.Forms.ComboBox cmbDrone;
        private System.Windows.Forms.Label lblDrone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button btnUpdateImages;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Button btnUpdateMissions;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtExifChart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNumberImages;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.Button btnCopyImages;
        private System.Windows.Forms.Button btnRemoveImages;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbOffset;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button7;
    }
}


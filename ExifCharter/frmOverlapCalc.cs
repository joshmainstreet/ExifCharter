using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExifCharter
{
    public partial class frmOverlapCalc : Form
    {
        public frmOverlapCalc()
        {
            InitializeComponent();
        }

        private void frmOverlapCalc_Load(object sender, EventArgs e)
        {
            List<Camera> cams = Utils.GetCameraList();
            foreach (Camera cam in cams)
            {
                comboBox1.Items.Add(cam.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                List<Camera> cams = Utils.GetCameraList();
                var distTarget = Convert.ToDouble(this.textBox2.Text);
                var distImages = Convert.ToDouble(this.textBox1.Text);
                var cameraCode = cams.FirstOrDefault(x=>x.Name==this.comboBox1.Text).Code;
                var overlap = OverlapManager.GetFrontOverlap(distImages, distTarget, new Camera(cameraCode));
                this.label5.Text = Math.Round(overlap,2).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please review the values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

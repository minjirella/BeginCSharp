using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MsdnTutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        
        // 이벤트 처리기
        private void ChbStretch_CheckedChanged(object sender, EventArgs e)
        {
            if (chbStretch.Checked)
            {
                ptbImage.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                ptbImage.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        
        private void btnShow_Click(object sender, EventArgs e)
        {
            DialogResult result = ofdOpen.ShowDialog();

            if (result != DialogResult.OK)
                return;
            ptbImage.Load(ofdOpen.FileName);

        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Form1_LocationChanged(object sender, EventArgs e)
        {
            Text = $"X = {Location.X}, Y = {Location.Y}";
        }

        private void BtnBackground_Click(object sender, EventArgs e)
        {
            if (cldBackground.ShowDialog() != DialogResult.OK)
                return;

            ptbImage.BackColor = cldBackground.Color;
        }
    }
}

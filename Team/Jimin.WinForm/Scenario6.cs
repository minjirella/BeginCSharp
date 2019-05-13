using Team.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team.WinForm
{
    public partial class Scenario6 : Form
    {
        public Scenario6()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double customerTotalPrice = DataRepository.Invoice.GetCustomerTotalPrice(txtLastName.Text);
            txtTotalPrice.Text = customerTotalPrice.ToString();

            List<String> tracks = DataRepository.Track.GetTracks(txtLastName.Text);
            foreach (var item in tracks)
            {
                CLBPurchaseList.Items.Add(item);
            }

        }

        // WinForm 폴더 내부에 imagine을 불러오기위한 메소드
        // TODO - 절대경로로 작성되어 상대경로로 수정이 필요함.
        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AlbumPicture.InitialImage = null;
            AlbumPicture.Load(@"D:\C#_W\평가\정보시스템이행\최지민, 이은지, 배인아, 한영주\Team\Jimin.WinForm\imagine.jpg");
            AlbumPicture.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}

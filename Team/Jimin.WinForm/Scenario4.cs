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
    public partial class Scenario4 : Form
    {
        public Scenario4()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
            List<int> albumIds = DataRepository.Invoice.GetAlbumIdByBillingCountry(keyword);
            // List<string> albumTitles = ;
            List<Album> albums = DataRepository.Invoice.GetAlbumsByAlbumIds(albumIds);
            dataGridView1.DataSource = albums;


        }
    }
}

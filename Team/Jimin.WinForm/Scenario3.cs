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
    public partial class Scenario3 : Form
    {
        public Scenario3()
        {
            InitializeComponent();
        }

        // TODO 확인 - TrackData GetTrackByInvoiceId 메소드 참고.
        private void searchBtn_Click(object sender, EventArgs e)
        {
            int value = int.Parse(textInvoiceId.Text);

            List<Track> tracks = TrackData.GetTrackByInvoiceId(value);

            trackBindingSource.DataSource = tracks;
            
            //labelTotal
            Invoice invoice = InvoiceData.GetTotalPrice(value);
            labelTotal.Text = invoice.Total.ToString();
        }

    }
}

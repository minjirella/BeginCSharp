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
    public partial class Scenario1_2 : Form
    {
        public Scenario1_2()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<Album> Albumlist = DataRepository.Album.GetAlbumsByGenre(textBox1.Text);

            foreach (var item in Albumlist)
            {
                listBox1.Items.Add(item.Title);
            }
        }
        private void Button2_Click_1(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            List<Track> Tracks = DataRepository.Track.GetTracksByAlbum(textBox2.Text);

            foreach (var item in Tracks)
            {
                listBox2.Items.Add(item.Name);
            }
        }
        private void ListBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBox1.Items != null)
            {
                string add = listBox1.SelectedItem.ToString();
                textBox2.Text = add;
            }
        }
        private void Scenario_Load(object sender, EventArgs e)
        {

        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

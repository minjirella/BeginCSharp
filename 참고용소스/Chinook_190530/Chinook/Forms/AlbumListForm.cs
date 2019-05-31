using Chinook.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Chinook.Forms
{
    public partial class AlbumListForm : Form
    {
        public AlbumListForm()
        {
            InitializeComponent();
        }

        private void CbbArtist_SelectedIndexChanged(object sender, EventArgs e)
        {
            Artist artist = (Artist)cbbArtist.SelectedItem;
            //Text = artist.ArtistId.ToString();

            int artistId = (int)cbbArtist.SelectedValue;
            //Text = artistId.ToString();
        }

        private void AlbumListForm_Load(object sender, EventArgs e)
        {
            List<Artist> artists = DataRepository.Artist.GetAll();
            artists.OrderBy(x => x.Name).ToList();

            bdsArtist.DataSource = artists;

            //cbbArtist.Items.Insert(0,"=======");
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            List<Album> albums = DataRepository.Album.Search(txtTitle.Text, (int)cbbArtist.SelectedValue); //object type이므로 int로 캐스팅
            
            bdsAlbum.DataSource = albums;
        }

        private void TxtTitle_Leave(object sender, EventArgs e)
        {
            if (txtTitle.Text.StartsWith("a"))
                txtTitle.BackColor = Color.Red;
            else txtTitle.BackColor = Color.White;
        }

        private void DgvAlbum_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex != 1) return;

            if (dgvAlbum.Columns[e.ColumnIndex] != titleDataGridViewTextBoxColumn) return;

            //Cell의 위치를 지정해주는 인덱서. value는 object type
            var cell = dgvAlbum[e.ColumnIndex, e.RowIndex];
            string value = (string)cell.Value;

            if (value.StartsWith("a"))
                cell.Style.BackColor = Color.Red;
        }
    }
}

using Chinook.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chinook.Forms
{
    public partial class TrackListForm : Form
    {
        public TrackListForm()
        {
            InitializeComponent();
        }

        private void TrackListForm_Load(object sender, EventArgs e)
        {
            List<Album> albums =
                DataRepository.Album.GetAll();
            List<Genre> genres = DataRepository

            //uscAlbumSearch.SetArtistDataSource(artists);
        }
    }

    
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chinook.Controls
{
    public partial class AlbumListControl : UserControl
    {
        public AlbumListControl()
        {
            InitializeComponent();
        }

        private void DgvAlbum_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvAlbum.Columns[e.ColumnIndex] != titleDataGridViewTextBoxColumn) return;

            //Cell의 위치를 지정해주는 인덱서. value는 object type
            var cell = dgvAlbum[e.ColumnIndex, e.RowIndex];
            string value = (string)cell.Value;

            if (value.StartsWith("a"))
                cell.Style.BackColor = Color.Red;
        }
    }
}

namespace Chinook.Controls
{
    partial class TrackListControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvAlbum = new System.Windows.Forms.DataGridView();
            this.bdsTrack = new System.Windows.Forms.BindingSource(this.components);
            this.trackIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediaTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.composerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.millisecondsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bytesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceLinesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediaTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playlistsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlbum
            // 
            this.dgvAlbum.AutoGenerateColumns = false;
            this.dgvAlbum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlbum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trackIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.albumIdDataGridViewTextBoxColumn,
            this.mediaTypeIdDataGridViewTextBoxColumn,
            this.genreIdDataGridViewTextBoxColumn,
            this.composerDataGridViewTextBoxColumn,
            this.millisecondsDataGridViewTextBoxColumn,
            this.bytesDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.albumDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.invoiceLinesDataGridViewTextBoxColumn,
            this.mediaTypeDataGridViewTextBoxColumn,
            this.playlistsDataGridViewTextBoxColumn});
            this.dgvAlbum.DataSource = this.bdsTrack;
            this.dgvAlbum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAlbum.Location = new System.Drawing.Point(0, 0);
            this.dgvAlbum.Name = "dgvAlbum";
            this.dgvAlbum.RowTemplate.Height = 23;
            this.dgvAlbum.Size = new System.Drawing.Size(694, 421);
            this.dgvAlbum.TabIndex = 5;
            // 
            // bdsTrack
            // 
            this.bdsTrack.DataSource = typeof(Chinook.Data.Track);
            // 
            // trackIdDataGridViewTextBoxColumn
            // 
            this.trackIdDataGridViewTextBoxColumn.DataPropertyName = "TrackId";
            this.trackIdDataGridViewTextBoxColumn.HeaderText = "TrackId";
            this.trackIdDataGridViewTextBoxColumn.Name = "trackIdDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // albumIdDataGridViewTextBoxColumn
            // 
            this.albumIdDataGridViewTextBoxColumn.DataPropertyName = "AlbumId";
            this.albumIdDataGridViewTextBoxColumn.HeaderText = "AlbumId";
            this.albumIdDataGridViewTextBoxColumn.Name = "albumIdDataGridViewTextBoxColumn";
            // 
            // mediaTypeIdDataGridViewTextBoxColumn
            // 
            this.mediaTypeIdDataGridViewTextBoxColumn.DataPropertyName = "MediaTypeId";
            this.mediaTypeIdDataGridViewTextBoxColumn.HeaderText = "MediaTypeId";
            this.mediaTypeIdDataGridViewTextBoxColumn.Name = "mediaTypeIdDataGridViewTextBoxColumn";
            // 
            // genreIdDataGridViewTextBoxColumn
            // 
            this.genreIdDataGridViewTextBoxColumn.DataPropertyName = "GenreId";
            this.genreIdDataGridViewTextBoxColumn.HeaderText = "GenreId";
            this.genreIdDataGridViewTextBoxColumn.Name = "genreIdDataGridViewTextBoxColumn";
            // 
            // composerDataGridViewTextBoxColumn
            // 
            this.composerDataGridViewTextBoxColumn.DataPropertyName = "Composer";
            this.composerDataGridViewTextBoxColumn.HeaderText = "Composer";
            this.composerDataGridViewTextBoxColumn.Name = "composerDataGridViewTextBoxColumn";
            // 
            // millisecondsDataGridViewTextBoxColumn
            // 
            this.millisecondsDataGridViewTextBoxColumn.DataPropertyName = "Milliseconds";
            this.millisecondsDataGridViewTextBoxColumn.HeaderText = "Milliseconds";
            this.millisecondsDataGridViewTextBoxColumn.Name = "millisecondsDataGridViewTextBoxColumn";
            // 
            // bytesDataGridViewTextBoxColumn
            // 
            this.bytesDataGridViewTextBoxColumn.DataPropertyName = "Bytes";
            this.bytesDataGridViewTextBoxColumn.HeaderText = "Bytes";
            this.bytesDataGridViewTextBoxColumn.Name = "bytesDataGridViewTextBoxColumn";
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            // 
            // albumDataGridViewTextBoxColumn
            // 
            this.albumDataGridViewTextBoxColumn.DataPropertyName = "Album";
            this.albumDataGridViewTextBoxColumn.HeaderText = "Album";
            this.albumDataGridViewTextBoxColumn.Name = "albumDataGridViewTextBoxColumn";
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            // 
            // invoiceLinesDataGridViewTextBoxColumn
            // 
            this.invoiceLinesDataGridViewTextBoxColumn.DataPropertyName = "InvoiceLines";
            this.invoiceLinesDataGridViewTextBoxColumn.HeaderText = "InvoiceLines";
            this.invoiceLinesDataGridViewTextBoxColumn.Name = "invoiceLinesDataGridViewTextBoxColumn";
            // 
            // mediaTypeDataGridViewTextBoxColumn
            // 
            this.mediaTypeDataGridViewTextBoxColumn.DataPropertyName = "MediaType";
            this.mediaTypeDataGridViewTextBoxColumn.HeaderText = "MediaType";
            this.mediaTypeDataGridViewTextBoxColumn.Name = "mediaTypeDataGridViewTextBoxColumn";
            // 
            // playlistsDataGridViewTextBoxColumn
            // 
            this.playlistsDataGridViewTextBoxColumn.DataPropertyName = "Playlists";
            this.playlistsDataGridViewTextBoxColumn.HeaderText = "Playlists";
            this.playlistsDataGridViewTextBoxColumn.Name = "playlistsDataGridViewTextBoxColumn";
            // 
            // TrackSearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvAlbum);
            this.Name = "TrackSearchControl";
            this.Size = new System.Drawing.Size(694, 421);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTrack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediaTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn composerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn millisecondsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bytesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceLinesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediaTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playlistsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bdsTrack;
    }
}

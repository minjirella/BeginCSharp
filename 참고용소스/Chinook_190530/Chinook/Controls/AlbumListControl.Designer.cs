namespace Chinook.Controls
{
    partial class AlbumListControl
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
            this.bdsAlbum = new System.Windows.Forms.BindingSource(this.components);
            this.albumIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlbum
            // 
            this.dgvAlbum.AutoGenerateColumns = false;
            this.dgvAlbum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlbum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.albumIdDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.artistIdDataGridViewTextBoxColumn});
            this.dgvAlbum.DataSource = this.bdsAlbum;
            this.dgvAlbum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAlbum.Location = new System.Drawing.Point(0, 0);
            this.dgvAlbum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAlbum.Name = "dgvAlbum";
            this.dgvAlbum.RowHeadersWidth = 51;
            this.dgvAlbum.RowTemplate.Height = 27;
            this.dgvAlbum.Size = new System.Drawing.Size(603, 199);
            this.dgvAlbum.TabIndex = 3;
            this.dgvAlbum.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAlbum_CellValueChanged);
            // 
            // bdsAlbum
            // 
            this.bdsAlbum.DataSource = typeof(Chinook.Data.Album);
            // 
            // albumIdDataGridViewTextBoxColumn
            // 
            this.albumIdDataGridViewTextBoxColumn.DataPropertyName = "AlbumId";
            this.albumIdDataGridViewTextBoxColumn.HeaderText = "AlbumId";
            this.albumIdDataGridViewTextBoxColumn.Name = "albumIdDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // artistIdDataGridViewTextBoxColumn
            // 
            this.artistIdDataGridViewTextBoxColumn.DataPropertyName = "ArtistName";
            this.artistIdDataGridViewTextBoxColumn.HeaderText = "아티스트";
            this.artistIdDataGridViewTextBoxColumn.Name = "artistIdDataGridViewTextBoxColumn";
            // 
            // AlbumListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvAlbum);
            this.Name = "AlbumListControl";
            this.Size = new System.Drawing.Size(603, 199);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsAlbum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlbum;
        private System.Windows.Forms.BindingSource bdsAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistIdDataGridViewTextBoxColumn;
    }
}

namespace Chinook.Forms
{
    partial class AlbumListForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbArtist = new System.Windows.Forms.ComboBox();
            this.bdsArtist = new System.Windows.Forms.BindingSource(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.dgvAlbum = new System.Windows.Forms.DataGridView();
            this.albumIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.artistIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsAlbum = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsArtist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsAlbum)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbArtist);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(679, 55);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "검색";
            // 
            // cbbArtist
            // 
            this.cbbArtist.DataSource = this.bdsArtist;
            this.cbbArtist.DisplayMember = "Name";
            this.cbbArtist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbArtist.FormattingEnabled = true;
            this.cbbArtist.Location = new System.Drawing.Point(99, 19);
            this.cbbArtist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbArtist.Name = "cbbArtist";
            this.cbbArtist.Size = new System.Drawing.Size(106, 20);
            this.cbbArtist.TabIndex = 2;
            this.cbbArtist.ValueMember = "ArtistId";
            this.cbbArtist.SelectedIndexChanged += new System.EventHandler(this.CbbArtist_SelectedIndexChanged);
            // 
            // bdsArtist
            // 
            this.bdsArtist.DataSource = typeof(Chinook.Data.Artist);
            this.bdsArtist.Sort = "Name";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(607, 18);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(66, 22);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "검색(&S)";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(5, 19);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(88, 21);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Leave += new System.EventHandler(this.TxtTitle_Leave);
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
            this.dgvAlbum.Location = new System.Drawing.Point(12, 79);
            this.dgvAlbum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAlbum.Name = "dgvAlbum";
            this.dgvAlbum.RowHeadersWidth = 51;
            this.dgvAlbum.RowTemplate.Height = 27;
            this.dgvAlbum.Size = new System.Drawing.Size(679, 281);
            this.dgvAlbum.TabIndex = 2;
            this.dgvAlbum.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAlbum_CellValueChanged);
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
            this.artistIdDataGridViewTextBoxColumn.DataPropertyName = "ArtistId";
            this.artistIdDataGridViewTextBoxColumn.HeaderText = "ArtistId";
            this.artistIdDataGridViewTextBoxColumn.Name = "artistIdDataGridViewTextBoxColumn";
            // 
            // bdsAlbum
            // 
            this.bdsAlbum.DataSource = typeof(Chinook.Data.Album);
            // 
            // AlbumListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 371);
            this.Controls.Add(this.dgvAlbum);
            this.Controls.Add(this.groupBox1);
            this.Name = "AlbumListForm";
            this.Text = "AlbumListForm";
            this.Load += new System.EventHandler(this.AlbumListForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsArtist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsAlbum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbArtist;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.DataGridView dgvAlbum;
        private System.Windows.Forms.BindingSource bdsArtist;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn artistIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bdsAlbum;
    }
}
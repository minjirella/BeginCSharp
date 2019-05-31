namespace Team.WinForm
{
    partial class Scenario3
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
            this.searchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textInvoiceId = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AlbumTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.albumIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(297, 31);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 0;
            this.searchBtn.Text = "검색";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "구매번호 (숫자)";
            // 
            // textInvoiceId
            // 
            this.textInvoiceId.Location = new System.Drawing.Point(191, 32);
            this.textInvoiceId.Name = "textInvoiceId";
            this.textInvoiceId.Size = new System.Drawing.Size(100, 24);
            this.textInvoiceId.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelTotal);
            this.groupBox1.Controls.Add(this.Total);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.textInvoiceId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.searchBtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 460);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "구매번호를 입력하면 구매한 노래제목이 출력되어요";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(319, 437);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(16, 18);
            this.labelTotal.TabIndex = 4;
            this.labelTotal.Text = "0";
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Location = new System.Drawing.Point(212, 437);
            this.Total.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(89, 18);
            this.Total.TabIndex = 4;
            this.Total.Text = "총 구매 가격 :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trackIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.albumIdDataGridViewTextBoxColumn,
            this.AlbumTitle});
            this.dataGridView1.DataSource = this.trackBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(367, 370);
            this.dataGridView1.TabIndex = 3;
            // 
            // AlbumTitle
            // 
            this.AlbumTitle.DataPropertyName = "AlbumTitle";
            this.AlbumTitle.HeaderText = "AlbumTitle";
            this.AlbumTitle.Name = "AlbumTitle";
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
            // trackBindingSource
            // 
            this.trackBindingSource.DataSource = typeof(Team.Data.Track);
            // 
            // Scenario3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(384, 464);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(400, 503);
            this.MinimumSize = new System.Drawing.Size(400, 503);
            this.Name = "Scenario3";
            this.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Text = "구매목록조회";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textInvoiceId;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.BindingSource trackBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn albumIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlbumTitle;
    }
}


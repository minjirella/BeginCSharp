namespace MathQuiz.Forms
{
    partial class MainForm
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
            this.btnStart = new System.Windows.Forms.Button();
            this.uscTime = new MathQuiz.Controls.TimeControl();
            this.uscMinus = new MathQuiz.QuizControl();
            this.uscProduct = new MathQuiz.QuizControl();
            this.uscDividen = new MathQuiz.QuizControl();
            this.uscPlus = new MathQuiz.QuizControl();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.AutoSize = true;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(143, 290);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(148, 34);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start the quiz";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // uscTime
            // 
            this.uscTime.Location = new System.Drawing.Point(32, 12);
            this.uscTime.Name = "uscTime";
            this.uscTime.Padding = new System.Windows.Forms.Padding(5);
            this.uscTime.Size = new System.Drawing.Size(406, 49);
            this.uscTime.TabIndex = 5;
            this.uscTime.TimeFinished += new System.EventHandler<MathQuiz.Controls.TimeControl.TimeFinishedEventArgs>(this.UscTime_TimeFinished);
            this.uscTime.Elapsed += new System.EventHandler<MathQuiz.Controls.TimeControl.ElapsedEventArgs>(this.UscTime_Elapsed);
            // 
            // uscMinus
            // 
            this.uscMinus.Location = new System.Drawing.Point(32, 120);
            this.uscMinus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uscMinus.Name = "uscMinus";
            this.uscMinus.Operator = "-";
            this.uscMinus.Padding = new System.Windows.Forms.Padding(4);
            this.uscMinus.Size = new System.Drawing.Size(393, 47);
            this.uscMinus.TabIndex = 1;
            // 
            // uscProduct
            // 
            this.uscProduct.Location = new System.Drawing.Point(32, 172);
            this.uscProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uscProduct.Name = "uscProduct";
            this.uscProduct.Operator = "*";
            this.uscProduct.Padding = new System.Windows.Forms.Padding(4);
            this.uscProduct.Size = new System.Drawing.Size(393, 47);
            this.uscProduct.TabIndex = 2;
            // 
            // uscDividen
            // 
            this.uscDividen.Location = new System.Drawing.Point(32, 224);
            this.uscDividen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uscDividen.Name = "uscDividen";
            this.uscDividen.Operator = "/";
            this.uscDividen.Padding = new System.Windows.Forms.Padding(4);
            this.uscDividen.Size = new System.Drawing.Size(393, 47);
            this.uscDividen.TabIndex = 3;
            // 
            // uscPlus
            // 
            this.uscPlus.Location = new System.Drawing.Point(32, 68);
            this.uscPlus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uscPlus.Name = "uscPlus";
            this.uscPlus.Padding = new System.Windows.Forms.Padding(4);
            this.uscPlus.Size = new System.Drawing.Size(393, 47);
            this.uscPlus.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 342);
            this.Controls.Add(this.uscTime);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.uscMinus);
            this.Controls.Add(this.uscProduct);
            this.Controls.Add(this.uscDividen);
            this.Controls.Add(this.uscPlus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QuizControl uscPlus;
        private QuizControl uscDividen;
        private QuizControl uscProduct;
        private QuizControl uscMinus;
        private System.Windows.Forms.Button btnStart;
        private Controls.TimeControl uscTime;
    }
}
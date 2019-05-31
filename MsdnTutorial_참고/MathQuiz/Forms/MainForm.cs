using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            _quizControls.Add(uscPlus);
            _quizControls.Add(uscMinus);
            _quizControls.Add(uscProduct);
            _quizControls.Add(uscDividen);
        }

        private List<QuizControl> _quizControls = new List<QuizControl>();

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        
        private bool HasRightAnswers()
        {
            foreach (var control in _quizControls)
                if (control.HasRightAnswer() == false)
                    return false;

            return true;

            //return _quizControls.All(x => x.HasRightAnswer());
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            foreach (var control in _quizControls)
                control.Generate();
            uscTime.Start(); // tmrTimer.Enabled = true;
        }

        private void UscTime_Elapsed(object sender, Controls.TimeControl.ElapsedEventArgs e)
        {
            if (HasRightAnswers() == false)
                return;

            uscTime.Stop();
            MessageBox.Show("축하한다능");
            btnStart.Enabled = true;
            
         }

        private void UscTime_TimeFinished(object sender, Controls.TimeControl.TimeFinishedEventArgs e)
        {
            MessageBox.Show("끝났다는");
            btnStart.Enabled = true;
        }
    }
}

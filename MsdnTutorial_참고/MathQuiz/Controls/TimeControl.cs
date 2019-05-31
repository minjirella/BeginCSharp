using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz.Controls
{
    public partial class TimeControl : UserControl
    {
        public TimeControl()
        {
            InitializeComponent();
        }

        private int _remainingTime;

        #region TimeFinished event things for C# 3.0
        public event EventHandler<TimeFinishedEventArgs> TimeFinished;

        protected virtual void OnTimeFinished(TimeFinishedEventArgs e)
        {
            if (TimeFinished != null)
                TimeFinished(this, e);
        }

        private TimeFinishedEventArgs OnTimeFinished()
        {
            TimeFinishedEventArgs args = new TimeFinishedEventArgs();
            OnTimeFinished(args);

            return args;
        }

        /*private TimeFinishedEventArgs OnTimeFinishedForOut()
        {
            TimeFinishedEventArgs args = new TimeFinishedEventArgs();
            OnTimeFinished(args);

            return args;
        }*/

        public class TimeFinishedEventArgs : EventArgs
        {


            /*public TimeFinishedEventArgs()
            {
            }

            public TimeFinishedEventArgs()
            {

            }*/
        }
        #endregion

        #region Elapsed event things for C# 3.0
        public event EventHandler<ElapsedEventArgs> Elapsed;

        protected virtual void OnElapsed(ElapsedEventArgs e)
        {
            if (Elapsed != null)
                Elapsed(this, e);
        }

        private ElapsedEventArgs OnElapsed(int remainingTime)
        {
            ElapsedEventArgs args = new ElapsedEventArgs(remainingTime);
            OnElapsed(args);

            return args;
        }

        private ElapsedEventArgs OnElapsedForOut()
        {
            ElapsedEventArgs args = new ElapsedEventArgs();
            OnElapsed(args);

            return args;
        }

        public class ElapsedEventArgs : EventArgs
        {
            public int RemainingTime { get; set; }

            public ElapsedEventArgs()
            {
            }

            public ElapsedEventArgs(int remainingTime)
            {
                RemainingTime = remainingTime;
            }
        }
        #endregion

        private void TmrTimer_Tick(object sender, EventArgs e)
        {
            _remainingTime--;
            
            if (_remainingTime > 0)
            {
                lblTime.Text = $"{_remainingTime}초 남았다는";
            }
            else
            {
                tmrTimer.Stop();
                OnTimeFinished();
            }

            OnElapsed(_remainingTime);
        }

        public void Start(int remainingTime = 30)
        {
            _remainingTime = remainingTime;
            
            tmrTimer.Start();
        }

        public void Stop()
        {
            tmrTimer.Stop();
        }
    }

}

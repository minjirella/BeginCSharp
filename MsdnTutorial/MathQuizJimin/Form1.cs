using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuizJimin
{
    public partial class Form1 : Form
    {
        //랜덤변수 생성
        Random randomizer = new Random();

        int addend1, addend2;
        int minuend, subtrahend;
        int multiplicand, multiplier;
        int dividend, divisor;

        int timeLeft;

        public void StartTheQuiz()
        {
            //덧셈
            addend1 = randomizer.Next(100);
            addend2 = randomizer.Next(100);

            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            sum.Value = 0;

            //뺄셈
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            minus.Value = 0;

            //곱셈
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);

            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            product.Value = 0;

            //나눗셈
            divisor = randomizer.Next(2, 11);
            int temp = randomizer.Next(2, 11);
            dividend = temp * divisor;

            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();

            timeLeft = 30;
            timeLabel.Text = "제한시간 30초";
            timer.Start();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(CheckTheAnswer())
            {
                timer.Stop();
                MessageBox.Show("ㅊㅋㅊㅋㅊㅋ!", "정답");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                timeLeft--;
                timeLabel.Text = timeLeft + "초";
            }
            else
            {
                timer.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("시간이 초과되었습니다.", "미안하다!!");
                sum.Value = addend1 + addend2;
                minus.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                startButton.Enabled = true;
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            // sender를 numericUpDown으로 casting 시도해보는것
            // casting이 되지않는다면 null이 선택된다.
            NumericUpDown answerBox = sender as NumericUpDown;

            if(answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == sum.Value) 
                && (minuend - subtrahend == minus.Value)
                && (multiplicand * multiplier == product.Value)
                && (dividend / divisor == quotient.Value))
                return true;
            else return false;
        }
    }
}

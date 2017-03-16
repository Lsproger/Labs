using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class FCalc : Form
    {
        Calculator c = new Calculator();
        public delegate void butDig(char d);
        public event butDig DigitClick;
        private char[] symbols = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
            ',','+','-','*','/', '=' };
        private string tmpRes = null;
      
        private string memory = null;

        public FCalc()
        {
            InitializeComponent();
            DigitClick += FCalc_DigitClick;
        }

        private void FCalc_DigitClick(char d)
        {
            InputBox.Text += d;
        }

        private void FCalc_Load(object sender, EventArgs e)
        {

        }

        private void ONE_Click(object sender, EventArgs e)
        {
            DigitClick(symbols[1]);
        }

        private void TWO_Click(object sender, EventArgs e)
        {
            DigitClick(symbols[2]);
        }

        private void THREE_Click(object sender, EventArgs e)
        {
            DigitClick(symbols[3]);
        }

        private void FOUR_Click(object sender, EventArgs e)
        {
            DigitClick(symbols[4]);
        }


        private void FIVE_Click(object sender, EventArgs e)
        {
            DigitClick(symbols[5]);
        }

        private void SIX_Click(object sender, EventArgs e)
        {
            DigitClick(symbols[6]);
        }

        private void SEVEN_Click(object sender, EventArgs e)
        {
            DigitClick(symbols[7]);
        }


        private void EIGHT_Click(object sender, EventArgs e)
        {
            DigitClick(symbols[8]);
        }

        private void NINE_Click(object sender, EventArgs e)
        {
            DigitClick(symbols[9]);
        }

        private void ZERO_Click(object sender, EventArgs e)
        {
            DigitClick(symbols[0]);
        }

        private void POINT_Click(object sender, EventArgs e)
        {
            DigitClick(symbols[10]);
        }

        private void ChangeToken_Click(object sender, EventArgs e)
        {

        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            InputBox.Text = null;
        }

        private void SUMM_Click(object sender, EventArgs e)
        {
            DigitClick(symbols[11]);
        }

        private void SUBSTR_Click(object sender, EventArgs e)
        {
            DigitClick(symbols[12]);
        }

        private void DIVIDE_Click(object sender, EventArgs e)
        {
            DigitClick(symbols[14]);
        }

        private void MULTIPLY_Click(object sender, EventArgs e)
        {
            DigitClick(symbols[13]);
        }

        private void SINc_Click(object sender, EventArgs e)
        {
            Legend.Clear();
            tmpRes = Calculator.Sin(InputBox.Text);
            Legend.Text = '=' + tmpRes;
            InputBox.Clear();
        }

        private void COSc_Click(object sender, EventArgs e)
        {
            Legend.Clear();
            tmpRes = Calculator.Cos(InputBox.Text);
            Legend.Text = '=' + tmpRes;
            InputBox.Clear();
        }

        private void SQRT_Click(object sender, EventArgs e)
        {
            Legend.Clear();
            tmpRes = Calculator.Sqrt(InputBox.Text);
            Legend.Text ='='+ tmpRes;
            InputBox.Clear();
        }

        private void AddMemory_Click(object sender, EventArgs e)
        {
            memory = tmpRes;
        }

        private void RemoveMemory_Click(object sender, EventArgs e)
        {
            memory = null;
        }

        private void equally_Click(object sender, EventArgs e)
        {
            DigitClick(symbols[15]);
            Legend.Clear();
            try { 
            tmpRes = c.Calculate(InputBox.Text);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("OutOfRange exception!!\nArgument is not correct!!!\nMaximal lenght of chisla is can't be meow than 10 symbols!");
            }
            InputBox.Text += tmpRes;
            Legend.Text += InputBox.Text;
            InputBox.Clear();
        }

        private void Mem_Click(object sender, EventArgs e)
        {
            InputBox.Text += memory ;
        }
    }
}

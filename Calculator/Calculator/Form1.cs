namespace Calculator
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        string Operation;
      

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
            Operation = "+";
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
            Operation = "-";
        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
            Operation = "*";
        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = null;
            Operation = "/";
        }

        private void btneq_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(textBox1.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    textBox1.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void btnsin_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != null)
                {
                    double result;
                    result = Convert.ToDouble(textBox1.Text);
                    result = Math.Sin(result);
                    textBox1.Text = result.ToString(); ;
                }
            }
            catch
            {
                textBox1.Text = "Error!";
            };
           
            
        }

        private void btncos_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != null)
                {
                    double result;
                    result = Convert.ToDouble(textBox1.Text);
                    result = Math.Cos(result);
                    textBox1.Text = result.ToString(); ;
                }
            }
            catch
            {
                textBox1.Text = "Error!";
            };


        }

        private void btntan_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != null)
                {
                    double result;
                    result = Convert.ToDouble(textBox1.Text);
                    result = Math.Tan(result);
                    textBox1.Text = result.ToString(); ;
                }
            }
            catch
            {
                textBox1.Text = "Error!";
            };

        }

        private void btnsq_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != null)
                {
                    double result;
                    result = Convert.ToDouble(textBox1.Text);
                    result = Math.Pow(result, 2);
                    textBox1.Text = result.ToString(); ;
                }
            }
            catch
            {
                textBox1.Text = "Error!";
            };

        }

        private void btnroot_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != null)
                {
                    double result;
                    result = Convert.ToDouble(textBox1.Text);
                    result = Math.Sqrt(result);
                    textBox1.Text = result.ToString(); ;
                }
            }
            catch
            {
                textBox1.Text = "Error!";
            };
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int index = textBox1.Text.Length;
            index--;
            textBox1.Text = textBox1.Text.Remove(index);
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }

        private void btnplusminus_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != null)
                {
                    double result;
                    result = Convert.ToDouble(textBox1.Text);
                    result = result * -1;
                    textBox1.Text = result.ToString(); ;
                }
            }
            catch
            {
                textBox1.Text = "Error!";
            };
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != null)
                {
                    double result;
                    result = Convert.ToDouble(textBox1.Text);
                    result = Math.Log10(result);
                    textBox1.Text = result.ToString(); ;
                }
            }
            catch
            {
                textBox1.Text = "Error!";
            };
        }

        private void btnLnx_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != null)
                {
                    double result;
                    result = Convert.ToDouble(textBox1.Text);
                    result = Math.Log(result);
                    textBox1.Text = result.ToString(); ;
                }
            }
            catch
            {
                textBox1.Text = "Error!";
            };
        }

        private void btnreverse_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != null)
                {
                    double result;
                    result = Convert.ToDouble(textBox1.Text);
                    result = 1/result;
                    textBox1.Text = result.ToString(); ;
                }
            }
            catch
            {
                textBox1.Text = "Error!";
            };
        }

        private void btnPI_Click(object sender, EventArgs e)
        {
            double result;
            result = Math.PI;
            textBox1.Text = result.ToString();
        }
    }
}
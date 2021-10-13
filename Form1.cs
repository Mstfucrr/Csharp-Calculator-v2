using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private float Texbox1_pull_data()
        {
            float data;
            try
            {
                data = Convert.ToSingle(textBox1.Text);
            }
            catch (Exception)
            {
                data = 0;
            }
            return data;
        }

        float result, number1 = 0, Res = 0;
        string isaret = "";
        bool equ = false;



        private void Tiklanan_Harf(object sender, EventArgs e)
        {

            Label TiklananLabel = sender as Label;
            if (textBox1.Text == "0" || equ)
                textBox1.Clear();
            equ = false;
            textBox1.Text += TiklananLabel.Text;
        }

        private void backSpace_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == "0")
                textBox1.Text = "0";
            else
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Button clear_click = sender as Button;
            if (clear_click.Text == "C")
            {
                textBox1.Text = "0";
                result = 0;
                isaret = "";
                history.Text = "";
                equ = false;
                number1 = 0;
                Res = 0;
                der_res = 0;
                derece = 0;

            }
            else
                textBox1.Text = "0";

        }

        private void onedivxbtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = (1 / Texbox1_pull_data()).ToString();
            equ = true;
        }

        private void pow2_Click(object sender, EventArgs e)
        {

            textBox1.Text = (Texbox1_pull_data() * Texbox1_pull_data()).ToString();
            equ = true;
        }

        private void Sqrt_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Sqrt(Texbox1_pull_data()).ToString();
            equ = true;
        }
        double der_res, derece;

        private void dort_islem(object sender, EventArgs e)
        {
            Label TiklananIslem = sender as Label;
            if (TiklananIslem.Text == "+")
                isaret = " + ";
            else if (TiklananIslem.Text == "-")
                isaret = " - ";
            else if (TiklananIslem.Text == "x")
                isaret = " x ";
            else if (TiklananIslem.Text == "÷")
                isaret = " ÷ ";

            if (number1 != Texbox1_pull_data() || !equ)
            {
                if (number1 == 0 && Res == 0)
                {
                    number1 = Texbox1_pull_data();
                    Res = 1;
                }
                else
                {
                    if (isaret == " + ")
                        number1 += Texbox1_pull_data();
                    if (isaret == " - ")
                        number1 -= Texbox1_pull_data();
                    if (isaret == " x ")
                        number1 *= Texbox1_pull_data();
                    if (isaret == " ÷ ")
                        number1 /= Texbox1_pull_data();

                }
                history.Text = number1.ToString() + isaret;
                textBox1.Text = number1.ToString();
                equ = true;
            }
            else
            {
                history.Text = number1.ToString() + isaret;
                textBox1.Text = number1.ToString();
            }

        }

        private void Trigonometri_btns(object sender, EventArgs e)
        {
            Label TiklananTrigonoIslem = sender as Label;
            derece = Convert.ToDouble(Texbox1_pull_data()) * Math.PI / 180;
            
            if (TiklananTrigonoIslem.Text == "sin(x°)")
                der_res = Math.Sin(derece);
            else if (TiklananTrigonoIslem.Text == "cos(x°)")
                der_res = Math.Cos(derece);
            else if (TiklananTrigonoIslem.Text == "tan(x°)")
                der_res = Math.Tan(derece);
            else if (TiklananTrigonoIslem.Text == "cot(x°)")
                der_res = 1 / Math.Tan(derece);

            textBox1.Text = der_res.ToString();
            equ = true;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            if (number1 != Texbox1_pull_data() || !equ)
            {
                if (number1 != 0 || result != 0)
                {
                    if (isaret == " + ")
                        result = number1 + Texbox1_pull_data();
                    else if (isaret == " - ")
                        result = number1 - Texbox1_pull_data();
                    else if (isaret == " x ")
                        result = number1 * Texbox1_pull_data();
                    else if (isaret == " ÷ ")
                        result = number1 / Texbox1_pull_data();

                    history.Text = number1.ToString() + " " + isaret + Texbox1_pull_data().ToString() + " = ";
                    textBox1.Text = result.ToString();
                    number1 = result;
                    result = 0;
                }
                else
                {
                    textBox1.Text = "0";
                }
            }

            equ = true;


        }
    }
}

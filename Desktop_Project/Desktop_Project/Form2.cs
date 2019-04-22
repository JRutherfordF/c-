using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_Project
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
        }
        //GLOBAL
        decimal num1 = 0;
        decimal num2 = 0;
        decimal res = 0;
        char op = 'N';
        private void button28_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void calc_0_Click(object sender, EventArgs e)
        {
            txt_res.Text = txt_res.Text + "0";
        }

        private void calc_1_Click(object sender, EventArgs e)
        {
            txt_res.Text = txt_res.Text + "1";
        }

        private void calc_2_Click(object sender, EventArgs e)
        {
            txt_res.Text = txt_res.Text + "2";
        }

        private void calc_3_Click(object sender, EventArgs e)
        {
            txt_res.Text = txt_res.Text + "3";
        }

        private void calc_4_Click(object sender, EventArgs e)
        {
            txt_res.Text = txt_res.Text + "4";
        }

        private void calc_5_Click(object sender, EventArgs e)
        {
            txt_res.Text = txt_res.Text + "5";
        }

        private void calc_6_Click(object sender, EventArgs e)
        {
            txt_res.Text = txt_res.Text + "6";
        }

        private void calc_7_Click(object sender, EventArgs e)
        {
            txt_res.Text = txt_res.Text + "7";
        }

        private void calc_8_Click(object sender, EventArgs e)
        {
            txt_res.Text = txt_res.Text + "8";
        }

        private void calc_9_Click(object sender, EventArgs e)
        {
            txt_res.Text = txt_res.Text + "9";
        }

        private void calc_min_MouseClick(object sender, MouseEventArgs e)
        {
            op = '-';
            num1 = Convert.ToDecimal(txt_res.Text);
            txt_res.Text = " ";
        }

        private void calc_plus_MouseClick(object sender, MouseEventArgs e)
        {
            op = '+';
            num1 = Convert.ToDecimal(txt_res.Text);
            txt_res.Text = " ";
        }

        private void calc_asth_MouseClick(object sender, MouseEventArgs e)
        {
            op = '*';
            num1 = Convert.ToDecimal(txt_res.Text);
            txt_res.Text = " ";
        }

        private void calc_slash_Click(object sender, EventArgs e)
        {
            op = '/';
            num1 = Convert.ToDecimal(txt_res.Text);
            txt_res.Text = " ";
        }
        private void calc_percent_Click(object sender, EventArgs e)
        {
            op = '%';
            num1 = Convert.ToDecimal(txt_res.Text);
            txt_res.Text = " ";
        }

        private void txt_res_TextChanged(object sender, EventArgs e)
        {

        }

        private void calc_equ_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDecimal(txt_res.Text);
            Clase_Calculadora Calculadora_instanciada = new Clase_Calculadora(num1, num2, res, op);
            //guarda eso con los datos 
            switch (op)
            {
                case '+':
                    {
                        txt_res.Text = Convert.ToString(Calculadora_instanciada.sumar());
                        break;
                    }

            }
        }

        private void calc_c_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            res = 0;
            txt_res.Text = " ";
        }

        private void calc_ce_Click(object sender, EventArgs e)
        {
            txt_res.Text = " ";
        }

        private void calc_back_Click(object sender, EventArgs e)
        {
            //verifies that txt_res isn't 0
            if (txt_res.Text.Length > 0)
            {
                String minusonep1 = txt_res.Text;
                String minusonep2 = minusonep1.Substring(0, minusonep1.Length - 1);
                //removes the last character
                txt_res.Text = minusonep2;
            }
        }

        private void calc_root_Click(object sender, EventArgs e)
        {
            double num1d = 0;
            num1d = Convert.ToDouble(txt_res.Text);
            num2 = Convert.ToDecimal(Math.Sqrt(num1d));
            txt_res.Text = num2.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculato
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

        private void button4_Click(object sender, EventArgs e)
        {
            double firstnumber = Convert.ToDouble(textBox1.Text);
            double secondnumber = Convert.ToDouble(textBox2.Text);
            double result;
            switch (((Button)sender).Name)
            {
                case "plus":
                    result = firstnumber + secondnumber;
                    break;
                case "minus":
                    result = firstnumber - secondnumber;
                    break;
                case "multiply":
                    result = firstnumber * secondnumber;
                    break;
                case "devision":
                    result = firstnumber / secondnumber;
                    break;
                default:
                    throw new Exception("Error");

            }
            conclusion.Text = result.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }


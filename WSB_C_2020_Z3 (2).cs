using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public double liczba1;
        public double liczba2;
        private string cal;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void plikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            liczba1 = 0;
            liczba2 = 0;
            cal = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += button1.Text;
           
        }

        public void wynik()
        {

            liczba2 = System.Double.Parse(textBox1.Text);
            switch (cal)
            {
                case "+":
                    liczba1 = liczba1 + liczba2;
                    break;
                case "-":
                    liczba1 = liczba1 - liczba2;
                    break;
                case "*":
                    liczba1 = liczba1 * liczba2;
                    break;
                case "/":
                    liczba1 = liczba1 / liczba2;
                    break;
                
            }
            textBox1.Text = liczba1.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            wynik();
        }

        private void button7_Click(object sender, EventArgs e)
        {   
             
            liczba1 = System.Double.Parse(textBox1.Text);
            cal = "+";
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += button4.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += button6.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += button13.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += button12.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += button11.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = button10.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            liczba1 = System.Double.Parse(textBox1.Text);
            cal = "-";
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            liczba1 = System.Double.Parse(textBox1.Text);
            cal = "*";
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            liczba1 = System.Double.Parse(textBox1.Text);
            cal = "/";
            textBox1.Text = "";
        }
      } 
 }

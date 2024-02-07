using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        string regneart;
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Visk_Click(object sender, EventArgs e)
        {
            txtNum1.Text = string.Empty;
            txtNum2.Text = string.Empty;
            txtSvar.Text = string.Empty;
        }

        private void Avslutt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Svar_Click(object sender, EventArgs e)
        {
            float num1 = float.Parse(txtNum1.Text);
            float num2 = float.Parse(txtNum2.Text);
            float svar;
            if (regneart == "+")
            {
                svar = num1 + num2;
                txtSvar.Text = svar.ToString();

            }
            else if (regneart == "-")
            {
                svar = num1 - num2;
                txtSvar.Text = svar.ToString();

            }
            else if (regneart == "*")
            {
                svar = num1 * num2;
                txtSvar.Text = svar.ToString();

            }
            else if (regneart == "/")
            {
                svar = num1 / num2;
                txtSvar.Text = svar.ToString();
            }
            else
            {
                txtSvar.Text = "error";
                
            }
        }

        private void regneartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            count += 1;
            if (count == 1)
            {
                regneart = "+";
                lblRegneart.Text = regneart;
            }
            else if (count == 2)
            {
                regneart = "-";
                lblRegneart.Text = regneart;
            }
            else if(count == 3)
            {
                regneart = "*";
                lblRegneart.Text = regneart;
            }
            else if (count == 4)
            {
                regneart = "/";
                count = 0;
                lblRegneart.Text = regneart;
            }
            else if (count == 0)
            {
                lblRegneart.Text = "Ingen regneart valgt";
            }
            
        }
    }
}

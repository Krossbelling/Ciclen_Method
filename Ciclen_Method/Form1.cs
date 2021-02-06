using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ciclen_Method
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
        }
        private void Number(object sender, KeyPressEventArgs e)// Разрешить вводить только цифры, символ backspace, запятую
        {
            char charCode = e.KeyChar;
            if (!char.IsDigit(charCode) && charCode != 8 && charCode != 44)
                e.Handled = true;
        }

        private void Solve_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(a_textbox.Text);
                double b = double.Parse(b_textbox.Text);
                double x0 = double.Parse(x0_textbox.Text);
                double N = double.Parse(N_numUpDown.Text);
                double y0 = double.Parse(y0_textbox.Text);
                double eps = double.Parse(eps_textbox.Text);
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                label1.Visible = false;
                dif_textbox.Visible = false;
                SolveButton.Visible = false;

                var uc = new ResultControl(this);
                if (Result.Controls.Count > 0)
                    Result.Controls.RemoveAt(0);
                Result.Controls.Add(uc);



                if (EulerBox.Checked == true)
                {
                    Method_Eulers(a, b, x0, N, y0, eps);
                }
                if (ChordBox.Checked == true)
                {
                    Method_Chord(a, b, x0, N, y0, eps);
                }                
            }
            catch (Exception exept)
            {
                MessageBox.Show("Решить не удалось" + ".\n " + exept.Message + "\n " + "Проверьте ввод a, b, x0, N, y0, eps.");
            }
        }
        private static void Method_Eulers(double a, double b, double x0, double N, double y0, double eps)
        {

        }
        private static void Method_Chord(double a, double b, double x0, double N, double y0, double eps)
        {

        }       
        public static void OpenHide(object sender, EventArgs e)
        {


        }
        
    }
}

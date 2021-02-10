using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ciclen_Method
{    
    public partial class InputControl : UserControl
    {
        static double a;
        static double b;
        static double x0;
        static double N;
        static double y0;
        static double eps;
        public InputControl()
        {
            InitializeComponent();
            a_textbox.Text = a.ToString();
            b_textbox.Text = b.ToString();
            x0_textbox.Text = x0.ToString();
            N_numUpDown.Text = N.ToString();
            y0_textbox.Text = y0.ToString();
            eps_textbox.Text = eps.ToString();
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
                a = double.Parse(a_textbox.Text);
                b = double.Parse(b_textbox.Text);
                x0 = double.Parse(x0_textbox.Text);
                N = double.Parse(N_numUpDown.Text);
                y0 = double.Parse(y0_textbox.Text);
                eps = double.Parse(eps_textbox.Text);                                               

                if (EulerBox.Checked == true)
                {
                    Method_Eulers(a, b, x0, N, y0, eps);
                }
                if (ChordBox.Checked == true)
                {
                    Method_Chord(a, b, x0, N, y0, eps);
                }                

                // пытаемся получить ссылку на интерфейс навигатора,
                // который должна реализовать форма Form1, на которой находится сейчас экземпляр UserControl1
                INavigator navigator = this.ParentForm as INavigator;
                // если это не так, выходим
                if (navigator == null) return;
                // вызываем метод, который создаст и разместит экземпляр UserControl2 на панели Panel1 формы Form1
                navigator.CreateAndPlaceToPage(typeof(ResultControl));
                
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
        
    }
}

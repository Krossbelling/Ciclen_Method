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
        public static double a;
        public static double b;
        public static double x0;
        public static int N;
        public static double y0;
        public static int eps;
        static double f;
        static string uravn = "";
        public static double[] x;
        public static double[] y;
        static bool Eulerbox;
        static bool Chordbox;
        static bool Euler_recalbox;
        static bool Runge_kuttabox;
        static bool Milnabox;
        static bool Adamsbox;


        public InputControl()
        {
            InitializeComponent();
            a_textbox.Text = a.ToString();
            b_textbox.Text = b.ToString();
            x0_textbox.Text = x0.ToString();
            N_numUpDown.Text = N.ToString();
            y0_textbox.Text = y0.ToString();
            eps_textbox.Text = eps.ToString();
            if (uravn != "")
            {
                dif_textbox.Text = uravn;
            }
            else
                dif_textbox.Text = "";

            if (Eulerbox == true)
                EulerBox.Checked = true;

            if (Chordbox == true)
                ChordBox.Checked = true;

            if (Euler_recalbox == true)
                Euler_recalBox.Checked = true;

            if (Runge_kuttabox == true)
                Runge_kuttaBox.Checked = true;

            if (Milnabox == true)
                MilnaBox.Checked = true;

            if (Adamsbox == true)
                AdamsBox.Checked = true;
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
                N = int.Parse(N_numUpDown.Text);
                y0 = double.Parse(y0_textbox.Text);
                eps = int.Parse(eps_textbox.Text);
                uravn = dif_textbox.Text;
                x = new double[N];
                y = new double[N];
                

                if (EulerBox.Checked == true)
                {
                    Eulerbox = true;
                    Method_Eulers(a, b, x0, N, y0, eps, x, y);                                       

                    //var column1 = new DataGridViewColumn();
                    //column1.HeaderText = "X"; //текст в шапке
                    //column1.Width = 100; //ширина колонки
                    //column1.ReadOnly = true; //значение в этой колонке нельзя править
                    //column1.Name = "x"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
                    //column1.Frozen = true; //флаг, что данная колонка всегда отображается на своем месте
                    //column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки
                    //dataGridView1.Columns.Add(column1);
                    //var column2 = new DataGridViewColumn();
                    //column2.HeaderText = "Y"; //текст в шапке
                    //column2.Width = 100; //ширина колонки
                    //column2.ReadOnly = true; //значение в этой колонке нельзя править
                    //column2.Name = "y"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
                    //column2.Frozen = true; //флаг, что данная колонка всегда отображается на своем месте
                    //column2.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки
                    //dataGridView1.Columns.Add(column2);
                    //dataGridView1.AllowUserToAddRows = false; //запрешаем пользователю самому добавлять строки

                    //for (int i = 0; i < N; i++)
                    //{
                    //    //Добавляем строку, указывая значения колонок поочереди слева направо
                    //   dataGridView1.Rows.Add(i, x[i], Math.Round(y[i], int.Parse(eps_textbox.Text)));
                    //}

                }
                if (ChordBox.Checked == true)
                {
                    Chordbox = true;
                    Method_Chord(a, b, x0, N, y0, eps);
                }
                if (Euler_recalBox.Checked == true)
                {
                    Euler_recalbox = true;
                    Method_Euler_recal(a, b, x0, N, y0, eps);
                }
                if (Runge_kuttaBox.Checked == true)
                {
                    Runge_kuttabox = true;
                    Method_Runge_kutta(a, b, x0, N, y0, eps);
                }                              
                if (MilnaBox.Checked == true)
                {
                    Milnabox = true;
                    Method_Milna(a, b, x0, N, y0, eps);
                }
                if (AdamsBox.Checked == true)
                {
                    Adamsbox = true;
                    Method_Adams(a, b, x0, N, y0, eps);
                }

                if (EulerBox.Checked == false)
                    Eulerbox = false;

                if (ChordBox.Checked == false)
                    Chordbox = false;

                if (Euler_recalBox.Checked != true)
                    Euler_recalbox = false;

                if (Runge_kuttaBox.Checked != true)
                    Runge_kuttabox = false;

                if (MilnaBox.Checked != true)
                    Milnabox = false;

                if (AdamsBox.Checked != true)
                    Adamsbox = false;

                // пытаемся получить ссылку на интерфейс навигатора,
                // который должна реализовать форма Form1, на которой находится сейчас экземпляр UserControl1
                // если это не так, выходим
                if (!(ParentForm is INavigator navigator)) return;
                // вызываем метод, который создаст и разместит экземпляр UserControl2 на панели Panel1 формы Form1
                navigator.CreateAndPlaceToPage(typeof(ResultControl));
                //// пытаемся получить ссылку на интерфейс навигатора,
                //// который должна реализовать форма Form1, на которой находится сейчас экземпляр UserControl1
                //INavigator navigator = this.ParentForm as INavigator;
                //// если это не так, выходим
                //if (navigator == null) return;
                //// вызываем метод, который создаст и разместит экземпляр UserControl2 на панели Panel1 формы Form1
                //navigator.CreateAndPlaceToPage(typeof(ResultControl));



            }
            catch (Exception exept)
            {
                MessageBox.Show("Решить не удалось" + ".\n " + exept.Message + "\n " + "Проверьте ввод a, b, x0, N, y0, eps.");
            }
        }
        public static double F(double x, double y)
        {

            double F = y - x;
            return F;
        }
        private static void Method_Eulers(double a, double b, double x0, double N, double y0, double eps, double[] x, double[] y)
        {
            double h = (b - a) / N;
            x[0] = a;
            y[0] = b;
            for (int i = 1; i < N; i++)
            {
               x[i] = x[0] + i * h;
               y[i] = y[i - 1] + h * F(x[i - 1], y[i - 1]);

            }
        }
        private static void Method_Chord(double a, double b, double x0, double N, double y0, double eps)
        {

        }
        private static void Method_Euler_recal(double a, double b, double x0, double N, double y0, double eps)
        {

        }
        private static void Method_Runge_kutta(double a, double b, double x0, double N, double y0, double eps)
        {

        }        
        private static void Method_Milna(double a, double b, double x0, double N, double y0, double eps)
        {

        }
        private static void Method_Adams(double a, double b, double x0, double N, double y0, double eps)
        {

        }

    }
}

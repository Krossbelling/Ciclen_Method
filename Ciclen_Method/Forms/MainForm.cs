using Microsoft.SharePoint.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Ciclen_Method.Forms;

namespace Ciclen_Method
{
    public partial class MainForm : System.Windows.Forms.Form

    {
        private System.Windows.Forms.Form currentChildForm;        
        public static double a { get; set; }
        public static double b { get; set; }
        public static int N { get; set; }
        public static int eps { get; set; }
        static double f { get; set; }
        public static string uravn = "";
        public static double[] xEuler { get; set; }
        public static double[] yEuler { get; set; }
        public static double[] xChord { get; set; }
        public static double[] yChord { get; set; }
        public static double[] xEulerRecal { get; set; }
        public static double[] yEulerRecal { get; set; }
        public static double[] xIter { get; set; }
        public static double[] yIter { get; set; }
        public static bool Eulerbox { get;set; }
        public static bool Chordbox { get; set; }
        public static bool Euler_recalbox { get; set; }
        public static bool Itterbox { get; set; }
        public static bool Runge_kuttabox { get; set; }
        public static bool Milnabox { get; set; }
        public static bool Adamsbox { get; set; }
        
        double x0 { get; set; }
        double y0 { get; set; }
        public MainForm()
        {
            InitializeComponent();

            Text = string.Empty;
            ControlBox = false;
            DoubleBuffered = true;
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;

            a_textbox.Text = a.ToString();
            b_textbox.Text = b.ToString();
            x0_textbox.Text = x0.ToString();
            y0_textbox.Text = y0.ToString();
            N_numUpDown.Text = N.ToString();
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

            if (Itterbox == true)
                ItterBox.Checked = true;

            if (Runge_kuttabox == true)
                Runge_kuttaBox.Checked = true;

            if (Milnabox == true)
                MilnaBox.Checked = true;

            if (Adamsbox == true)
                AdamsBox.Checked = true;

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }
        private void OpenChildForm(System.Windows.Forms.Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PanelDesktop.Controls.Add(childForm);
            PanelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }



        private void Out_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                //if(sender != null)
                //{
                //    currentBtn = (Button)sender;
                //}

                ParserFunction.addFunction("sin", new SinFunction());
                ParserFunction.addFunction("cos", new CosFunction());
                ParserFunction.addFunction("pi", new PiFunction());
                ParserFunction.addFunction("exp", new ExpFunction());
                ParserFunction.addFunction("pow", new PowFunction());
                ParserFunction.addFunction("abs", new AbsFunction());
                ParserFunction.addFunction("sqrt", new SqrtFunction());

                ParserFunction.addFunction("x", new XFunction());
                ParserFunction.addFunction("y", new YFunction());

                a = double.Parse(a_textbox.Text);
                b = double.Parse(b_textbox.Text);
                x0 = double.Parse(x0_textbox.Text);
                y0 = double.Parse(y0_textbox.Text);
                N = int.Parse(N_numUpDown.Text);
                eps = int.Parse(eps_textbox.Text);
                uravn = dif_textbox.Text;
                
                
                

                if (EulerBox.Checked == true)
                {
                    Eulerbox = true;
                    Method_Eulers(a, b, x0, N, y0);                    

                }
                if (ChordBox.Checked)
                {
                    Chordbox = true;
                    Method_Chord(a, b, x0, N, y0);
                }
                if (Euler_recalBox.Checked)
                {
                    Euler_recalbox = true;
                    Method_Euler_recal(a, b, x0, N, y0);
                }
                if (ItterBox.Checked)
                {
                    Itterbox = true;
                    Method_itter(a,b,x0,N,y0);
                }                
                if (Runge_kuttaBox.Checked)
                {
                    Runge_kuttabox = true;
                    Method_Runge_kutta(a, b, x0, N, y0);
                }
                if (MilnaBox.Checked)
                {
                    Milnabox = true;
                    Method_Milna(a, b, x0, N, y0);
                }
                if (AdamsBox.Checked)
                {
                    Adamsbox = true;
                    Method_Adams(a, b, x0, N, y0);
                }

                if (!EulerBox.Checked)
                    Eulerbox = false;

                if (!ChordBox.Checked)
                    Chordbox = false;

                if (!Euler_recalBox.Checked)
                    Euler_recalbox = false;

                if (!ItterBox.Checked)
                    Itterbox = false;

                if (!Runge_kuttaBox.Checked)
                    Runge_kuttabox = false;

                if (!MilnaBox.Checked)
                    Milnabox = false;

                if (!AdamsBox.Checked)
                    Adamsbox = false;


                OpenChildForm(new ResultMainForm());

            }
            catch (Exception exept)
            {
                MessageBox.Show("Решить не удалось" + ".\n " + exept.Message + "\n " + "Проверьте ввод данных:" + "\n " + "дифференциальное уравнение, a, b, x0, y0, N, eps.");
            }
        }
        
        private static void Method_Eulers(double a, double b, double x0, int N, double y0)
        {
            xEuler = new double[N + 1];
            yEuler = new double[N + 1];
            double h = (b - a) / N;
            xEuler[0] = x0;
            yEuler[0] = y0;
            double FuncX;
            double FuncY;
            for (int i = 1; i < N+1; i++)
            {
                xEuler[i] = xEuler[0] + i * h;                
                FuncX = xEuler[i - 1];
                FuncY = yEuler[i - 1];
                f = Parser.process(FuncX, FuncY, uravn);
                yEuler[i] = yEuler[i - 1] + h * f;
            }
        }
        private static void Method_Chord(double a, double b, double x0, int N, double y0)
        {
            xChord = new double[N + 1];
            yChord = new double[N + 1];
            double h = (b - a) / N;
            xChord[0] = x0;
            yChord[0] = y0;                        
            double[] xpol = new double[N];
            double[] ypol = new double[N];
            double Fpol;
            for (int i = 1; i < N+1; i++)
            {
                xChord[i] = xChord[0] + i * h;
                f = Parser.process(xChord[i-1], yChord[i-1],uravn);
                xpol[i-1] = xChord[i-1] + h / 2;
                ypol[i-1] = yChord[i-1] + h / 2 * f;
                Fpol = Parser.process(xpol[i-1], ypol[i-1], uravn);
                yChord[i] = yChord[i-1] + h * Fpol;                              
            }

        }
        private static void Method_Euler_recal(double a, double b, double x0, int N, double y0)
        {

            xEulerRecal = new double[N + 1];
            yEulerRecal = new double[N + 1];
            double h = (b - a) / N;
            xEulerRecal[0] = x0;
            yEulerRecal[0] = y0;
            double[] ydash = new double[N+1];
            double Fdash;
            for (int i = 1; i < N + 1; i++)
            {
                xEulerRecal[i] = xEulerRecal[0] + i * h;
                f = Parser.process(xEulerRecal[i-1], yEulerRecal[i - 1], uravn);
                ydash[i] = yEulerRecal[i - 1] + h * f;
                Fdash = Parser.process(xEulerRecal[i], ydash[i], uravn);
                yEulerRecal[i] = yEulerRecal[i - 1] + h / 2 * (f+Fdash);

            }

        }
        private static void Method_itter(double a, double b, double x0, int N, double y0)
        {



        }
        private static void Method_Runge_kutta(double a, double b, double x0, int N, double y0)
        {

        }
        private static void Method_Milna(double a, double b, double x0, int N, double y0)
        {

        }
        private static void Method_Adams(double a, double b, double x0, int N, double y0)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                Refresh();
            }                
        }        
    }    
}

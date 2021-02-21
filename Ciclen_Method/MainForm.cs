﻿using Microsoft.SharePoint.Client;
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
        public static double a;
        public static double b;        
        public static int N;
        public static int eps;
        static double f;
        public static string uravn = "";
        public static double[] x;
        public static double[] y;
        public static double[] xChord;
        public static double[] yChord;
        public static bool Eulerbox;
        public static bool Chordbox;
        public static bool Euler_recalbox;
        public static bool Runge_kuttabox;
        public static bool Milnabox;
        public static bool Adamsbox;
        double x0;
        double y0;
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

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
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
                x = new double[N+1];
                y = new double[N+1];
                
                

                if (EulerBox.Checked == true)
                {
                    Eulerbox = true;
                    Method_Eulers(a, b, x0, N, y0, eps, x, y);                    

                }
                if (ChordBox.Checked)
                {
                    Chordbox = true;
                    Method_Chord(a, b, x0, N, y0, eps);
                }
                if (Euler_recalBox.Checked)
                {
                    Euler_recalbox = true;
                    Method_Euler_recal(a, b, x0, N, y0, eps);
                }
                if (Runge_kuttaBox.Checked)
                {
                    Runge_kuttabox = true;
                    Method_Runge_kutta(a, b, x0, N, y0, eps);
                }
                if (MilnaBox.Checked)
                {
                    Milnabox = true;
                    Method_Milna(a, b, x0, N, y0, eps);
                }
                if (AdamsBox.Checked)
                {
                    Adamsbox = true;
                    Method_Adams(a, b, x0, N, y0, eps);
                }

                if (!EulerBox.Checked)
                    Eulerbox = false;

                if (!ChordBox.Checked)
                    Chordbox = false;

                if (!Euler_recalBox.Checked)
                    Euler_recalbox = false;

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
        
        private static void Method_Eulers(double a, double b, double x0, double N, double y0, double eps, double[] x, double[] y)
        {
            double h = (b - a) / N;
            x[0] = x0;
            y[0] = y0;
            double FuncX;
            double FuncY;
            for (int i = 1; i < N+1; i++)
            {
                x[i] = x[0] + i * h;                
                FuncX = x[i - 1];
                FuncY = y[i - 1];
                f = Parser.process(FuncX, FuncY, uravn);
                y[i] = y[i - 1] + h * f;
            }
        }
        private static void Method_Chord(double a, double b, double x0, int N, double y0, double eps)
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

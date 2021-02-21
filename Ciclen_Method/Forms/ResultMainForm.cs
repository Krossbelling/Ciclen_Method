using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;
using FontAwesome.Sharp;

namespace Ciclen_Method.Forms
{
    public partial class ResultMainForm : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private System.Windows.Forms.Form currentChildForm;
        private Control currentChildControl;
        private static bool allchart;

        private static void ButtonColor(IconButton iconButton)
        {
            iconButton.BackColor = Color.FromArgb(153, 180, 209);
            iconButton.IconChar = IconChar.Faucet;
            allchart = true;
        }
        public ResultMainForm()
        {
            // при загрузки этой формы понять какой cheken прожат и создать новый метод для расчёта?

            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(1126, 47);
            PanelMenu.Controls.Add(leftBorderBtn);

            // currentBtn.BackColor = Color.FromArgb(37, 36, 81); 
            // currentBtn.BackColor = Color.FromArgb(153, 180, 209); - цвет фона
            allchart = false; 
            if (MainForm.Eulerbox == true)
            {
                ButtonColor(EulerButton);                
            }

            if (MainForm.Chordbox == true)
            {
                ButtonColor(ChordButton);                
            }

            if (MainForm.Euler_recalbox == true)
            {
                ButtonColor(Euler_recalButton);                
            }

            if (MainForm.Runge_kuttabox == true)
            {
                ButtonColor(Runge_kuttaButton);                
            }

            if (MainForm.Milnabox == true)
            {
                ButtonColor(MilnaButton);               
            }

            if (MainForm.Adamsbox == true)
            {
                ButtonColor(AdamsButton);                
            }

            if (allchart == true)
            {
                ButtonColor(AllChartButton);                
            }




        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241 );
            public static Color color2 = Color.FromArgb(249, 118, 176 );
            public static Color color3 = Color.FromArgb(253, 138, 114 );
            public static Color color4 = Color.FromArgb(95, 77, 221 );
            public static Color color5 = Color.FromArgb(249, 88, 155 );
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                MessageSelectLabel.Visible = false;
                ResultDataGridView.Visible = true;
                ResultChart.Visible = true;
                DisableButton();
                // Button
                currentBtn = (IconButton)senderBtn;
                // currentBtn.BackColor = Color.FromArgb(37, 36, 81); 
                // currentBtn.BackColor = Color.FromArgb(153, 180, 209); - цвет фона
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
                // Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(currentBtn.Location.X, 0);
                leftBorderBtn.Visible = true;
                // leftBorderBtn.BringToFront();
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                // currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = Color.Black;
                currentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            }
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
            PanelResult.Controls.Add(childForm);
            PanelResult.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void OpenChildControl(System.Windows.Forms.Control childForm)
        {
            
            currentChildControl = childForm;
            
            childForm.Dock = DockStyle.Fill;
            PanelResult.Controls.Add(childForm);
            PanelResult.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void Data_output(string MethodName, double[] x, double[] y, int eps, object sender )
        {
            ResultDataGridView.Rows.Clear();
            ResultChart.Series.Clear();
            ActivateButton(sender, RGBColors.color4);
            ResultChart.Location = new Point(453, 74);
            ResultChart.Size = new Size(619, 343);

            ResultChart.Titles[0].Text = "Метод Эйлера";


            Series seriesOfPoint = new Series()
            {
                ChartType = SeriesChartType.Line,

            };
            for (int i = 0; i < MainForm.N + 1; i++)
            {
                ResultDataGridView.Rows.Add(i, x[i], Math.Round(y[i], eps));
                seriesOfPoint.Points.AddXY(x[i], Math.Round(y[i], eps));
            }
            ResultChart.Series.Add(seriesOfPoint);
        }

        private void EulerButton_Click(object sender, EventArgs e)
        {            
            if (MainForm.Eulerbox == true)
            {
                string MethodName = "Метод Эйлера";
                Data_output(MethodName, MainForm.x, MainForm.y, MainForm.eps, sender);                
            }                       
        }

        private void ChordButton_Click(object sender, EventArgs e)
        {
            if (MainForm.Chordbox == true)
            {
                string MethodName = "Метод Хорд";
                Data_output(MethodName, MainForm.xChord, MainForm.yChord, MainForm.eps, sender);               
            }                        
        }

        private void Euler_recalButton_Click(object sender, EventArgs e)
        {
            if (MainForm.Euler_recalbox == true)
            {
                // string MethodName = "Метод Эйлера с пересчётом";
                
            }                       
        }

        private void RubgeButton_Click(object sender, EventArgs e)
        {
            if (MainForm.Runge_kuttabox == true)
            {
                // string MethodName = "Метод Рунге-Кутта";
            }                       
        }

        private void MilnaButton_Click(object sender, EventArgs e)
        {
            if (MainForm.Milnabox == true)
            {
                // string MethodName = "Метод Милна";
            }                      
        }

        private void AdamsButton_Click(object sender, EventArgs e)
        {
            if (MainForm.Adamsbox == true)
            {
                // string MethodName = "Метод Адемса";
            }                        
        }
        private void AddAllChart(string MethodName, double[] x, double[] y)
        {
            Series seriesOfPoint = new Series()
            {
                ChartType = SeriesChartType.Line,
            };
            for (int i = 0; i < MainForm.N + 1; i++)
            {
                seriesOfPoint.Points.AddXY(x[i], Math.Round(y[i], MainForm.eps));
            }
            ResultChart.Series.Add(seriesOfPoint);
        }
        private void AllChartButton_Click(object sender, EventArgs e)
        {
            if (allchart == true)
            {                
                ResultDataGridView.Rows.Clear();
                ResultChart.Series.Clear();
                ActivateButton(sender, RGBColors.color4);
                ResultDataGridView.Visible = false;
                ResultChart.Titles[0].Text = "Все графики";
                ResultChart.Location = new Point(59, 74);
                ResultChart.Size = new Size(1000,400);
                                                                             
                if (MainForm.Eulerbox == true)
                {
                    string MethodName = "Метод Эйлера";
                    AddAllChart(MethodName, MainForm.x, MainForm.y);   
                    
                }

                if (MainForm.Chordbox == true)
                {
                    string MethodName = "Метод Хорд";
                    AddAllChart(MethodName, MainForm.xChord, MainForm.yChord);                    
                }

                if (MainForm.Euler_recalbox == true)
                {

                }

                if (MainForm.Runge_kuttabox == true)
                {

                }

                if (MainForm.Milnabox == true)
                {

                }

                if (MainForm.Adamsbox == true)
                {

                }
            }
        }
    }
}

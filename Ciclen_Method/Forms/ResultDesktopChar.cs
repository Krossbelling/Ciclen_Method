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

namespace Ciclen_Method.Forms
{
    public partial class ResultDesktopChar : Form
    {
        public ResultDesktopChar()
        {
            InitializeComponent();

            Chart.Titles.Add("Метод Эйлера");            
            Series seriesOfPoint = new Series()
            {
                ChartType = SeriesChartType.Line
            };
            for (int i = 0; i < MainForm.N; i++)
            {
                dataGridView1.Rows.Add(i, MainForm.x[i], Math.Round(MainForm.y[i], MainForm.eps));
                seriesOfPoint.Points.AddXY(MainForm.x[i], Math.Round(MainForm.y[i], MainForm.eps));
            }
            Chart.Series.Add(seriesOfPoint);

        }
    }
}

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
    public partial class ResultControl : UserControl
    {
        
        public ResultControl()
        {            
            InitializeComponent();

            for (int i = 0; i < MainForm.N; i++)
            {
                // dataGridView1.Rows.Add(i, MainForm.x[i], Math.Round(MainForm.y[i], MainForm.eps));
            }
        }        
        
    }
}

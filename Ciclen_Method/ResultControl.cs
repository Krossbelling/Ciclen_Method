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
        Form formtoopen;
        public ResultControl(Form1 form)
        {
            InitializeComponent();
            formtoopen = form;

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();            
            
            
        }
        
    }
}

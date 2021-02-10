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

            for (int i = 0; i < InputControl.N; i++)
            {
                //Добавляем строку, указывая значения колонок поочереди слева направо
                dataGridView1.Rows.Add(i, InputControl.x[i], Math.Round(InputControl.y[i], InputControl.eps));
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            // пытаемся получить ссылку на интерфейс навигатора,
            // который должна реализовать форма Form1, на которой находится сейчас экземпляр UserControl1
            // если это не так, выходим
            if (!(ParentForm is INavigator navigator)) return;
            // вызываем метод, который создаст и разместит экземпляр UserControl2 на панели Panel1 формы Form1
            navigator.CreateAndPlaceToPage(typeof(InputControl));


        }

        
    }
}

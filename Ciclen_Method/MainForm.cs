using Microsoft.SharePoint.Client;
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
    public partial class MainForm : System.Windows.Forms.Form, INavigator

    {
        public MainForm()
        {
            InitializeComponent();
            var uc = new InputControl();
            if (Panel.Controls.Count > 0)
                Panel.Controls.RemoveAt(0);
            Panel.Controls.Add(uc);
        }

        public void CreateAndPlaceToPage(Type pageType)
        {
            // создаем новый экземпляр при помощи ссылки на тип
            var userControl = (UserControl)Activator.CreateInstance(pageType);
            // и добавляем его в панель Panel1
            Panel.Controls.Add(userControl);
            // предыдущий размещённый пользовательский элемент удаляем
            if (Panel.Controls.Count > 1)
                Panel.Controls.RemoveAt(0);            
        }        
    }
    public interface INavigator
    {
        void CreateAndPlaceToPage(Type pageType);
    }

}

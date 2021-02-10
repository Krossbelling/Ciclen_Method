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
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

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

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void Out_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    public interface INavigator
    {
        void CreateAndPlaceToPage(Type pageType);
    }

}

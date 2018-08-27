using Eto.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETOAppClosureError
{
    internal class MainWindow : Form
    {
        public MainWindow()
        {
            Title = "test app";
            Width = 200;
            Height = 200;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            e.Cancel = true;
            this.Visible = false;
        }
    }
}
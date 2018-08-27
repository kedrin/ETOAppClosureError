using Eto.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETOAppClosureError
{
    internal class Dialog : Eto.Forms.Dialog
    {
        public Dialog()
        {
            Content = Btn();
            Title = "Open Dialog?";
            Width = 200;
            Height = 200;
        }

        private Control Btn()
        {
            var btn = new Button() { };
            btn.Click += (sender, e) => { MessageBox.Show("You Clicked me"); };
            return btn;
        }
    }
}
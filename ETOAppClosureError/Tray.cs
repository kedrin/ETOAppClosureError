using Eto.Drawing;
using Eto.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETOAppClosureError
{
    internal class Tray : TrayIndicator
    {
        private string exepath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

        public Tray()
        {
            Image = new Bitmap(System.IO.Path.Combine(exepath, "logo.png")).WithSize(24, 24);
            Menu = new ContextMenu()
            {
                Items =
                {
                    new ShowDialog(),
                },
            };
            Title = "testapp";
        }
    }
}
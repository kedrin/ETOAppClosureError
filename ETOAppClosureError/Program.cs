using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eto.Forms;

namespace ETOAppClosureError
{
    internal class Program
    {
        private static Application app;

        [STAThread]
        private static void Main(string[] args)
        {
            var plat = new Eto.GtkSharp.Platform();
            //var plat = new Eto.Wpf.Platform();
            app = new Eto.Forms.Application(plat);
            app.Initialized += (sender, e) =>
            {
                new Tray().Show();
                new MainWindow().Show();
            };
            app.Run();
        }
    }
}
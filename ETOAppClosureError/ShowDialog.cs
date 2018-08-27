using Eto.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETOAppClosureError
{
    internal class ShowDialog : Command
    {
        public ShowDialog()
        {
            MenuText = "Show Dialog";
        }

        protected override void OnExecuted(EventArgs e)
        {
            base.OnExecuted(e);

            new Dialog().ShowModal();
        }
    }
}
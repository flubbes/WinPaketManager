using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinPaketManager.Lib.Controls
{
    public class ButtonViewClickEventArgs : EventArgs
    {
        public ButtonViewClickEventArgs(ButtonViewButton clickedButton)
        {
            this.Button = clickedButton;
        }

        public ButtonViewButton Button
        {
            get;
            private set;
        }
    }
}

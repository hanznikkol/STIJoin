using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STI_Join
{
    public class Components
    {
        public void SetHandCursorForButtons(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is System.Windows.Forms.Button button)
                {
                    button.Cursor = Cursors.Hand;
                }
                SetHandCursorForButtons(ctrl);
            }

        }
    }
}

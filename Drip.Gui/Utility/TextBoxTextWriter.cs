using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Drip.Gui.Utility
{
    public class TextBoxTextWriter : TextWriter
    {
        private TextBox _output = null;

        public TextBoxTextWriter(TextBox output)
        {
            _output = output;
        }

        public override Encoding Encoding => Encoding.UTF8;

        public override void Write(char value)
        {
            base.Write(value);
            try
            {
                _output.Invoke((Action)delegate ()
                            {
                                _output.AppendText(value.ToString());
                                _output.ScrollToCaret();
                            });
            }
            catch (InvalidOperationException)
            {
                Debug.Write(value);
            }
            
            
        }
    }
}

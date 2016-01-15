using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Drip.AppConsole
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

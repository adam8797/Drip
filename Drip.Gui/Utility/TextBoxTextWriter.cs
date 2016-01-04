using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            _output.AppendText(value.ToString());
            _output.ScrollToCaret();
        }
    }
}

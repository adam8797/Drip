using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drip.Gui.Control
{
    public partial class Gauge : UserControl
    {
        public Gauge()
        {
            InitializeComponent();
        }

        public Orientation Orientation { get; set; }

        public int MaxValue { get; set; } = 100;
        public int MinValue { get; set; } = 0;

        private int _value;

        public Color GuageColor { get; set; } = Color.Chartreuse;

        public int Value
        {
            get { return _value; }
            set
            {
                _value = value;
                Refresh();
            }
        }
        
        private void Gauge_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Black, this.DisplayRectangle);

            if (MaxValue - MinValue == 0)
                return;

            var perc = (float)_value/(MaxValue - MinValue);

            if (Orientation == Orientation.Vertical)
            {
                perc = 1.0f - perc;
                e.Graphics.FillRectangle(new SolidBrush(GuageColor), 0, Height * perc, Width, Height - (Height * perc));
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(GuageColor), 0, 0, Width * perc, Height);
            }

        }
    }
}

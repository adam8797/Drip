using System.Drawing;
using System.Windows.Forms;

namespace Drip.Gui.Controls
{
    public partial class Gauge : UserControl
    {
        public Gauge()
        {
            InitializeComponent();

            DoubleBuffered = true;
        }

        public Orientation Orientation { get; set; } = Orientation.Vertical;

        public int MaxValue { get; set; } = 100;
        public int MinValue { get; set; } = 0;

        private int _value;

        public Color GuageColor { get; set; } = Color.Chartreuse;

        public int Value
        {
            get { return _value; }
            set
            {
                if (_value != value)
                {
                    _value = value;
                    Invalidate();
                }
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Black, this.DisplayRectangle);
        }

        private void Gauge_Paint(object sender, PaintEventArgs e)
        {
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

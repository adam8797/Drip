using System;
using System.Drawing;
using System.Windows.Forms;

namespace Drip.Gui.Controls
{
    public partial class MotorGuage : UserControl
    {
        public MotorGuage()
        {
            DoubleBuffered = true;
            InitializeComponent();
        }

        public Orientation Orientation { get; set; }

        private int MaxValue = 100;
        private int MinValue = -100;

        private int _value;

        public Color NormalColor { get; set; } = Color.Chartreuse;
        public Color DangerColor { get; set; } = Color.Red;

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
            var perc = Math.Abs(_value / (100.0f));
            if (Orientation == Orientation.Horizontal)
            {
                var center = Width / 2.0f;
                e.Graphics.DrawLine(new Pen(perc > .9 ? DangerColor : NormalColor, 5), center, 0, center, Height);
            }
            else
            {
                var center = Height / 2.0f;
                e.Graphics.DrawLine(new Pen(perc > .9 ? DangerColor : NormalColor, 5), 0, center, Width, center);
            }
        }

        private void MotorGuage_Paint(object sender, PaintEventArgs e)
        {
            if (MaxValue - MinValue == 0)
                return;

            var perc = Math.Abs(_value / (100.0f));
            var brush = new SolidBrush(perc > .9 ? DangerColor:NormalColor);

            if (Orientation == Orientation.Horizontal)
            {
                var barWidth = (Width / 2.0f) * perc;
                var center = Width/2.0f;
                if (_value > 0)
                {
                    e.Graphics.FillRectangle(brush, center, 0, barWidth, Height);
                }
                else
                {
                    e.Graphics.FillRectangle(brush, center - barWidth, 0, barWidth, Height);
                }
            }
            else
            {
                var barHeight = (float)(Height / 2.0) * (perc);
                var center = Height /2.0f;
                if (_value > 0)
                {
                    e.Graphics.FillRectangle(brush, 0, center - barHeight, Width, barHeight);
                }
                else
                {
                    e.Graphics.FillRectangle(brush, 0, center, Width, barHeight);
                }
            }
        }
    }
}

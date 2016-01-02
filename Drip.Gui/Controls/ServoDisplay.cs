using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ROVControl.Control;

namespace Drip.Gui.Controls
{
    public partial class ServoDisplay : UserControl
    {
        public ServoDisplay()
        {
            DoubleBuffered = true;
            InitializeComponent();
        }

        private int _angle;
        public int Angle
        {
            get { return _angle; }
            set
            {
                if (_angle != value)
                {
                    if (value > MaxAngle)
                        _angle = MaxAngle;
                    else if (value < MinAngle)
                        _angle = MinAngle;
                    else
                        _angle = value;

                    Invalidate();
                }
            }
        }

        private int _minAngle = -90;
        public int MinAngle
        {
            get { return _minAngle; }
            set
            {
                if (_minAngle != value)
                {
                    _minAngle = value;
                    Invalidate();
                }
            }
        }

        private int _maxAngle = 90;
        public int MaxAngle
        {
            get { return _maxAngle; }
            set
            {
                if (_maxAngle != value)
                {
                    _maxAngle = value;
                    Invalidate();
                }
            }
        }

        private int _margin = 10;
        public int GuageMargin
        {
            get { return _margin; }
            set
            {
                if (_margin != value)
                {
                    _margin = value;
                    Invalidate();
                }
            }
        }

        private int _barWidth = 5;
        public int BarWidth
        {
            get { return _barWidth; }
            set
            {
                if (_barWidth != value)
                {
                    _barWidth = value;
                    Invalidate();
                }
            }
        }

        public bool AutoAdjustSize { get; set; } = true;

        private bool _showDetails;
        public bool ShowDetails
        {
            get { return _showDetails; }
            set
            {
                if (_showDetails != value)
                {
                    if (AutoAdjustSize)
                    {
                        if (!_showDetails && value)
                            Width += 50;
                        if (_showDetails && !value)
                            Width -= 50;
                    }

                    _showDetails = value;
                    Invalidate();
                }
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            var displayWidth = _showDetails ? Width - 50:Width;

            float xCenter = displayWidth / 2.0f;

            const int penWidth = 5;
            var pen = new Pen(Color.Black, penWidth);

            //Draw the flat base
            e.Graphics.DrawLine(pen, _margin, Height - _margin, displayWidth - _margin, Height - _margin);

            //Draw the arc
            e.Graphics.DrawArc(pen, _margin, _margin + 5, displayWidth - (2 * _margin), (2 * Height) - (2 * _margin), 180, 180);
            e.Graphics.FillRectangle(Brushes.White, 0, Height - _margin + (penWidth / 2.0f), displayWidth, _margin);

            e.Graphics.DrawLine(new Pen(Color.Black, 1), xCenter, _margin + 5, xCenter, Height - _margin);

            var zeroString = "0";
            e.Graphics.DrawString(zeroString, DefaultFont, new SolidBrush(Color.Black),
                (float) (xCenter - (e.Graphics.MeasureString(zeroString, DefaultFont).Width/2.0)), 0);
        }

        private void ServoDisplay_Paint(object sender, PaintEventArgs e)
        {
            var displayWidth = _showDetails ? Width - 50 : Width;
            float xCenter = displayWidth / 2.0f;

            var hyp = Height - _margin;

            //var hyp = 50;

            float x = (float)(hyp*Math.Sin(_angle*(Math.PI/180.0f)));
            float y = (float)(hyp*Math.Cos(_angle*(Math.PI/180.0f)));

            e.Graphics.DrawLine(new Pen(Color.Red, _barWidth), xCenter, Height - _margin, xCenter + x,  Height - _margin - y);
        }
    }
}

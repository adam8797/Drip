using System.Drawing;
using System.Windows.Forms;
using Drip.Gui.Utility;
using XInputDotNetPure;

namespace Drip.Gui.Controls
{
    public partial class JoystickDisplay : UserControl
    {
        public JoystickDisplay()
        {
            DoubleBuffered = true;
            InitializeComponent();

        }

        private GamePadThumbSticks.StickValue _stickValue;
        public GamePadThumbSticks.StickValue StickValue
        {
            get { return _stickValue; }
            set
            {
                if (!_stickValue.CompareSticks(value))
                {
                    _stickValue = value;
                    Invalidate();
                }
            }
        }

        private int _dotSize = 15;
        public int DotSize
        {
            get { return _dotSize; }
            set
            {
                if (_dotSize != value)
                {
                    _dotSize = value;
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

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            float xCenter = Width / 2.0f;
            float yCenter = Height / 2.0f;

            const int width = 5;

            var flatPen = new Pen(Color.Black, width);
            var dashedPen = new Pen(Color.Black, width / 2.0f)
            {
                DashPattern = new[] { 1f, 1f }
            };

            //Draw outer circle
            e.Graphics.DrawEllipse(flatPen, _margin, _margin, Width - (2 * _margin), Height - (2 * _margin));

            //Vertical Line
            e.Graphics.DrawLine(dashedPen, xCenter, _margin, xCenter, Height - _margin);

            //Horizontal Line
            e.Graphics.DrawLine(dashedPen, _margin, yCenter, Width - _margin, yCenter);
        }

        private void JoystickDisplay_Paint(object sender, PaintEventArgs e)
        {
            float xCenter = Width / 2.0f;
            float yCenter = Height / 2.0f;

            //Dot
            var joyX = xCenter + (_stickValue.X*(((Width - (2.0f * _margin)) / 2.0f)));
            var joyY = yCenter - (_stickValue.Y*yCenter);
            e.Graphics.FillEllipse(Brushes.Red, joyX - (_dotSize / 2.0f), joyY - (_dotSize / 2.0f), _dotSize, _dotSize);


        }
    }
}

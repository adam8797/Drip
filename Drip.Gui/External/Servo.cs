using Drip.Gui.Utility;

namespace ROVControl.Control
{
    /// <summary>
    /// Servo class that allows a servo velocity.
    /// Written for Orange Mango's entry to the 2015 MATE competition, from "ROVControl"
    /// Slight modifications were made to adapt to this project
    /// </summary>
    public class Servo
    {
        private readonly int _maxAngle;
        private readonly int _minAngle;
        private double _currentAngle;
        private double _velocity;
        private readonly int _defaultAngle;

        public Servo(int maxAngle, int minAngle, int defaultAngle)
        {
            _maxAngle = maxAngle;
            _minAngle = minAngle;
            _currentAngle = defaultAngle;
            _defaultAngle = defaultAngle;
        }

        public Servo() : this(90, -90, 0)
        { }

        public int Angle
        {
            get { return (int)_currentAngle; }
            set {
                _currentAngle = value <= _maxAngle ? value : _maxAngle;
            }
        }

        public void Reset()
        {
            _currentAngle = _defaultAngle;
        }

        //public Ratio GetAngleRatio()
        //{
        //    return new Ratio((long)_currentAngle, 180);
        //}

        public void SetVelocity(float vel)
        {
            _velocity = vel;
        }

        public void Update()
        {
            _currentAngle += (double)((240.0m/ApplicationConfig.Shared.UpdateRate)*ApplicationConfig.Shared.ServoCoefficient) *
                             _velocity;

            if (_currentAngle >= _maxAngle)
                _currentAngle = _maxAngle;

            if (_currentAngle <= _minAngle)
                _currentAngle = _minAngle;
        }
    }
}

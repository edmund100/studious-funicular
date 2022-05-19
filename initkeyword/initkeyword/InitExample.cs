using System;

namespace initkeyword
{
    class InitExample
    {
        private double _seconds;

        public double Seconds
        {
            get { return _seconds; }
            init { _seconds = value; }
        }
    }
}

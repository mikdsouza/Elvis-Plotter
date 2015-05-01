using System;
using System.Numerics;

namespace NyquistPlotter.Data
{
    public struct BodePoint
    {
        public double Frequency { get; set; }

        public double GainDB { get; set; }

        public double phaseDeg;
        public double PhaseDeg {
            get { return phaseDeg; }
            set
            {
                //put the angle between -180 and 180
                while(!(-180 <= value && value <= 180))
                {
                    if (value < -180)
                        value += 360;
                    else if (value > 180)
                        value -= 360;
                }

                phaseDeg = value;
            }
        }

        public double GainAbs
        {
            get
            {
                return Math.Pow(10, (GainDB / 20));
            }
            set
            {
                GainDB = 20 * Math.Log10(value);
            }
        }

        public double PhaseRad
        {
            get
            {
                return (Math.PI / 180) * PhaseDeg;
            }
            set
            {
                PhaseDeg = (180 / Math.PI) * value;
            }
        }

        public double AngularFreq
        {
            get
            {
                return 2 * Math.PI * Frequency;
            }
            set
            {
                Frequency = value / (Math.PI * 2);
            }
        }

        public Complex Value
        {
            get
            {
                return Complex.FromPolarCoordinates(GainAbs, PhaseRad);
            }
            set
            {
                GainAbs = value.Magnitude;
                PhaseRad = value.Phase;
            }
        }
    }
}

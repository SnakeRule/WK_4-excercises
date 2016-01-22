using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_5
{
    class Radio
    {
        private int volume = 0;
        private double frequency = 2000.0;

        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (power_on == true)
                {
                    if (value >= 0 && value <= 9)
                        volume = value;
                    else if (value < 0)
                        Console.WriteLine("You're trying to set the volume below 0!");
                    else
                        Console.WriteLine("You're trying to set the volume above 9!");
                }
                else
                    Console.WriteLine("The radio is not on! Can't set frequency");
            }
        }
        public double Frequency
        {
            get
            {
                return frequency;
            }
            set
            {
                if (power_on == true)
                {
                    if (value >= 2000.0 && value <= 26000.0)
                    frequency = value;
                else if (value < 2000.0)
                    Console.WriteLine("You're trying to set the frequency below 2000.0!");
                else
                    Console.WriteLine("You're trying to set the frequency above 26000.0!");
                }
                else
                    Console.WriteLine("The radio is not on! Can't set frequency");
            }
        }
        public bool power_on { get; set; }
    }
}

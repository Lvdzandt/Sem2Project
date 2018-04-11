using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasse
{
    class Field
    {
        public double Difficulty { get; private set; }

        public Field(string _diff)
        {
            Difficulty = DiffSet(_diff);
        }

        private double DiffSet(string diff)
        {
            double multiplier = 0;
            if (diff == "Easy")
            {
                multiplier = 0.8;
            }
            else if (diff == "Normal")
            {
                multiplier = 1;
            }
            else if(diff == "Hard")
            {
                multiplier = 1.2;
            }
            return multiplier;
        }
    }
}

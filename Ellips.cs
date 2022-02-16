using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    public class Ellips
    {
        public int A { get; set; }
        public int B { get; set; } 
        
        public Ellips (int a, int b)
        {
            if (a <= 0)
            {
                throw new ArgumentException("The radius is less than or equal to zero");
            }
            if (b <= 0)
            {
                throw new ArgumentException("The radius is less than or equal to zero");
            }

            A = a;
            B = b;
        }
        public double GetSquare()
        {
            return Math.Round(Math.PI * A * B, 2);
        }
        public double GetLength()
        {
            return Math.Round(Math.PI * (A + B), 2); 
        }
    }
}

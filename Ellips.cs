using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    public class Ellips
    {
        public int HorizontalRadius { get; set; }
        public int VerticalRadius { get; set; } 
        
        public Ellips (Point centerPoint, int horizontalradius, int verticalradius)
        {
            if (horizontalradius <= 0)
            {
                throw new ArgumentException("The radius is less than or equal to zero");
            }
            if (verticalradius <= 0)
            {
                throw new ArgumentException("The radius is less than or equal to zero");
            }

            HorizontalRadius = horizontalradius;
            VerticalRadius = verticalradius;
        }
        public double GetSquare()
        {
            return Math.Round(Math.PI * HorizontalRadius * VerticalRadius, 2);
        }
        public double GetLength()
        {
            return Math.Round(Math.PI * (HorizontalRadius + VerticalRadius), 2); 
        }
    }
}

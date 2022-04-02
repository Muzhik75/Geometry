using System;

namespace Geometry
{
    public abstract class Figure
    {
        public string name;
        public float perimeter;
        public float square;
        

        public Figure(string s)
        {
            this.name = name;
            
        }

        public abstract float Square();
        public abstract float Perimeter();
    }

    public class Triangle : Figure
    {
        public int numSide;
        public int firstSide;
        public int secondSide;
        public int threedSide;

        public Triangle(string name, int numSide) : base(name)
        {
            this.numSide = numSide;
        }

        public override float Square()
        {
            float semiPerimeter = (firstSide + secondSide + threedSide) / 2;
            float square = (float) Math.Sqrt(semiPerimeter * (semiPerimeter - firstSide) *
                                                     (semiPerimeter - secondSide) * (semiPerimeter - threedSide));
            return square;
        }


        public override float Perimeter()
        {
            float perimeter = (firstSide + secondSide + threedSide);
            return perimeter;
        }
        

        
    }
    
}
using System;

namespace Geometry
{
    public abstract class Figure
    {
        public string name;
        public float perimeter;
        public float square;


        public Figure(string name)
        {
            this.name = name;
            this.perimeter = perimeter;
            this.square = square;

        }

        public abstract float Square();
        public abstract float Perimeter();

        public void PrintInfo()
        {
            Console.WriteLine($"\nНазвание фигуры: {name} " +
                              $"\nПлощадь фигуры: {square} " + 
                              $"\nПериметр фигуры: {perimeter} " +
                              $"\n___________________________________");
        } 
    }

    public class Triangle : Figure
    {
        public int side1;
        public int side2;
        public int side3;

        public Triangle(string name) : base(name)
        {
            this.side1 = 5;
            this.side2 = 6;
            this.side3 = 7;
            this.square = square;
            this.perimeter = perimeter;
        }

        public override float Square()
        {
            float semiPerimeter = (side1 + side2 + side3) / 2;
            this.square = (float) Math.Sqrt(semiPerimeter * (semiPerimeter - side1) *
                                             (semiPerimeter - side2) * (semiPerimeter - side3));
            return this.square;
        }


        public override float Perimeter()
        {
            this.perimeter = (side1 + side2 + side3);
            return this.perimeter;
        }
     
        }

    public class Circle : Figure
    {
        public int radius;

        public Circle(string name) : base(name)
        {
            this.radius = 5;
        }

        public override float Square()
        {
            this.square = (float) (Math.PI * radius * radius);
            return this.square;
        }

        public override float Perimeter()
        {
            this.perimeter = (float) Math.PI * 2 * radius;
            return this.perimeter;
        }
    }
    
}
    

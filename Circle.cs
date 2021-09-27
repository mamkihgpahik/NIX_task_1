using System;

namespace NIX_task_1
{
    public class Circle : Point
    {
        public double R { get; set; }
        public Circle(double x, double y, double r) : base(x, y)
        {
            if (r<=0)
            {
                throw new ArgumentException("radius cannot be less than 0");
            }
            this.R = r;
        }
        public override void Move(double x, double y)
        {
            base.X += x;
            base.Y += y;
        }

        public override void Print()
        {
            Console.WriteLine($"Circle with coordinates X:{X} Y:{Y} and Radius:{R}");
        }

        public override void Scaling(double sc)
        {
            this.R *= sc;
        }
    }
}

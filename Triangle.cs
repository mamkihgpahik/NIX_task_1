using System;

namespace NIX_task_1
{
    public class Triangle : Rectangle
    {
        public double X2 { get; set; }
        public double Y2 { get; set; }
        public Triangle(double x, double y, double x1, double y1, double x2, double y2) : base(x, y, x1, y1)
        {
            this.X2 = x + x2;
            this.Y2 = y + y2;
        }
        public override void Print()
        {
            Console.WriteLine($"Triangle with coordinates A:({X},{Y}), B:({X1},{Y1}), C:({X2},{Y2})");
        }

        public override void Move(double x, double y)
        {
            base.X += x;
            base.Y += y;
        }

        public override void Scaling(double sc)
        {
            base.X1 *= sc;
            this.X2 *= sc;
            base.Y1 *= sc;
            this.Y2 *= sc;
        }
    }
}

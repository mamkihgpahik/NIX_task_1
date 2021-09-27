using System;

namespace NIX_task_1
{
    public class Rectangle : Point
    {
        public double X1 { get; set; }
        public double Y1 { get; set; }
        public Rectangle(double x, double y, double x1, double y1):base(x,y)
        {
            this.X1 = x + x1;
            this.Y1 = y + y1;
        }
        
        public override void Move(double x, double y)
        {
            base.X += x;
            base.Y += y;
        }

        public override void Print()
        {
            Console.WriteLine($"Rectangle with coordinates X:{X} Y:{Y} and shift from one fixed corner to another: X1:{X1} Y1:{Y1}");
        }

        public override void Scaling(double sc)
        {
            this.X1 *= sc;
            this.Y1 *= sc;
        }
    }
}

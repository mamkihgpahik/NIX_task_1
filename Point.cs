namespace NIX_task_1
{
    public abstract class Point
    {  
        public double X { get; set; }
        public double Y { get; set; }
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
        public abstract void Print();
        public abstract void Move(double x, double y);
        public abstract void Scaling(double sc);
    }
}

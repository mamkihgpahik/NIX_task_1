using System.Collections.Generic;

namespace NIX_task_1
{
    public class Picture : Rectangle
    {
        private List<Point> figures;
        public Picture(double x, double y, double x1, double y1):base(x,y,x1,y1)
        {
            figures = new List<Point>();
        }
       
        public void Add(Point figure)
        {
           figures.Add(figure);
        }
        public override void Move(double x, double y)
        {
            foreach (var figure in figures)
            {
                figure.Move(x, y);
            }
        }

        public override void Print()
        {
            foreach (var figure in figures)
            {
                figure.Print();
            }   
        }

        public override void Scaling(double sc)
        {
            foreach (var figure in figures)
            {
                figure.Scaling(sc);
            }     
        }
    }
}

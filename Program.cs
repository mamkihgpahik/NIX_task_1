using System;
namespace NIX_task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(0, 0, 4);
            circle.Print();
            circle.Move(4, 2);
            circle.Print();
            circle.Scaling(2);
            circle.Print();
            ////////////////
            Rectangle rectangle = new Rectangle(2, 2, 6, 6);
            rectangle.Print();
            rectangle.Move(4, 2);
            rectangle.Print();
            rectangle.Scaling(2);
            rectangle.Print();
            /////////////////
            Triangle triangle = new Triangle(1, 4, 4, 5, 6, 7);
            triangle.Print();
            triangle.Move(4, 2);
            triangle.Print();
            triangle.Scaling(2);
            triangle.Print();
            ///////////////
            Picture picture = new Picture(2,2,8,8);
            picture.Add(triangle);
            picture.Add(rectangle);
            picture.Add(circle);
            picture.Print();
            picture.Move(4, 2);
            picture.Print();
            picture.Scaling(2);
            picture.Print();
        }
    }
}

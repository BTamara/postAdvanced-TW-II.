using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDesignPattern
{

    public interface IShape
    {
        void Draw();
    }

    public class Circle : IShape
    {

        public void Draw()
        {
            Console.WriteLine("This is a circle");
        }
    }

    public class Triangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("This is a triangle");
        }
    }

    public class Pentagon : IShape
    {
        public void Draw()
        {
            Console.WriteLine("This is a pentagon");
        }
    }

    public class Facade
    {
        private IShape circle = new Circle();
        private IShape triangle = new Triangle();
        private IShape pentagon = new Pentagon();

        public void DrawCircle()
        {
            
            circle.Draw();
        }

        public void DrawTriangle()
        {
            triangle.Draw();
        }

        public void DrawPentagon()
        {
            pentagon.Draw();
        }
    }
}

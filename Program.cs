using bai6_w06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5_w07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[5];
            shapes[0]= new Square(5);
            shapes[1] = new Circle(3);
            shapes[2] = new Circle(4);
            shapes[3] = new Square(11);
            shapes[4] = new Rectangle(5,3);
            int num = 0;
            int um = 1;
            Square sr1 = (Square)shapes[0];
            Square sr2 = (Square)shapes[3];
            foreach (Shape shape in shapes)
            {
                Console.WriteLine("Shape" + um);
                um++;
                if (shape is Square && num == 0)
                {
                    sr1.HowToColor();
                    num++;
                }
                else if (shape is Square && num == 1)
                    sr2.HowToColor();
                Console.WriteLine(shape.getArea());          
            }
            Console.ReadKey();
        }         
    }
}

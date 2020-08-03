using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheriance
{
    abstract class Quadrilateral
    {
       public  int length;
        public Quadrilateral(int _length)
        {
            length = _length;
        }
        public abstract int Area();
    }
    class Square : Quadrilateral
    {
        public Square(int _length) : base(_length)
        {
            
        }
        public override int Area()
        {
            int square = length * length;
            return square;
        }

    }
    class Rectangle : Quadrilateral
    {
        int breadth;
        public Rectangle(int _length,int _breadth ): base(_length)
        {
            breadth = _breadth;
            
        }
        public override int Area()
        {
            int rectangle = length * breadth;
            return rectangle;

        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Square s = new Square(8);
            s.Area();
            Console.WriteLine(s.Area());
            Rectangle r = new Rectangle(5, 6);
            r.Area();
            Console.WriteLine(r.Area());
            if(s.Area()> r.Area())
            {
                Console.WriteLine("square Area is gretaer than rectangle area");
            }
            else
            {
                Console.WriteLine("Rectangle Area is greater than square area");
            }
            
            


            
            Console.Read();


        }
    }
}

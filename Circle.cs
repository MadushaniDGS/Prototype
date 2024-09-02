using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Circle : ShapePrototype
    {
        public string color;
        public int size;

        public Circle(string color,int size) 
        {
            this.color = color;
            this.size = size;
        }

        public ShapePrototype Clone()
        {
            return new Circle(this.color,this.size);
        }
        public void Draw()
        {
            Console.WriteLine($"Drawing a {color} circle of {size}");
        }
    }

}

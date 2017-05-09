using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB5
{
    class Box
    {

        public double Length{ get; set;}
        public double Breadth { get; set; }
        public double Width { get; set; }

        public Box() : 
            this(1, 1, 1) {}

        public Box(double l, double b, double w)
        {
            this.Length = l;
            this.Breadth = b;
            this.Width = w;
        }

        public static Box operator +(Box box1, Box box2)
        {
            Box newBox = new Box();
            newBox.Breadth = box1.Breadth + box2.Breadth;
            newBox.Length = box1.Length + box2.Length;
            newBox.Width = box1.Width + box2.Width;
            return newBox;
        }

        public static Box operator -(Box box1, Box box2)
        {
            Box newBox = new Box();
            newBox.Breadth = box1.Breadth - box2.Breadth;
            newBox.Length = box1.Length - box2.Length;
            newBox.Width = box1.Width - box2.Width;
            return newBox;
        }

        public static bool operator ==(Box box1, Box box2)
        {
            if ((box1.Length == box2.Length) &&
                (box1.Width == box2.Width) &&
                (box1.Breadth == box2.Breadth))
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Box box1, Box box2)
        {
            if ((box1.Length != box2.Length) ||
                (box1.Width != box2.Width) ||
                (box1.Breadth != box2.Breadth))
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return String.Format("Box with Height : {0} Width : {1} and Breadth : {2}",
                Length, Width, Breadth);
        }

        public static explicit operator int(Box b)
        {
            return (int)(b.Length + b.Width + b.Breadth) / 3;
        }

        // Convert from an int to a Box
        public static implicit operator Box(int i)
        {
            // Return a box with the lengths all
            // set to the int passed
            return new Box(i, i, i);
        }

    }
}

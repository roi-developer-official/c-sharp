using System;

namespace chapter4
{
    partial class Program
    {
        public class Rectangle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Drawinng a rectangle");
            }
        }
    }
}

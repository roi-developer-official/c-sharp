using System;

namespace chapter4
{
    partial class Program
    {

        public sealed class Circle:Shape
        {
            public sealed override void Draw()
            {
                Console.WriteLine("Draw A circle");
            }

        }
    }
}

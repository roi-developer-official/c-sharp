using System;
namespace chapter3
{
    public class PresentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }


        public PresentationObject()
        {

        }

        public PresentationObject(int color)
        {

        }
        public void Copy()
        {
            Console.WriteLine("Copied");
        }
        public void Duplicate()
        {
            Console.WriteLine("Duplicated");
        }

    }
}

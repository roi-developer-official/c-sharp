using System.Collections.Generic;

namespace chapter4
{
    partial class Program
    {
        public class Canvas
        {
            public void DrawShape(List<Shape> shapes)
            {
                foreach(var shape in shapes)
                {
                    shape.Draw();
                }
            }
        }
    }
}

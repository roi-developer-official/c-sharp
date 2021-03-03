namespace chapter4
{
    partial class Program
    {
        public class Shape
        {
            public int Widht { get; set; }
            public int Height { get; set; }

            public virtual void Draw()
            {

            }
            

        }
    }

    public abstract class AbstractShape
    {
        public abstract void Draw();
        public void Copy()
        {
            System.Console.WriteLine("Copied To clipboard");
        }
    }
}

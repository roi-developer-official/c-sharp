using System.Collections.Generic;

namespace chapter4
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //abstract modifier to the method as a missing implementation
            //and the implementation needs to be provide in the derived classes
            ///you use abstract to enforce implentation 
            //rule1 - abstract method cannot include implementation.
            //rule2 - if a member declared as abstract the class must declared as abstract too.
            //rule3 - in the derived class you must implement all the abstract methods.(as override method)
            //rule4 - an abstract class cannot be intancieted.

            var shapes = new List<Shape>();
            //sealed - prevent derivation of class or a method.
            //sealed can only apply to a method that overriding a method in the base class
            
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());

            var canvas = new Canvas();
            canvas.DrawShape(shapes);

        }
    }
}

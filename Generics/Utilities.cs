using System;

namespace Generics
{
    //constarains:
    // where T : IComperable
    // where T : Product
    // where T : struct
    // where T : class
    // where T : new()
    public class Utilities
    {
        public T Max<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b)  > 0 ? a : b;
        }
        public void DoSomething<T>(T value) where T : new()
        {
            var obj = new T();
        }
    }

    public class DiscountCaculator<Tproduct> where Tproduct : Product
    {
        public float CalculateDiscount(Product product)
        {
            return product.price;
        }
    }

    public class Nullable <T> where T : struct
    {
        private object _value;
        public Nullable()
        {

        }
        public Nullable(T value)
        {
            _value = value;
        }
        public bool HasValue
        {
            get { return _value != null; }
        }
        public T GetValueOrDefault()
        {
            if(HasValue)
            {
                return (T)_value;
            }
            return default(T);
        }
    }
}

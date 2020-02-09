namespace AdvancedRef.Generics
{
    class Nullable<T> where T: struct
    {
        private object _val;

        public Nullable()
        {

        }

        public Nullable(T val)
        {
            _val = val;
        }

        public bool HasValue
        {
            get {
                return _val != null;
            }
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
            {
                return (T)_val;
            }

            return default(T);
        }
    }

    class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float CalculateDiscount(TProduct product)
        {
            return product.Price;
        }
    }
}

namespace Testing
{
    public class Nullable<T> where T : struct
    {
        private object _value;

        public Nullable()
        {
            
        }

        public Nullable(T value)
        {
            _value = value;
        }

        public bool hasValue
        {
            get { return _value != null; }
        }

        public T GetValueOrDefault()
        {
            if (hasValue)
                return (T) _value;

            return default(T);
        }

    }
}
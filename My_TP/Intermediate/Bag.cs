namespace My_TP
{
    public class Bag<T>
    {
        private T[] _stockage;
        public int Capacity { get; private set; }

        public Bag(int capaciy)
        {
            throw new NotImplementedException("not yet implemented");
        }
        
        public T? this[int i]
        {
            get
            {
                throw new NotImplementedException("not yet implemented");
            }
            set
            {
                throw new NotImplementedException("not yet implemented");
            }
        }

        public IEnumerable<T> Iterator()
        {
            throw new NotImplementedException("not yet implemented");
        }
    }
}
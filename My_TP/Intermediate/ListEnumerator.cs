using System.Collections;
namespace My_TP
{

    public class ListEnumerator : IEnumerator
    {
        private Head _data;
        int position = -1;

        public ListEnumerator(Head data)
        {
            throw new NotImplementedException("not yet implemented");
        }

        public bool MoveNext()
        {
            throw new NotImplementedException("not yet implemented");
        }

        public void Reset()
        {
            throw new NotImplementedException("not yet implemented");
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }

        public int Current
        {
            get { throw new NotImplementedException("not yet implemented"); }
        }
    }
    
    public partial class ListEnumerable : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException("not yet implemented");
        }
    }
}
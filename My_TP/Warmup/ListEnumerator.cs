using System;
using System.Collections;


namespace My_TP
{

    public class Head
    {
        public List_Space? Next { get; set; }

        public Head()
        {
            throw new NotImplementedException("not yet implemented");
        }

        public void Reset_Next()
        {
            throw new NotImplementedException("not yet implemented");
        }
    }
    
    public class List_Space
    {
        public int Value { get; private set; }
        public List_Space? Next { get; set; }

        public List_Space(int value)
        {
            throw new NotImplementedException("not yet implemented");
        }

        public void Reset_Next()
        {
            throw new NotImplementedException("not yet implemented");
        }
    }
    
    public partial class ListEnumerable : IEnumerable
    {
        private Head _head;

        public ListEnumerable()
        {
            throw new NotImplementedException("not yet implemented");
        }
        
        public int this[int i]
        {
            get
            {
                throw new NotImplementedException("not yet implemented");
            }
        }

        public void Add_Item(int item)
        {
            throw new NotImplementedException("not yet implemented");
        }
        
        public IEnumerable<int> GetEnumerable()
        {
            throw new NotImplementedException("not yet implemented");
        }
        
        
        public void Reset_List()
        {
            throw new NotImplementedException("not yet implemented");
        }
    }

}


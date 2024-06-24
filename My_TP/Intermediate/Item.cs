namespace My_TP
{
    public abstract class Item
    {
        public String Name;
        public String Type;
        
        protected Item(String name, String type)
        {
            throw new NotImplementedException("not yet implemented");
        }

        public abstract void Update();
    }
}


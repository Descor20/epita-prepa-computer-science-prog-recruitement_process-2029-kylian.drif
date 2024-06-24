namespace My_TP
{
    public class Food : Item
    {
        public int Effect;
        private int _durability;
        
        public Food(String name, String type, int effect, int durability): base(name,type)
        {
            throw new NotImplementedException("not yet implemented");
        }

        public int Use()
        {
            throw new NotImplementedException("not yet implemented");
        }

        public void Set_Effect_Gain(int energy)
        {
            throw new NotImplementedException("not yet implemented");
        }

        public override void Update()
        {
            throw new NotImplementedException("not yet implemented");
        }
        
        public bool Is_Usable()
        {
            throw new NotImplementedException("not yet implemented");
        }
    }
}
namespace My_TP
{
    public class Spear : Item
    {
        public int Damage;
        private int _durability;
        private int _distance;
        
        public Spear(String name, String type, int distance, int damage, int durability): base(name,type)
        {
            throw new NotImplementedException("not yet implemented");
        }
        
        public int Get_Distance()
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
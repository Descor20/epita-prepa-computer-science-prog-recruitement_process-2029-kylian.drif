namespace My_TP
{
    public class Sword : Item
    {
        public int Damage;
        private int _durability;
        
        public Sword(String name, String type, int damage, int durability): base(name,type)
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
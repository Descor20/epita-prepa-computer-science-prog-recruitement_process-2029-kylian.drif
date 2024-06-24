using System.Collections;
using System.Xml.Schema;

namespace My_TP
{
    public class Character
    {
        public String Name;
        public int Age;
        public String Specie;
        private int _maxHealth;
        public int Health { get; set; }
        private int _maxEnergy;
        public int Energy { get; private set; }
        public int Food_Need { private get; set; }
        public int Strength;
        private Bag<Item> _inventory;
        private int _carryWeight;
        public Item? Right_Hand { get; set; }


        public Character(String name, String specie, int age)
        {
            throw new NotImplementedException("not yet implemented");
        }

        public int Get_Health()
        {
            throw new NotImplementedException("not yet implemented");
        }
        
        public int Get_Energy()
        {
            throw new NotImplementedException("not yet implemented");
        }

        public Item? Get_Right_Hand()
        {
            throw new NotImplementedException("not yet implemented");
        }

        public void Print_Character()
        {
            throw new NotImplementedException("not yet implemented");
        }
        
        public int Add_Item (Item item)
        {
            throw new NotImplementedException("not yet implemented");
        }
        
        public int Remove_Item (Item item)
        {
            throw new NotImplementedException("not yet implemented");
        }
        
        public int Remove_Index (int index)
        {
            throw new NotImplementedException("not yet implemented");
        }
        
        public int Equip_Item (int index)
        {
            throw new NotImplementedException("not yet implemented");
        }
        
        public int Unequip_Item()
        {
            throw new NotImplementedException("not yet implemented");
        }
        
        public int Update()
        {
            throw new NotImplementedException("not yet implemented");
        }

        public int Use_Item(int index)
        {
            throw new NotImplementedException("not yet implemented");
        }

        public IEnumerable<Item> Bag_iterator()
        {
            throw new NotImplementedException("not yet implemented");
        }

        public void Set_Food_Need(int food_need)
        {
            throw new NotImplementedException("not yet implemented");
        }
    }
}


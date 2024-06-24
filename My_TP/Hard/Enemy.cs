using My_TP;

namespace My_TP
{
    public class Enemy : Character
    {
        private int _x;
        private int _y;
        
        public Enemy(String name, String specie, int age, int x, int y, int health, Item weapon): base (name, specie, age)
        {
            throw new NotImplementedException("not yet implemented");
        }

        public (int, int) GetCoordinates()
        {
            throw new NotImplementedException("not yet implemented");
        }
    }
}
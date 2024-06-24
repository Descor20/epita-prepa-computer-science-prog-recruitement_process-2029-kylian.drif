using System.Text.RegularExpressions;
using System.Xml.Schema;
using My_TP;

namespace My_TP
{
    public class CharacterHard : Character
    {
        private int _x;
        private int _y;
        
        public CharacterHard(String name, String specie, int age, int x, int y): base (name, specie, age)
        {
            throw new NotImplementedException("not yet implemented");
        }

        public (int, int) GetCoordinates()
        {
            throw new NotImplementedException("not yet implemented");
        }

        public void Move(String direction, (int, int) size)
        {
            throw new NotImplementedException("not yet implemented");
        }
    }
}
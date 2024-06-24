using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace My_TP
{
    public class Game
    { 
        private Board _board;
        public CharacterHard Player;
        public String Action;
        private List<Enemy> _enemies;
        private int _dayCount;
        public Random Rand;

        public Game(String player_data, String action)
        {
            throw new NotImplementedException("not yet implemented");
        }
        
        public int Play()
        {
            throw new NotImplementedException("not yet implemented");
        }

        public void Change_Action(String action)
        {
            throw new NotImplementedException("not yet implemented");
        }

        protected void Spawn_Enemies(int n)
        {
            throw new NotImplementedException("not yet implemented");
        }
        
        protected bool NextDay()
        {
            throw new NotImplementedException("not yet implemented");
        }
        
        protected void PrintBoard()
        {
            throw new NotImplementedException("not yet implemented");
        }
    }
}


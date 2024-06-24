using System.Collections;
using System.Data;

namespace My_TP
{
    public class Board
    {
        private Item?[][] _cells;
        private int _capacityX;
        private int _capacityY;
        private Random _rand;

        public Board(int capacityX, int capacityY, Random rand)
        {
            throw new NotImplementedException("not yet implemented");
        }
        
        public Item? this[int i, int j]
        {
            get
            {
                throw new NotImplementedException("not yet implemented");
            }
        }

        public int Get_length(int side)
        {
            throw new NotImplementedException("not yet implemented");
        }

        public (int, int) Get_Capacity()
        {
            throw new NotImplementedException("not yet implemented");
        }
        
        public void Spawn(int n)
        {
            throw new NotImplementedException("not yet implemented");
        }
        
        public Item? Remove(int i, int j)
        {
            throw new NotImplementedException("not yet implemented");
        }

        private IEnumerable<Item?> Iterator ()
        {
            throw new NotImplementedException("not yet implemented");
        }
        
        public BoardEnum GetEnumerator()
        {
            throw new NotImplementedException("not yet implemented");
        }
        
        public void Update(List<Enemy> enemies, CharacterHard character)
        {
            throw new NotImplementedException("not yet implemented");
        }

        public String Display(int x, int y)
        {
            throw new NotImplementedException("not yet implemented");
        }
    }
    
    public class BoardEnum : IEnumerator
    {
        private Item?[][] Cell;
        private int positionx = -1;
        private int positiony = -1;

        public BoardEnum(Item?[][] cell)
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

        object? IEnumerator.Current
        {
            get
            {
                throw new NotImplementedException("not yet implemented");
            }
        }

        public Item? Current
        {
            get
            {
                throw new NotImplementedException("not yet implemented");
            }
        }
    }

}
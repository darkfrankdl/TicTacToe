using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer
{
    public class GameRepository
    {
        private static GameRepository _repo;
        private static readonly object _lock = new object();

        public ApplicationGame AppGame { get; private set; }
        private GameRepository() 
        { 
            AppGame = new ApplicationGame();
        }

        public static GameRepository GetRepo()
        {
            if(_repo == null)
            {
                lock (_lock)
                {
                    if (_repo == null)
                    {
                        _repo = new GameRepository();
                    }
                    
                }
            }
            return _repo;
        }
    }
}

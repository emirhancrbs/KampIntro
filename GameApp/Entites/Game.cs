using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp.Entites
{
    public class Game
    {
        public int Id { get; set; }
        public int Category { get; set; }
        public string GameName { get; set; }
        public double Price { get; set; }
    }
}

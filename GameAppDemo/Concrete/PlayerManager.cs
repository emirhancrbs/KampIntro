using GameAppDemo.Abstract;
using GameAppDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAppDemo.Concrete
{
    internal class PlayerManager : IPlayerService
    {
        public void Delete(Player player)
        {
            Console.WriteLine("Deleted :"+player.FirstName);
        }

        public void Save(Player player)
        {
            Console.WriteLine("Saved player : "+player.FirstName);
        }

        public void Update(Player player)
        {
            Console.WriteLine("Update player : "+player.FirstName);
        }
    }
}

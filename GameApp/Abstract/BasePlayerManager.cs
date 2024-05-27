using GameApp.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp.Abstract
{
    public abstract class BasePlayerManager : IPlayerService
    {
        public virtual void Add(Player player)
        {
            Console.WriteLine("Saved db : "+player.FirstName);
        }

        public virtual void Delete(Player player)
        {
            Console.WriteLine("Deleted : "+player.FirstName);
        }

        public virtual void Update(Player player)
        {
            Console.WriteLine("Update : "+player.FirstName);
        }
    }
}

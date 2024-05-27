using GameApp.Abstract;
using GameApp.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp.Concrate
{
    public class CampainManager : ICampainService
    {
        List<Campain> campains = new List<Campain>();
        public void Add(Campain campain)
        {
            campains.Add(campain);
            Console.WriteLine("Added Campain: "+campain.CampainName);
        }

        public void Remove(Campain campain)
        {
            campains.Remove(campain);
            Console.WriteLine("Deleted Campain: "+campain.CampainName);
        }

        public void Update(Campain campain)
        {
            Console.WriteLine("Campain Updated: "+campain.CampainName);
        }
    }
}

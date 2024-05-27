using GameApp.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp.Abstract
{
    public interface ICampainService
    {
        void Add(Campain campain);
        void Remove(Campain campain);
        void Update (Campain campain);
    }
}

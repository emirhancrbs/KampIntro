using GameApp.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp.Abstract
{
    public interface IPlayerCheckService
    {
        Task<bool> CheckIfRealPlayer(Player player);
    }
}

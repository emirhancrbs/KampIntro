using GameAppDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameAppDemo.Abstract
{
    public interface IPlayerCheckService
    {
        Task<bool> CheckIfRealPerson(Player player);
    }
}

using GameApp.Abstract;
using GameApp.Entites;

namespace GameApp.Concrate
{
    internal class PlayerCheckManager : IPlayerCheckService
    {

        Task<bool> IPlayerCheckService.CheckIfRealPlayer(Player player)
        {
            return Task.FromResult(true);
        }
    }
}

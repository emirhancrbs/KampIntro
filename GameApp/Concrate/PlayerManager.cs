using GameApp.Abstract;
using GameApp.Entites;

namespace GameApp.Concrate
{
    public class PlayerManager : BasePlayerManager
    {
        private IPlayerCheckService _playerCheckService;
        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }
        public override void Add(Player player)
        {
            if (_playerCheckService.CheckIfRealPlayer(player).Result)
            {
                base.Add(player);
            }
            else
            {
                Console.WriteLine("Kayıt Edilemedi.");
            }
        }
    }
}

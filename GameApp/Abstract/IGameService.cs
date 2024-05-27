using GameApp.Entites;

namespace GameApp.Abstract
{
    internal interface IGameService
    {
        void AddGame(Game game);
        void RemoveGame(Game game);
        void SellGame(Game game,Player player);
        void SellCampainGame(Game game, Player player, Campain campaign);
    }
}

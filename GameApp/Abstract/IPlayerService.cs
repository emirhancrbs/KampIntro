using GameApp.Entites;

namespace GameApp.Abstract
{
    public interface IPlayerService
    {
        void Add(Player player);
        void Delete(Player player);
        void Update(Player player);
    }
}

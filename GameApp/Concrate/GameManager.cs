using GameApp.Abstract;
using GameApp.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp.Concrate
{
    public class GameManager : IGameService
    {
        List<Game> games = new List<Game>();
        public void AddGame(Game game)
        {
            games.Add(game);
            Console.WriteLine("Game added :"+game.GameName);
        }

        public void RemoveGame(Game game)
        {
            games.Remove(game);
            Console.WriteLine("Game deleted : "+game.GameName);
        }
        
        public void SellGame(Game game,Player player)
        {
            Console.WriteLine("-----------------------------------------------\nGame Name : " + game.GameName + "\nPlayer Name : " + player.FirstName + "\nGame Price : " + game.Price);
        }

        public void SellCampainGame(Game game,Player player,Campain campaign)
        {
            Console.WriteLine("-----------------------------------------------\nGame Name : " + game.GameName + "\nPlayer Name : " + player.FirstName + "\nGame Price : " + game.Price+"\nCampain :"+campaign.CampainName+"||%"+campaign.Discount);
        }
    }
}

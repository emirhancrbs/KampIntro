using GameApp.Abstract;
using GameApp.Adapters;
using GameApp.Concrate;
using GameApp.Entites;

namespace GameApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player { NationalityId = "16514310146", FirstName = "Emirhan", LastName = "Çeribaş", DateOfBirth = new DateTime(2002, 9, 6) };
           
            BasePlayerManager playerManager = new PlayerManager(new MernisServiceAdapter());
            playerManager.Add(player1);

            Game game1 = new Game { Id = 1, Category = 1, GameName = "Lol", Price = 159 };
            Game game2 = new Game { Id = 2, Category = 2, GameName = "Valorant", Price = 155 };
            GameManager gameManager = new GameManager();
            gameManager.AddGame(game1);
            gameManager.AddGame(game2);

            Campain campain1 = new Campain { Id = 1, CampainName = "Winter", Discount = 25 };
            Campain campain2 = new Campain { Id = 2, CampainName = "Summer", Discount = 35 };
            CampainManager campainManager = new CampainManager();
            campainManager.Add(campain1);
            campainManager.Add(campain2);

            gameManager.SellGame(game1,player1);
            gameManager.SellCampainGame(game2,player1,campain2);


        }
  
    }
}

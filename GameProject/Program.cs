using GameProject.Abstract;
using GameProject.Adapters;
using GameProject.Concrete;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer()
            {
                Id = 1,
                FirstName = "Yusuf Can",
                LastName = "Bayram",
                DateOfBirth = new DateTime(2003, 03, 05),
                NationalityId = "11111111111"
            };             
            BaseManager steamGamerManager = new SteamGamerManager(new MernisServiceAdapter()); // e devlet kontrolü
            BaseManager epicgamesGamerManager = new EpicGamesGamerManager(new GamerCheckManager()); // 18 yaşından büyük küçük kontrolü
            steamGamerManager.Add(gamer1);
            epicgamesGamerManager.Add(gamer1);
            
            Console.WriteLine("*******************************************");
            Game game1 = new Game()
            {
                Id = 1,
                GameCategory = "RPG",
                GameName = "The Witcher 3 : Wild Hunt",
                GamePrice = 75
            };
            GameManager gameManager = new GameManager();
            gameManager.Add(game1);

            Console.WriteLine("*******************************************");

            Campaign campaign1 = new Campaign()
            {
                Id = 1,
                CampaignName = "Yaz indirimi",
                CampaignDiscount = 50
            };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            Console.WriteLine("*******************************************");

            GameSaleManager gameSaleManager = new GameSaleManager();
            gameSaleManager.Sale(game1, gamer1, campaign1);



            Console.ReadLine();
        }
    }
}

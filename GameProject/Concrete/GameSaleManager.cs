using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class GameSaleManager : IGameSaleService
    {
        public void Sale(Game game, Gamer gamer, Campaign campaign)
        {
            double newPrice = game.GamePrice - (game.GamePrice * (campaign.CampaignDiscount / 100));
            Console.WriteLine(game.GameName + " adlı oyun " + gamer.FirstName + " " + gamer.LastName + " adlı kişiye satıldı");
            Console.WriteLine("Uygulanan indirim fiyatı : " + game.GamePrice * (campaign.CampaignDiscount / 100) + " TL");
            Console.WriteLine("Oyunun indirimli fiyatı : " + newPrice + " TL");
            
        }
    }
}

using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class EpicGamesGamerManager:BaseManager
    {
        IGamerCheckService _gamerCheckService;

        public EpicGamesGamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public override void Add(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealPerson(gamer))
            {
                base.Add(gamer);
            }
            else
            {
                Console.WriteLine("Bilgilerinizi doğrulanamadı. Kayıt eklenmedi");
            }
            
        }
    }
}

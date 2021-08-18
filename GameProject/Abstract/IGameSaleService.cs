using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    public interface IGameSaleService
    {
        void Sale(Game game, Gamer gamer, Campaign campaign);
    }
}

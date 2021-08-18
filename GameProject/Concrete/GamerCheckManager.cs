using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class GamerCheckManager : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            if ((DateTime.Now.Year - gamer.DateOfBirth.Year) >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}

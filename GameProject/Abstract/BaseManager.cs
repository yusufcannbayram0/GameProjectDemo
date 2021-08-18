using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Abstract
{
    public abstract class BaseManager:IGamerService
    {
        public void Delete(Gamer gamer)
        {
            Console.WriteLine("kullanıcı silindi : " + gamer.FirstName);
        }

        public virtual  void Add(Gamer gamer)
        {
            Console.WriteLine("kullanıcı veritabanına kaydedildi : " + gamer.FirstName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("kullanıcı güncellendi : " + gamer.FirstName);
        }
    }
}

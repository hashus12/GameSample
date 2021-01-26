using System;
using System.Collections.Generic;
using System.Text;
using GameSample.Interfaces;

namespace GameSample.Interfaces
{
    class GamerManager : IPersonManager
    {
        public void Save(IPerson gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " kayıt edildi.");
        }

        public void Update(IPerson gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " güncellendi.");
        }

        public void Delete(IPerson gamer)
        {
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " silindi.");
        }
    }
}

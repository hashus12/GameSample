using GameSample.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSample.Entities
{
    class Gamer : IPerson
    {
        public string FirstName { get ; set ; }
        public string LastName { get ; set ; }
        public string TcNo { get ; set ; }
        public int BirthDay { get ; set ; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameSample.Interfaces
{
    public interface IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TcNo { get; set; }
        public int BirthDay { get; set; }
    }

}

using System;
using System.Collections.Generic;
using System.Text;

namespace GameSample.Interfaces
{
    public interface IPersonManager
    {
        public void Save(IPerson person);
        public void Update(IPerson person);
        public void Delete(IPerson person);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MISIS.NetCore.Domain;

namespace MISIS.NetCore.Infrastructure
{
    public class Repository:IRepository
    {
        public Flat[] GetFlats()
        {
            return new Flat[]
            {
                new Flat
                {
                    Number = "1",
                    RoomsNumber = 2
                },
                new Flat
                {
                    Number = "2",
                    RoomsNumber = 1
                }
            };
        }
    }
}

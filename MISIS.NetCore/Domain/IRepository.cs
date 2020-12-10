using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISIS.NetCore.Domain
{
    public interface IRepository
    {
        Flat[] GetFlats();
    }
}

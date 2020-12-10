using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISIS.NetCore.Domain
{
    public class Service : IService
    {
        private IRepository _repository;

        public Service(IRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public Flat[] GetFlats()
        {
            return _repository.GetFlats();
        }
    }
}

using Solid.Core.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class CateringRepository : ICateringRepository
    {
        private readonly DataContext _context;

        public CateringRepository(DataContext context)
        {
            _context = context;
        }
        public bool AddCatering(Catering catering)
        {
            _context.Caterings.Add(catering);
            return true;
        }

        public List<Catering> GetCaterings()
        {
            return _context.Caterings;
        }

        public bool RemoveCatering(Catering catering)
        {
            return _context.Caterings.Remove(catering);
        }

        public bool UpdateCatering(Catering source, Catering catering)
        {
            return RemoveCatering(source) && AddCatering(catering);
        }
    }
}

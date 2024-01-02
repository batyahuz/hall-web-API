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
        public Catering AddCatering(Catering catering)
        {
            _context.Caterings.Add(catering);
            _context.SaveChanges();
            return catering;
        }

        public IEnumerable<Catering> GetAllCaterings()
        {
            return _context.Caterings;
        }

        public Catering? GetCateringById(int id)
        {
            return _context.Caterings.Find(id);
        }

        public Catering RemoveCatering(int id)
        {
            var catering = GetCateringById(id);
            _context.Caterings.Remove(catering);
            _context.SaveChanges();
            return catering;
        }

        public Catering UpdateCatering(Catering source, Catering catering)
        {
            _context.Caterings.Remove(source);
            _context.Caterings.Add(catering);
            _context.SaveChanges();
            return catering;
        }
    }
}

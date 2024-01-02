using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface ICateringRepository
    {
        public Catering AddCatering(Catering catering);
        public IEnumerable<Catering> GetAllCaterings();
        public Catering? GetCateringById(int id);
        public Catering RemoveCatering(int id);
        public Catering UpdateCatering(Catering source, Catering catering);
    }
}

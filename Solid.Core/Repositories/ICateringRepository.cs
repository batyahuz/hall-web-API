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
        List<Catering> GetCaterings();
        bool RemoveCatering(Catering catering);
        bool UpdateCatering(Catering source,Catering catering);
        bool AddCatering(Catering catering);
    }
}

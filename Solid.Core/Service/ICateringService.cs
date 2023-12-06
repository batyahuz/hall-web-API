using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Service
{
    public interface ICateringService
    {
        IEnumerable<Catering> GetAllCaterings(string? text = "");
        IEnumerable<Catering> GetCateringById(int id, string? text = "");
        IEnumerable<Catering> AddCatering(Catering catering);
        void UpdateCateringById(IEnumerable<Catering> c, Catering catering);
        void RemoveCatering(Catering catering);
    }
}

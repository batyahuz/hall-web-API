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
        Catering? GetCateringById(int id, string? text = "");
        Catering AddCatering(Catering catering);
        Catering RemoveCateringById(int id);
        Catering? UpdateCateringById(int id, Catering catering);
    }
}

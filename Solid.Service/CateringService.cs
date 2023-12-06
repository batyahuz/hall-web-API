using Solid.Core.Entities;
using Solid.Core.Repositories;
using Solid.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service
{
    public class CateringService : ICateringService
    {
        private readonly ICateringRepository _cateringRepository;

        public CateringService(ICateringRepository cateringRepository)
        {
            _cateringRepository = cateringRepository;
        }

        public IEnumerable<Catering> AddCatering(Catering catering)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Catering> GetAllCaterings(string? text = "")
        {
            return _cateringRepository.GetCaterings().Where(c => c.Name.Contains(text));
        }

        public IEnumerable<Catering> GetCateringById(int id, string? text = "")
        {
            return GetAllCaterings(text).Where(c => c.Id == id);
        }

        public void RemoveCatering(Catering catering)
        {
            _cateringRepository.GetCaterings().ToList().Find(c => c.Equals(catering));
        }

        public void UpdateCateringById(IEnumerable<Catering> c, Catering catering)
        {
            throw new NotImplementedException();
        }
    }
}

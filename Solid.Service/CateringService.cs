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

        public Catering AddCatering(Catering catering)
        {
            _cateringRepository.AddCatering(catering);
            return catering;
        }

        public IEnumerable<Catering> GetAllCaterings(string? text = "")
        {
            return _cateringRepository.GetCaterings().Where(c => c.Name.Contains(text));
        }

        public IEnumerable<Catering> GetCateringById(int id, string? text = "")
        {
            return GetAllCaterings(text).Where(c => c.Id == id);
        }

        public bool RemoveCateringById(int id)
        {
            return _cateringRepository.RemoveCatering((Catering)GetCateringById(id));
        }

        public bool UpdateCateringById(int id, Catering catering)
        {
            return _cateringRepository.UpdateCatering((Catering)GetCateringById(id), catering);
        }
    }
}
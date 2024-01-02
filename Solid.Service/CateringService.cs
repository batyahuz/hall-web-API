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
            return _cateringRepository.GetAllCaterings().Where(c => c.Name.Contains(text));
        }

        public Catering? GetCateringById(int id, string? text = "")
        {
            var catering = _cateringRepository.GetCateringById(id);
            return catering != null && catering.Name.Contains(text) ? catering : null;
        }

        public Catering RemoveCateringById(int id)
        {
            return _cateringRepository.RemoveCatering(id);
        }

        public Catering? UpdateCateringById(int id, Catering catering)
        {
            var source = GetCateringById(id);
            return source == null ? null : _cateringRepository.UpdateCatering(source, catering);
        }
    }
}
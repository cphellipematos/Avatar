using Avatar.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Avatar.Domain.Entities;
using Avatar.Domain.Interfaces.Repository;

namespace Avatar.Domain.Services
{
    public class DurationTypeService : IDurationTypeService
    {
        #region Properties
        private readonly IDurationTypeRepository _durationTypeRepository;
        #endregion

        public DurationTypeService(IDurationTypeRepository durationTypeRepository)
        {
            _durationTypeRepository = durationTypeRepository;
        }

        public IEnumerable<DurationType> GetAllDurationType()
        {
            return _durationTypeRepository.GetAll();
        }
    }
}

using Avatar.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Avatar.Application.ViewModel;
using Avatar.Domain.Interfaces.Services;
using Avatar.Domain.Interfaces.Repository;
using Avatar.Domain.Commands.DurationTypeCommands;

namespace Avatar.Application.Service
{
    public class DurationTypeAppService : IDurationTypeAppService
    {
        #region Properties
        private readonly IDurationTypeRepository _durationTypeRepository;
        #endregion

        public DurationTypeAppService(IDurationTypeRepository durationTypeRepository)
        {            
            _durationTypeRepository = durationTypeRepository;
        }


        public IEnumerable<GetDurationTypeCommand> GetAllDurationType()
        {
            return new GetDurationTypeCommand().ToCommandList(_durationTypeRepository.GetAll());
        }
    }
}

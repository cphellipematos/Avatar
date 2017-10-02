using Avatar.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Avatar.Application.ViewModel;
using Avatar.Domain.Interfaces.Services;

namespace Avatar.Application.Service
{
    public class DurationTypeAppService : IDurationTypeAppService
    {
        #region Properties
        private readonly IDurationTypeService _durationTypeService;
        #endregion

        public DurationTypeAppService(IDurationTypeService durationTypeService)
        {
            _durationTypeService = durationTypeService;
        }


        public IEnumerable<DurationTypeViewModel> GetAllDurationType()
        {
            return DurationTypeViewModel.ToViewModelList(_durationTypeService.GetAllDurationType());
        }
    }
}

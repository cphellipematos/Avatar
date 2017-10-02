using Avatar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Application.ViewModel
{
    public class DurationTypeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static DurationTypeViewModel ToViewModel(DurationType durationType)
        {
            return new DurationTypeViewModel()
            {
                Id = durationType.Id,
                Name = durationType.Name
            };
        }

        public static IEnumerable<DurationTypeViewModel> ToViewModelList(IEnumerable<DurationType> durationTypes)
        {
            if (durationTypes == null)
                return new List<DurationTypeViewModel>();

            var durationTypesViewModel = new List<DurationTypeViewModel>();

            foreach (var durationType in durationTypes)
            {
                durationTypesViewModel.Add(ToViewModel(durationType));
            }

            return durationTypesViewModel;
        }
    }
}

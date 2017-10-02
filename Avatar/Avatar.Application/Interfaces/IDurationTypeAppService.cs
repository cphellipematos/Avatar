using Avatar.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Application.Interfaces
{
    public interface IDurationTypeAppService
    {
        IEnumerable<DurationTypeViewModel> GetAllDurationType();
    }
}

using Avatar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Domain.Interfaces.Services
{
    public interface IDurationTypeService
    {
        IEnumerable<DurationType> GetAllDurationType();
    }
}

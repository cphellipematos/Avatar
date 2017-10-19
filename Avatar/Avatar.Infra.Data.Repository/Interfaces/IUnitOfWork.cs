using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Infra.Data.Repository.Interfaces
{
    public interface IUnitOfWork
    {
        void Commit();
        void Rollback();
    }
}

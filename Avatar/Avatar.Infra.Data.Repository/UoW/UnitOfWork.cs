using Avatar.Infra.Data.Repository.Context;
using Avatar.Infra.Data.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Infra.Data.Repository.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AvatarContext _avatarContext;

        public UnitOfWork(AvatarContext avatarContext)
        {
            _avatarContext = avatarContext;
        }
        public void Commit()
        {
            _avatarContext.SaveChanges();
        }

        public void Rollback()
        {
            //
        }
    }
}

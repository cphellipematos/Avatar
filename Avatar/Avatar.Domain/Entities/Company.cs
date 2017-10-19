using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Domain.Entities
{
    public class Company
    {
        #region Constructors
        public Company()
        {
            
        }
        public Company(string name, string description, string role, int idUser, int idDurationType)
        {
            Name = name;
            Role = role;
            Description = description;

            UserId = idUser;
            DurationTypeId = idDurationType;
        }
        #endregion

        #region Properties
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Role { get; private set; }
        public string Description { get; private set; }
        

        public virtual int DurationTypeId { get; private set; }
        public virtual int UserId { get; private set; }

        public virtual DurationType DurationType { get; private set; }
        public virtual User User { get; private set; }

        #endregion

    }
}

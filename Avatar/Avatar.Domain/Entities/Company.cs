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
        public Company(int id, string name, string description, string role, int id_user, int id_durationType)
        {
            Id = id;
            Name = name;
            Role = role;
            Description = description;

            UserId = id_user;
            DurationTypeId = id_durationType;
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

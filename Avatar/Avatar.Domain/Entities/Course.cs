using System;
using System.Collections.Generic;

namespace Avatar.Domain.Entities
{
    public class Course
    {
        #region Constructors
        public Course(int id, string name, string company, string description, int id_user, int id_durationType)
        {
            Id = id;
            Name = name;
            Company = company;
            Description = description;
            UserId = id_user;
            DurationTypeID = id_durationType;
        }
        #endregion
        #region Properties
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Company { get; private set; }
        public string Description { get; private set; }
        public DateTime? InsertDate { get; private set; }
        public DateTime? UpdateDate { get; private set; }

        public int DurationTypeID { get; private set; }
        public int UserId { get; private set; }

        public virtual DurationType DurationType { get; private set; }
        public virtual User User { get; private set; }
        #endregion

    }
}

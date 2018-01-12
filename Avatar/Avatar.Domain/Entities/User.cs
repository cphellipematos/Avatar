using DomainNotificationHelperCore.Assertions;
using DomainNotificationHelperCore.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Domain.Entities
{
    public class User
    {
        #region Properties
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Title { get; private set; }
        public string Linkedin { get; private set; }
        public string Github { get; private set; }
        public string Twitter { get; private set; }
        public string Resume { get; private set; }
        public DateTime InsertDate { get; private set; }
        public DateTime UpdateDate { get; private set; }
        public bool Status { get; private set; }

        public virtual ICollection<Company> Companies { get; set; }

        public virtual ICollection<Course> Courses { get; set; }

        public virtual ICollection<Skill> Skills { get; set; }

        public virtual ICollection<Portfolio> Portfolios{ get; set; }
        #endregion

        #region Constructors
        public User()
        {
            this.Companies = new List<Company>();
            this.Courses = new List<Course>();
            this.Skills = new List<Skill>();
            this.Portfolios = new List<Portfolio>();
        }
        public User(string name, string email)
        {            
            Name = name;
            InsertDate = DateTime.Now;
            UpdateDate = DateTime.Now;
        }
        #endregion

    }
}

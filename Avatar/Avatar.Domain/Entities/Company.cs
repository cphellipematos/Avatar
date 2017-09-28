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
            this.UserCompany = new List<UserCompany>();
        }
        #endregion

        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public virtual ICollection<UserCompany> UserCompany { get; set; }
        #endregion

    }
}

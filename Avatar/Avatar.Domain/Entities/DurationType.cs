using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Domain.Entities
{
    public class DurationType
    {
        #region Constructors
        public DurationType()
        {
            this.Courses = new List<Course>();
        }
        #endregion
        
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
        #endregion

    }
}

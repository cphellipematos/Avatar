﻿using System;
using System.Collections.Generic;

namespace Avatar.Domain.Entities
{
    public class Course
    {
        #region Constructors
        public Course()
        {
            this.UserCourses = new List<UserCourse>();
        }
        #endregion
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }

        public int CourseId { get; set; }

        public virtual int DurationTypeID { get; set; }
        public virtual DurationType DurationType { get; set; }

        public virtual IEnumerable<UserCourse> UserCourses { get; set; }
        #endregion

    }
}

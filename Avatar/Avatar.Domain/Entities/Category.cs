using System.Collections.Generic;

namespace Avatar.Domain.Entities
{
    public class Category
    {
        #region Constructor
        public Category()
        {
            this.User = new List<User>();
        }
        public Category(int id, string name, string description, bool status)
        {
            Id = id;
            Name = name;
            Description = description;
            Status = status;
        }
        #endregion

        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }

        public int UserId { get; set; }

        public virtual ICollection<User> User { get; set; }
        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Domain.Entities
{
    public class Category
    {
        public Category()
        {

        }
        public Category(int id, string name, string description, bool status)
        {
            Id = id;
            Name = name;
            Description = description;
            Status = status;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }

        public IEnumerable<User> User { get; set; }
    }
}

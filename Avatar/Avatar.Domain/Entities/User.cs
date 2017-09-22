using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public int IdCategory { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool Status { get; set; }

        public Category Category { get; set; }
    }
}

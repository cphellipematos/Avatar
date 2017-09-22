using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public int ID_Category { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Insert_Date { get; set; }
        public DateTime Update_Date { get; set; }
        public bool Status { get; set; }

        public Category Category { get; set; }
    }
}

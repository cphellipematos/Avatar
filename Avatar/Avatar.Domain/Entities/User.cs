using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Domain.Entities
{
    public class User
    {
        public User()
        {
            this.UserCompanies = new List<UserCompany>();
        }
        public User(int id, int idCategory, string name, string email, DateTime insertDate, DateTime updateDate, bool status)
        {
            Id = id;
            ID_Category = idCategory;
            Name = name;
            Email = email;
            Insert_Date = insertDate;
            Update_Date = updateDate;
            Status = status;

        }
        public int Id { get; private set; }
        public int ID_Category { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public DateTime Insert_Date { get; private set; }
        public DateTime Update_Date { get; private set; }
        public bool Status { get; private set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<UserCompany> UserCompanies { get; set; }
    }
}

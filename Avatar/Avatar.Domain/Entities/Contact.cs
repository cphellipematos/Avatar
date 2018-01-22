using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Domain.Entities
{
    public class Contact
    {
        public Contact()
        {

        }
        public Contact(int id, string company, string name, string email, string phone, string description)
        {
            Id = id;
            Company = company;
            Name = name;
            Email = email;
            Phone = phone;
            Description = description;
            UserId = 4003;
        }

        public int Id { get; set; }
        public string Company { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }

        public virtual int UserId { get; private set; }

        public virtual User User { get; private set; }

    }
}

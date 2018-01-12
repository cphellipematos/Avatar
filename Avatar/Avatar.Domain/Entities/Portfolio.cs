using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Domain.Entities
{
    public class Portfolio
    {
        public Portfolio()
        {

        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Image { get; private set; }
        public string Url { get; private set; }
        public string Github { get; private set; }

        public virtual int UserId { get; private set; }
        public virtual User User { get; private set; }
    }
}

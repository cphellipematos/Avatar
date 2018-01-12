using System;
using System.Collections.Generic;
using System.Text;

namespace Avatar.Domain.Entities
{
    public class Skill
    {
        public Skill(){}

        public int Id { get; private set; }
        public string Title { get; private set; }
        public int Progress { get; private set; }
        public string Img { get; private set; }

        public virtual int UserId { get; private set; }
        public virtual User User { get; private set; }

    }
}

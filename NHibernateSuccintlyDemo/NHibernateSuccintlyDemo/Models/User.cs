using System;
using System.Collections.Generic;

namespace NHibernateSuccintlyDemo.Models
{
    public class User
    {
        public User()
        {
            this.Blogs = new HashSet<Blog>(); this.Details = new UserDetail();
        }

        public virtual Int32 UserId { get; protected set; }
        public virtual String Username { get; set; }
        public virtual UserDetail Details { get; set; }
        public virtual DateTime? Birthday { get; set; }
        public virtual ISet<Blog> Blogs { get; protected set; }
    }
}
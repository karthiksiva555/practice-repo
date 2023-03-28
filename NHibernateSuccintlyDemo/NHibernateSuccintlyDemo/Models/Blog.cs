using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHibernateSuccintlyDemo.Models
{
    public class Blog
    {
        public Blog()
        {
            this.Posts = new List<Post>();
        }
        public virtual Int32 BlogId { get; protected set; }
        public virtual System.Drawing.Image Picture { get; set; }
        public virtual Int64 PostCount { get; protected set; }
        public virtual User Owner { get; set; }
        public virtual String Name { get; set; }
        public virtual DateTime Creation { get; set; }
        public virtual IList<Post> Posts { get; protected set; }
    }
}
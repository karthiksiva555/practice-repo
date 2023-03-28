using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHibernateSuccintlyDemo.Models
{
    public class Comment
    {
        public Comment()
        {
            this.Details = new UserDetail();
        }

        public virtual Int32 CommentId { get; protected set; }
        public virtual UserDetail Details { get; set; }
        public virtual DateTime Timestamp { get; set; }
        public virtual String Content { get; set; }
        public virtual Post Post { get; set; }
    }
}
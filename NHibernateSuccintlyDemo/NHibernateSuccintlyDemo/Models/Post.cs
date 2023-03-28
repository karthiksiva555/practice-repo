using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHibernateSuccintlyDemo.Models
{
    public class Post
    {
        public Post()
        {
            this.Tags = new HashSet<String>();
            this.Attachments = new HashSet<Attachment>();
            this.Comments = new List<Comment>();
        }

        public virtual Int32 PostId { get; protected set; }
        public virtual Blog Blog { get; set; }
        public virtual DateTime Timestamp { get; set; }
        public virtual String Title { get; set; }
        public virtual String Content { get; set; }
        public virtual ISet<String> Tags { get; protected set; }
        public virtual ISet<Attachment> Attachments { get; protected set; }
        public virtual IList<Comment> Comments { get; protected set; }
    }
}
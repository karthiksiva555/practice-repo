using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHibernateSuccintlyDemo.Models
{
    public class Attachment
    {
        public virtual Int32 AttachmentId { get; protected set; }
        public virtual String Filename { get; set; }
        public virtual Byte[] Contents { get; set; }
        public virtual DateTime Timestamp { get; set; }
        public virtual Post Post { get; set; }
    }
}
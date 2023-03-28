namespace NHibernateSuccintlyDemo.Models
{
    public class Course
    {
        public virtual string CourseCode { get; set; }
        public virtual string CourseName { get; set; }
        public virtual int CourseId { get; set; }
    }
}
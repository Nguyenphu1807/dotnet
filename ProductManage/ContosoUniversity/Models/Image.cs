using ProductManage.Models;
using System;
using System.Collections.Generic;

namespace ProductManage.Models
{
    public class Image
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string URL { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
using System;
using System.Collections.Generic;

namespace ProductManage.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
using ProductManage.Models;
using System.Drawing;

namespace ProductManage.Models
{
    //public enum Grade
    //{
    //    A, B, C, D, F
    //}

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int ProductID { get; set; }
        public int ImageID { get; set; }
        //public int CourseID { get; set; }
        //public int StudentID { get; set; }
        //public Grade? Grade { get; set; }

        //public virtual Course Course { get; set; }
        //public virtual Student Student { get; set; }
        public virtual Product Product { get; set; }
        public virtual Image Image { get; set; }
    }
}
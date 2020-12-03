using System.ComponentModel.DataAnnotations.Schema;


namespace HRM.Models
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Luong { get; set; }
        public decimal Age { get; set; }
    }
}

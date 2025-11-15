using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearnBlazor.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsActive {  get; set; }
        [NotMapped]
        public IEnumerable<Product_Prop> ProductProperties { get; set; }

    }
}

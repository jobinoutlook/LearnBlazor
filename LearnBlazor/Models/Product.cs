using System.ComponentModel.DataAnnotations;

namespace LearnBlazor.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsActive {  get; set; }


    }
}

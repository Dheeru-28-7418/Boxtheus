using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Boxtheus.Models
{
    public class BoxView
    {
        public int Id { get; set; }
        
        public string? Brand { get; set; }
        [Display(Name = "Order Date")]
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
       
        public string? Category { get; set; }

        public string? Design { get; set; }
        public string? Shape { get; set; }
        public string? Size { get; set; }
        public int Quantity { get; set; }
        
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
      
    }
}

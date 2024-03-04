using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Boxtheus.Models
{
    public class BoxView
    {
        public int Id { get; set; }
        
        public string? Brand { get; set; }

        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
       
        public string? Category { get; set; }

        public string? Design { get; set; }
        public string? Shape { get; set; }
        public string? Size { get; set; }
        public int Quantity { get; set; }
        
        [DataType(DataType.Currency)]
  
        public decimal Price { get; set; }
      
    }
}

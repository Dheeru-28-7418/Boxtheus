using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Boxtheus.Models
{
    public class BoxView
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? Brand { get; set; }
        [Display(Name = "Order Date")]
        [DataType(DataType.Date)]

        public DateTime OrderDate { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(20)]
        [Required]
        public string? Category { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(50)]
        [Required]
        public string? Design { get; set; }
        public string? Shape { get; set; }
        public string? Size { get; set; }
        public int Quantity { get; set; }
        [Range(1, 500)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(18)]
        [Required]
        public required String Color { get; set; }
    }

}
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventory.Domain
{
    public class StockCounting
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Data da contagem")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? StockTakingDate { get; set; }

        [Display(Name = "Item")]
        [Required(ErrorMessage = "{0} é obrigatório")]
        public string ItemId { get; set; }

        [Display(Name = "Endereçamento")]
        [Required(ErrorMessage = "{0} é obrigatório")]
        public int AddressingsInventoryId { get; set; }

        [Display(Name = "Endereçamento")]
        public AddressingsInventory AddressingsInventory { get; set; }

        [Display(Name = "Quantidade na Contagem")]
        [Required(ErrorMessage = "{0} é obrigatório")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Column(TypeName = "decimal(8,2)")]
        public decimal StockTakingQuantity { get; set; }

        [Column(TypeName = "decimal(8,2)")]
        public decimal StockTakingPreviousQuantity { get; set; } = -1;

        [Display(Name = "Item Perecível")]
        public bool IsPerishableItem { get; set; }
        public List<PerishableItemCounting> PerishableItem { get; set; }

        [Display(Name = "Observação")]
        [StringLength(250, ErrorMessage = "Máximo de {1} caracteres!")]
        public string StockTakingObservation { get; set; }

        public bool ItemToRecount { get; set; }

        public int NumberOfCount { get; set; }
    }
}

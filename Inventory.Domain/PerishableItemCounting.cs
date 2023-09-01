using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;

namespace Inventory.Domain
{
    public class PerishableItemCounting
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Data de Fabricação")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? FabricationDate { get; set; }

        [Display(Name = "Data de Validade")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? ExpirationDate { get; set; }

        [Display(Name = "Lote")]
        [StringLength(30, ErrorMessage = "Máximo de {1} caracteres!")]
        public string ItemBatch { get; set; } = string.Empty;

        [Display(Name = "Quantidade do Lote")]
        [Required(ErrorMessage = "{0} é obrigatório")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Column(TypeName = "decimal(8,2)")]
        public decimal PerishableItemQuantity { get; set; }

        [Column(TypeName = "decimal(8,2)")]
        public decimal PerishableItemPreviousQuantity { get; set; } = 0;
        
        [Display(Name = "Contagem")]
        public int StockTakingId { get; set; }
        [Display(Name = "Contagens")]
        public StockCounting StockTaking { get; set; }
    }
}
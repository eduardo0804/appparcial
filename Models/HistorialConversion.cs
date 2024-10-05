using System.ComponentModel.DataAnnotations.Schema;

namespace appparcial.Models
{
    [Table("t_historial_conversion")]
    public class HistorialConversion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public decimal UsdAmount { get; set; }
        public decimal BtcAmount { get; set; }
    }
}
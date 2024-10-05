using System.ComponentModel.DataAnnotations.Schema;

namespace appparcial.Models
{
    [Table("t_historial_conversion")]
    public class HistorialConversion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string? MonedaOrigen { get; set; }
        public string? MonedaDestino { get; set; }
        public decimal? TasaCambio { get; set; }
        public DateTime Fecha { get; set; }

    }
}
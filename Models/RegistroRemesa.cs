using System.ComponentModel.DataAnnotations.Schema;

namespace appparcial.Models
{
    [Table("t_remesas")]
    public class RegistroRemesa
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string? NomRemitente { get; set; }
        public string? NomDestinatario { get; set; }
        public string? PaisOrigen { get; set; }
        public string? PaisDestino { get; set; }
        public decimal MontoEnviado { get; set; }
        public decimal TasaCambio { get; set; }
        public decimal MontoFinal { get; set; }
        public string? EstadoTransaccion { get; set; }
    }
}
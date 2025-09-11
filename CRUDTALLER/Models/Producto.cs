using System.ComponentModel.DataAnnotations.Schema;

namespace SalesManagementApp.Models

{

    public class Producto

    {

        public int ProductoId { get; set; }

        public required string Nombre { get; set; }

        [Column(TypeName = "decimal(18,2)")]

        public decimal Precio { get; set; }

        public int Stock { get; set; }
    }
}



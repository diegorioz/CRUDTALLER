// Models/Venta.cs


using CRUDTALLER.Models;
using System.ComponentModel.DataAnnotations.Schema;


namespace SalesManagementApp.Models

{

    public class Venta

    {

        public int VentaId { get; set; }

        public DateTime Fecha { get; set; }

        [Column(TypeName = "decimal(18,2)")]

        public decimal Total { get; set; }

        public int ClienteId { get; set; }

        public required Cliente Cliente { get; set; }

        //public required ICollection<DetalleVenta> Detalles { get; set; }

        public required List<DetalleVenta> DetalleVentas { get; set; } // Relación con DetalleVenta

    }

}

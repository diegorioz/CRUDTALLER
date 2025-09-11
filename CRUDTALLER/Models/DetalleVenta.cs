// Models/DetalleVenta.cs


// Models/DetalleVenta.cs

using System.ComponentModel.DataAnnotations.Schema;

namespace SalesManagementApp.Models

{

    public class DetalleVenta

    {

        public int DetalleVentaId { get; set; }


        public int VentaId { get; set; }

        public required Venta Venta { get; set; }


        public int ProductoId { get; set; }

        public required Producto Producto { get; set; }


        public int Cantidad { get; set; }


        // Especificar el tipo de columna con precisión y escala

        [Column(TypeName = "decimal(18,2)")]

        public decimal Subtotal { get; set; }

    }

}

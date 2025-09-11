// Models/Cliente.cs
namespace SalesManagementApp.Models

{
   public class Cliente

    {

        public int ClienteId { get; set; }

        public required string Nombre { get; set; }

        public required string Direccion { get; set; }

        public required string Telefono { get; set; }

    }

}
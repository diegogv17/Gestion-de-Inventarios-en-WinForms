namespace InventarioApp.Models
{
    public class Categoria
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nombre { get; set; } = string.Empty;
    }

    public class Producto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nombre { get; set; } = string.Empty;
        public Guid CategoriaId { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int Stock { get; set; } = 0;
    }

    public enum TipoMovimiento
    {
        Entrada,
        Salida
    }

    public class MovimientoInventario
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid ProductoId { get; set; }
        public TipoMovimiento Tipo { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; } = DateTime.Now;
    }
}
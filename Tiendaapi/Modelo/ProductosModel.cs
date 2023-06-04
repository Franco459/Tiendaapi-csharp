namespace Tiendaapi.Modelo
{
    public class ProductosModel
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public decimal precio { get; set; } //tipo money en SQL
    }
}

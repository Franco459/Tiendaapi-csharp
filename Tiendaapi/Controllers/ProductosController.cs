using Microsoft.AspNetCore.Mvc;
using Tiendaapi.Datos;
using Tiendaapi.Modelo;

namespace Tiendaapi.Controllers
{
    [ApiController]
    [Route("api/productos")]
    public class ProductosController
    {
        [HttpGet]
        public async Task <ActionResult<List<ProductosModel>>> Get()
        {
            var funcion = new DatosProductos();
            var lista = await funcion.mostrarProductos();
            return lista;
        }

        [HttpPost]
        public async Task Post([FromBody] ProductosModel producto)
        {
            var funcion = new DatosProductos();
            //var descripcion = producto.descripcion;
            //var precio = producto.precio;
            await funcion.crearProducto(producto);
        }
    }
}

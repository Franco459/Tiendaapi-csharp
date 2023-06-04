using Microsoft.AspNetCore.Mvc;
using Tiendaapi.Controllers.Modelo;

namespace Tiendaapi.Controllers
{
    [ApiController]
    [Route("api/productos")]
    public class ProductosController
    {
        [HttpGet]
        public async Task <ActionResult<List<ProductosModel>>> Get()
        {

        }
        public async ProdcutosModel GetProdcutos()
        {

        }
    }
}

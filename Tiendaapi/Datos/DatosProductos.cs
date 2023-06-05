using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Tiendaapi.Conexion;
using Tiendaapi.Modelo;

namespace Tiendaapi.Datos
{
    public class DatosProductos
    {
        ConexionDB con = new ConexionDB();
        public async Task<List<ProductosModel>> mostrarProductos()
        {
            var lista = new List<ProductosModel>();
            using (var sql = new SqlConnection(con.conexionSQL()))
            {
                using (var cmd = new SqlCommand("mostrarProductos", sql)) //realizando la consulta sql
                {
                    await sql.OpenAsync();
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var items = await cmd.ExecuteReaderAsync())
                    {
                        while (await items.ReadAsync())
                        {
                            var productos = new ProductosModel();
                            productos.id = (int)items["id"];
                            productos.descripcion = (string)items["descripcion"];
                            productos.precio = (decimal)items["precio"];
                            lista.Add(productos);
                        }
                    }
                }
            }
            return lista;
        }
    }
}

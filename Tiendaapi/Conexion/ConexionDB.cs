namespace Tiendaapi.Conexion
{
    public class ConexionDB
    {
        private string connectionString = string.Empty;
        public ConexionDB()
        {
            var constr = new ConfigurationBuilder().SetBasePath(
                Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            connectionString = constr.GetSection("ConnectionStrings: conexionDB").Value;

        }
        public string conexionSQL()
        {
            return connectionString;
        }
    }
}

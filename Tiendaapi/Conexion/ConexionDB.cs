namespace Tiendaapi.Conexion
{
    public class ConexionDB
    {
        private string connectionStr = string.Empty;
        public ConexionDB()
        {
            var constr = new ConfigurationBuilder().SetBasePath(
                Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            connectionStr = constr.GetSection("ConnectionStrings:conexionmaestra").Value;

        }
        public string conexionSQL()
        {
            return connectionStr;
        }
    }
}

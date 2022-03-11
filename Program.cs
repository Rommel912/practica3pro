using System;
using System.Data.SqlClient;
namespace ConexionSQL
{
    class Program
    {
        static void Main(String[] args)
        {
            string DataSource = "DESKTOP-MCMQE06\\SQLEXPRESS";

            string InitialCatalog = "Alumnos";

            string IntegratedSecurity = "SSPI";

            string UserID = "as";
            string Password = "1234";
            string ConnectionString = "Data Source=" + DataSource + ";Initial Catalog=" +InitialCatalog+";Integrated Security="+IntegratedSecurity;

            try
            {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            Console.WriteLine("La conexion a la base de datos ha sido establecida");
            Console.WriteLine("Estado de la conexion" + connection.State.ToString());
            connection.Close();
            Console.WriteLine("La conexion a la base de datos ha sido cerrada");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Este es un error a la base de datos \n" + ex.Message);
                Console.ReadLine();
            }
        }
    }
}
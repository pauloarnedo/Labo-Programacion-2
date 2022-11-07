using System.Data.SqlClient;
// Click derecho sobre el proyecto > Administrar paquetes de NuGet > Instalar System.Data.SqlClient.
namespace SQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=localhost;Database=EMPRESA_DB;Trusted_Connection=True;";

            //leer

            /*
            SqlConnection conexion;
            SqlCommand command;
            SqlDataReader reader;

            conexion = new SqlConnection(connectionString);
            command = new SqlCommand();

            command.CommandType = System.Data.CommandType.Text;

            command.Connection = conexion;

            command.CommandText = "SELECT * FROM EMPLEADOS";

            //Abrimos la conexion
            conexion.Open();
            //Realizamos la consulta y la guardamos en un objeto DataReader
            reader = command.ExecuteReader();

            List<Empleado> listaEmpleados = new List<Empleado>();
            
            try
            {
                //Guardo una linea (registro) en reader mientras existan registros
                while (reader.Read())
                {
                    string nombre = reader["NOMBRE"].ToString();
                    double sueldo = (double)reader[4];
                    int puesto = reader.GetInt32(3);

                    Empleado e = new Empleado(nombre, sueldo, puesto);

                    Console.Write(nombre + " - ");
                    Console.Write(sueldo + " - ");
                    Console.WriteLine(puesto);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if(conexion.State == System.Data.ConnectionState.Open) 
                {
                    conexion.Close();
                }
            }*/

            //insertar

            /*
            SqlConnection conexionn;
            SqlCommand commandd;

            string consulta = "INSERT INTO EMPLEADOS VALUES('Juancito', 'Perez', 1, 123458.86, 'true', '1996-03-24', NULL, 'pepe@gmail.com')";

            conexionn = new SqlConnection(connectionString);
            commandd = new SqlCommand(consulta, conexionn);

            conexionn.Open();

            int filasAfectadas = commandd.ExecuteNonQuery();
            if (filasAfectadas == 0)
            {
                Console.WriteLine("No se agregó");
            }
            else
            {
                Console.WriteLine("Se agregó");
            }

            conexionn.Close();
            */


            //modificar

            /*
            Empleado emp = new Empleado(4, "jose", "perez", 3, 12312, true, "2020-12-03");

            SqlConnection conexion;
            SqlCommand command;

            string consulta = "UPDATE EMPLEADOS SET NOMBRE=@nombre WHERE ID_EMPLEADO=@id";


            conexion = new SqlConnection(connectionString);
            command = new SqlCommand(consulta, conexion);

            command.Parameters.AddWithValue("@nombre", emp.nombre);
            command.Parameters.AddWithValue("@id", emp.id_empleado);

            conexion.Open();
            int filasAfectadas = command.ExecuteNonQuery();

            if(filasAfectadas > 0)
            {
                Console.WriteLine("se modificó");
            }
            else
            {
                Console.WriteLine("no se modificó");
            }
            */

            //eliminar

            SqlConnection conexion;
            SqlCommand command;

            string consulta = "DELETE FROM EMPLEADOS WHERE ID_EMPLEADO=@id";

            
            using(conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                command = new SqlCommand(consulta, conexion);
                command.Parameters.AddWithValue("@id", 4);

                int filasAfectadas = command.ExecuteNonQuery();

                if (filasAfectadas > 0)
                {
                    Console.WriteLine("se modificó");
                }
                else
                {
                    Console.WriteLine("no se modificó");
                }
            }

            //Ejercicio: "Mi primer CRUD".
            //Ejercicio: "esto definitivamente no es steam".
            //Ejercicio C02 (Si sobra tiempo).
            //Buscar User DAO. Recibe un objeto del tipo que espera y opera en base a eso. Es algo parecido a lo de la clase generica para guardar archivos.
        }
    }
}
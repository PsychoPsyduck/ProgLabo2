using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using Entidades;


namespace Archivos
{
    public class Sql<Queue> : IArchivo<Queue<Patente>>
    {
        private SqlCommand comando;
        private SqlConnection conexion;

        public Sql()
        {

        }

        public void Guardar(string tabla, Queue<Patente> datos)
        {
            string consulta = "INSERT INTO " + tabla + " (nombre)  VALUES('Pedro')";
            String connectionStr = "Data Source=[Instancia Del Servidor]; Initial Catalog =[Nombre de la Base de Datos]; Integrated Security = True";

            conexion = new SqlConnection(connectionStr);
            comando = new SqlCommand();

            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
            comando.CommandText = consulta;

            try
            {
                conexion.Open();
                foreach (var d in datos)
                {
                    comando.ExecuteNonQuery();
                }
            }
            catch
            {

            }
        }

        public void Leer(string tabla, out Queue<Patente> datos)
        {
            datos = new Queue<Patente>();
            string consulta = consulta = "SELECT * FROM " + tabla;
            String connectionStr = "Data Source=[Instancia Del Servidor]; Initial Catalog =[Nombre de la Base de Datos]; Integrated Security = True";

            conexion = new SqlConnection(connectionStr);
            comando = new SqlCommand();

            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
            comando.CommandText = consulta;

            conexion.Open();

            SqlDataReader oDr = comando.ExecuteReader();

            Patente p = new Patente();
            while (oDr.Read())
            {
                p.CodigoPatente = oDr["*"].ToString();
                datos.Enqueue(p);
            }
        }
    }
}

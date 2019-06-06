using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ejercicio60
{
    class Conexion
    {
        public SqlConnection conexion;
        public SqlCommand comando;

        public Conexion()
        {
            string connectionString = "Data Source=LAB3PC01; Initial Catalog=AdventureWorks2012; Integrated Security=true";

            try
            {
                conexion = new SqlConnection(connectionString);
                comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
            }
            catch(Exception e)
            {
                throw e;
            }

        }

        public bool Insert(string tabla, string columna1, string columna2, string valor1, string valor2)
        {
            bool respuesta = false;

            try
            {
                string consulta = String.Format("INSERT INTO {0} ({1}, {2}) VALUES ('{3}', '{4}')",
                                                tabla, columna1, columna2, valor1, valor2);
                comando.CommandText = consulta;
                conexion.Open();
                comando.ExecuteNonQuery();
                respuesta = true;
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                conexion.Close();
            }
            return respuesta;
        }

        public bool Delete(string tabla, string columna, string valor)
        {
            bool respuesta = false;

            try
            {
                string consulta = String.Format("DELETE FROM {0} WHERE {1} = {2}", tabla, columna, valor);
                comando.CommandText = consulta;
                conexion.Open();
                comando.ExecuteNonQuery();
                respuesta = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conexion.Close();
            }
            return respuesta;
        }

        public List<object> mostrarLista()
        {
            List<object> articulos = new List<object>();
            object articulo;

            string consulta = String.Format("Select * from articulos");
            try
            {
                comando.CommandText = consulta;
                conexion.Open();
                SqlDataReader oDr = comando.ExecuteReader();

                while (oDr.Read())
                {
                    int codigo = int.Parse(oDr["codigo"].ToString());
                    string descripcion = oDr["descripcion"].ToString();
                    int cantidad = int.Parse(oDr["cantidad"].ToString());
                    //articulo = new object(codigo, descripcion, cantidad);
                    //articulos.Add(articulo);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conexion.Close();
            }

            return articulos;
        }

    }
}

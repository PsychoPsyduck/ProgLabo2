using ComiqueriaLogic;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public delegate void InforormarAccion(AccionesDB acciones);

    public class DAO
    {
        private SqlCommand comando;
        private SqlConnection conexion;
        public static event InforormarAccion accion;

        public DAO()
        { }

        public void Insert(string desc, float precio, int stock)
        {
            string insertComando = String.Format("INSERT INTO Productos" +
                            "(Descripcion,Precio,Stock) VALUES " +
                            "('{0}','{1}','{2}')", desc, precio, stock);
            String connectionStr = "Data Source=.\\SQLEXPRESS; Initial Catalog=ComiqueriaDB; Integrated Security = True";

            conexion = new SqlConnection(connectionStr);
            comando.CommandType = System.Data.CommandType.Text;
            comando = new SqlCommand(insertComando, conexion);

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
                accion(AccionesDB.Insert);
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

        }

        public void Delete(int codigo)
        {
            string insertComando = String.Format("DELETE FROM Productos WHERE" +
                            "Codigo == " + "{0}", codigo);
            String connectionStr = "Data Source=.\\SQLEXPRESS; Initial Catalog=ComiqueriaDB; Integrated Security = True";

            conexion = new SqlConnection(connectionStr);
            comando.CommandType = System.Data.CommandType.Text;
            comando = new SqlCommand(insertComando, conexion);

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
                accion(AccionesDB.Delete);
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

        public void Leer(string tabla, out List<Producto> datos)
        {
            datos = new List<Producto>();
            string consulta = consulta = "SELECT Codigo, Descripcion, Precio, Stock FROM " + tabla;
            String connectionStr = "Data Source=.\\SQLEXPRESS; Initial Catalog =patentes-sp-2018; Integrated Security = True";

            int stock;
            double precio;
            int codigo;
            string descripcion;

            conexion = new SqlConnection(connectionStr);
            comando = new SqlCommand();

            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
            comando.CommandText = consulta;

            try
            {
                conexion.Open();
                SqlDataReader oDr = comando.ExecuteReader();
                
                while (oDr.Read())
                {
                    codigo = Convert.ToInt32(oDr["Codigo"].ToString());
                    descripcion = oDr["Descripcion"].ToString();
                    precio = Convert.ToDouble(oDr["Precio"].ToString());
                    stock = Convert.ToInt32(oDr["Stock"].ToString()); // codigo, descripcion, stock, precio);
                    Producto p = new Producto(codigo, descripcion, stock, precio);
                    datos.Add(p);
                }
                accion(AccionesDB.Update);
            }
            catch(Exception e)
            {
                throw e;
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
        }

    }
}

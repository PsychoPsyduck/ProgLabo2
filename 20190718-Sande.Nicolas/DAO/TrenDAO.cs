using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using EntidadesSPyFinal;
//using SPyFinal;

namespace Datos
{
    public class TrenDAO : IData<Tren>
    {

        static string connectionString;

        private static SqlConnection conexion;
        private static SqlCommand comando;

        /// <summary>
        /// Asigna un valor al connectionString
        /// </summary>
        static TrenDAO()
        {
            string conectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=Viajes; Integrated Security=True;";
            connectionString = conectionString;
        }

        public void Guarda(Transporte tren)
        {
            comando = new SqlCommand();
            //string alumno = "Sande, Nicolas Alejandro";
            try
            {
                conexion.Open();
                string insertComando = String.Format("INSERT INTO trenes" +
                            "(cantidad_vagones,fabricante,velocidad) VALUES " +
                            "('{0}','{1}','{2}')",
                            ((Tren)tren).CantidadVagones, tren.Fabricante, tren.Velocidad);
                comando = new SqlCommand(insertComando, conexion);
                comando.ExecuteNonQuery();
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

        public List<Tren> Lee()
        {
            List<Tren> retorno = new List<Tren>();
            string consulta = consulta = "SELECT * FROM trenes";
            String connectionStr = "Data Source=.\\SQLEXPRESS; Initial Catalog =Viajes; Integrated Security = True";

            conexion = new SqlConnection(connectionStr);
            comando = new SqlCommand();

            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
            comando.CommandText = consulta;

            conexion.Open();

            SqlDataReader oDr = comando.ExecuteReader();


            while (oDr.Read())
            {
                string cantVagones = oDr["cantidad_vagones"].ToString();
                string fabricante = oDr["fabricante"].ToString();
                int velocidad = Convert.ToInt32(oDr["velocidad"].ToString());

                EFabricante fabricanteaux;
                if (fabricante == EFabricante.AtadosConAlambreTransportes.ToString())
                    fabricanteaux = EFabricante.AtadosConAlambreTransportes;
                else
                    fabricanteaux = EFabricante.PatitosTransportes;

                Tren tren = new Tren(velocidad, fabricanteaux, cantVagones);
                retorno.Add(tren);
            }

            return retorno;
        }
    }
}

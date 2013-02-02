using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Alpinismo.BD
{
    class AlpinismoDAO
    {



        public int validaHobie(string strhobie)
        {


            int r = 0;

            Boolean b= false;
            SqlConnection cnx = new SqlConnection(ClaseConexion.ObtenerCadenaMINSURBAS());
            SqlCommand cmd = new SqlCommand();

            var _with1 = cmd;
            _with1.Connection = cnx;
            _with1.CommandType = CommandType.StoredProcedure;
            _with1.CommandText = "validhobierep";

            _with1.Parameters.Add("@hobie", SqlDbType.VarChar, 100).Value = strhobie;
            _with1.Parameters.Add("@can", SqlDbType.Int).Value = 0;
            _with1.Parameters["@can"].Direction = ParameterDirection.InputOutput;



            try
            {
                cnx.Open();

                cmd.ExecuteNonQuery();

                r = int.Parse(cmd.Parameters["@can"].Value.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            finally
            {
                cnx.Close();
            }

            return r;

        }

        public Boolean insertHobie(AlpinismoBE hboe)
        {

            Boolean b = true;

            SqlConnection cnx = new SqlConnection(ClaseConexion.ObtenerCadenaMINSURBAS());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr = default(SqlDataReader);
  

            var _with1 = cmd;
            _with1.Connection = cnx;
            _with1.CommandType = CommandType.StoredProcedure;
            _with1.CommandText = "inserhobie";
            _with1.Parameters.Add("@hobie", SqlDbType.VarChar, 100).Value = hboe.Deporte;
            _with1.Parameters.Add("@itinerario", SqlDbType.VarChar, 100).Value = hboe.Horario;
            _with1.Parameters.Add("@tipodedeporte", SqlDbType.VarChar, 100).Value = hboe.Tipo;

            try
            {
                cnx.Open();
                //dr = cmd.ExecuteReader();

                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
                b = false;
            }
            finally
            {
                cnx.Close();
            }
            return b;
        }


        public DataSet gethobies()
        {

            SqlConnection cnx = new SqlConnection(ClaseConexion.ObtenerCadenaMINSURBAS());
            SqlCommand cmd = new SqlCommand();
            DataSet ds = new DataSet();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "gethobies";



            try
            {



                cnx.Open();

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);





            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            finally
            {
                cnx.Close();
            }



            return ds;

        }





    }
}

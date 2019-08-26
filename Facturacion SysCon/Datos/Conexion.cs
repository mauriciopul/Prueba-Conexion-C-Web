using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Facturacion_SysCon.Datos
{
    public class Conexion
    {
        SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=dbPrueba;User ID=sa;Password=m98707140");
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;

        public Conexion()
        {            
            try
            {
                cn.Open();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }            
        }

        public string insertarUsuario(int cod, string nombre, string clave)
        {
            string salida = "Usuario insertado exitosamente";
            try
            {
                //cmd = new SqlCommand(
                //    "insert into Usuario(CodigoUsuario, Nombre, Clave) " +
                //    "values("+cod+", '"+nombre+"','"+clave+"')",cn);
                //cmd.ExecuteNonQuery();
                cmd = new SqlCommand("insertarUsuario " + cod + ", '" + nombre + "','" + clave + "' ", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();

            } catch (Exception ex)
            {
                salida = "error al insertar usuario: "+ex.ToString();
            }
            return salida;
        }
        public bool buscarUsuario(string usuario, string clave)
        {
            bool band = false;
            try
            {
                cmd = new SqlCommand(
                    "select * from Usuario where '"+usuario+"' == Nombre AND '"+clave+"' == Clave ",cn);
                cmd.ExecuteNonQuery();
                band = true;
            }
            catch (Exception ex)
            {
                band = false;
            }
            return band;
        }

    }

}
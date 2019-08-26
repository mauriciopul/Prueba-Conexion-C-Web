using Facturacion_SysCon.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Facturacion_SysCon.Fachada
{
    public partial class Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnEnviarDatosUsu_Click(object sender, EventArgs e)
        {
            var con = new Conexion();
            try
            {
                //Response.Write(con.insertarUsuario(Convert.ToInt32(lblCodUsu.Text), lblNomUsu.Text, lblClaveUsu.Text));
                Response.Write(con.insertarUsuario(Convert.ToInt32(txtcodUsu.Text), txtNomUsu.Text, txtClaveUsu.Text));
             //   Response.Write("<script>console.log('INgreso exitoso');</script>");
             
            }
            catch (Exception ex)
            {
                Response.Write("<script>console.log('Error de ingreso de usuario');</script>" + ex.ToString());
            }
        }
        public void limpiarUsuario()
        {
            txtClaveUsu.Text = "";
            txtcodUsu.Text = "";
            txtNomUsu.Text = "";
        }
    }
}
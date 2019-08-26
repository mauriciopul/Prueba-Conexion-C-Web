using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Facturacion_SysCon.Datos;
using Facturacion_SysCon.Fachada;

namespace Facturacion_SysCon
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                var cn = new Conexion();
            }
            catch (Exception ex)
            {
                Response.Write("<script>console.log('Error fatal');</script>"+ ex.ToString());
            }
            Response.Write("<script>console.log('Conexion exitosaaaaa');</script>");
        }

        protected void btnAceptarLogin_Click(object sender, EventArgs e)
        {
                var cn = new Conexion();
            
            try
            {
                if (cn.buscarUsuario(txtUsuarioLogin.Text, txtClaveLogin.Text)==true)
                {
                    Response.Redirect("Usuarios.aspx");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>console.log('Error de Usuario o Contraseña');</script>");
            }
        }
    }
}
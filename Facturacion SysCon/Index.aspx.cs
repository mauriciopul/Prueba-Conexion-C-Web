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

    }
}
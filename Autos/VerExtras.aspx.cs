using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Autos
{
    public partial class VerExtras : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonComprar_Click(object sender, EventArgs e)
        {
            String idCliente = Request.QueryString["Valor"];
            String idSucursal = Request.QueryString["Valor1"];
            String idAutomovil = Request.QueryString["Valor2"];
            Response.Redirect("ComprarCarro.aspx?Valor=" + idCliente + "Valor1=" + idSucursal + "Valor2=" + idAutomovil);
        }
    }
}
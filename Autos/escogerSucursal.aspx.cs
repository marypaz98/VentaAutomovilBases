using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Autos
{
    public partial class escogerSucursal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ButtonSucursal1_Click(object sender, EventArgs e)
        {
            String idCliente = Request.QueryString["Valor"];
            String idSucursal = "1"; 
            Response.Redirect("VerAutosDisponibles.aspx?Valor=" + idCliente+"Valor1="+idSucursal);
        }
        protected void ButtonSucursal2_Click(object sender, EventArgs e)
        {
            String idCliente = Request.QueryString["Valor"];
            String idSucursal = "2";
            Response.Redirect("VerAutosDisponibles.aspx?Valor=" + idCliente + "Valor1=" + idSucursal);
        }
        protected void ButtonSucursal3_Click(object sender, EventArgs e)
        {
            String idCliente = Request.QueryString["Valor"];
            String idSucursal = "3";
            Response.Redirect("VerAutosDisponibles.aspx?Valor=" + idCliente + "Valor1=" + idSucursal);
        }
    }
}
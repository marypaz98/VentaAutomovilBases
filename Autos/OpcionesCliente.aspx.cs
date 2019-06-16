using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Autos
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ButtonAutosDisponibles_Click(object sender, EventArgs e)
        {
            String idCliente = Request.QueryString["Valor"];
            Response.Redirect("EscogerSucursal.aspx?Valor=" + idCliente);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Autos
{
    public partial class VerAutosDisponibles : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String Valor = Request.QueryString["Valor1"];
            SqlDataSource1.SelectParameters["idSucursal"].DefaultValue = Valor;
        }


        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            String idCliente = Request.QueryString["Valor"];
            String idSucursal = Request.QueryString["Valor1"];
            int idAutomovil = Convert.ToInt32(GridView1.DataKeys[e.NewSelectedIndex].Value);
            int idAutomovil1 = idAutomovil + 1;
            Response.Redirect("VerExtras.aspx?Valor=" + idCliente + "Valor1=" + idSucursal + "Valor2=" + idAutomovil1);

        }
    }
}
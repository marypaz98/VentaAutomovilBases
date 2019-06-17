using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Autos
{
    public partial class Facturar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String idCliente = Request.QueryString["Valor"];
            String idSucursal = Request.QueryString["Valor1"];
            if (idSucursal == "1")
            {
                SqlDataSource1.SelectParameters["idCliente"].DefaultValue = idSucursal;
                GridView1.Visible = true;
            }
            else if (idSucursal == "2")
            {
                SqlDataSource2.SelectParameters["idCliente"].DefaultValue = idSucursal;
                GridView2.Visible = true;
            }
            else if (idSucursal == "3")
            {
                SqlDataSource3.SelectParameters["idCliente"].DefaultValue = idSucursal;
                GridView3.Visible = true;
            }

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
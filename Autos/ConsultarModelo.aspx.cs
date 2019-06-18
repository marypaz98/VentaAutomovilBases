using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Autos
{
    public partial class ConsultarModelo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String idCliente = Request.QueryString["Valor"];
            String idSucursal = Request.QueryString["Valor1"];
            String marca = TextBox1.Text;
            String anno = TextBox2.Text;
            Response.Redirect("ConsultarModelo1.aspx?Valor=" + idCliente + "&Valor1=" + idSucursal+"&Valor2="+marca+"&Valor3="+anno);
        }
    }
}
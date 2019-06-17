using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Autos
{
    public partial class OpcionesCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonAutosDisponibles_Click1(object sender, EventArgs e)
        {
            String idCliente =Request.QueryString["Valor"];
            String idSucursal = Request.QueryString["Valor1"];
            Response.Redirect("VerAutosDisponibles.aspx?Valor=" + idCliente+"Valor1="+idSucursal);
        }

        protected void ButtonConsultar_Click(object sender, EventArgs e)
        {
            String idCliente = Request.QueryString["Valor"];
            String idSucursal = Request.QueryString["Valor1"];
            Response.Redirect("ConsultarModelo.aspx?Valor=" + idCliente + "Valor1=" + idSucursal);
        }

        protected void ButtonConsignar_Click(object sender, EventArgs e)
        {
            String idCliente = Request.QueryString["Valor"];
            String idSucursal = Request.QueryString["Valor1"];
            Response.Redirect("ConsignarAutomovil.aspx?Valor=" + idCliente + "Valor1=" + idSucursal);
        }

        protected void ButtonPagarMensualidad_Click(object sender, EventArgs e)
        {
            String idCliente = Request.QueryString["Valor"];
            String idSucursal = Request.QueryString["Valor1"];
            Response.Redirect("PagarMensualidad.aspx?Valor=" + idCliente + "Valor1" + idSucursal);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String idCliente = Request.QueryString["Valor"];
            String idSucursal = Request.QueryString["Valor1"];
            Response.Redirect("Facturar.aspx?Valor=" + idCliente + "Valor1=" + idSucursal);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String idSucursal = Request.QueryString["Valor1"];
            Response.Redirect("VerInforSucursal.aspx?Valor=" + idSucursal);
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Autos
{
    public partial class venderCarro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String idCliente = TextBox1.Text;
            String idSucursal = TextBox2.Text;
            String idAutomovil = TextBox3.Text;
            Response.Redirect("ComprarCarro.aspx?Valor=" +idCliente+"&Valor1="+idSucursal+"&Valor2="+idAutomovil);
        }
    }
}
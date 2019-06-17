using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            int idAutomovilxSucursal = idAutomovil + 1;
            int idAutomovil1;
            SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-FA0O96B;Initial Catalog=Fabrica;Integrated Security=True");
            SqlCommand comando = conexion.CreateCommand();
            comando.CommandText = "selectIdAutomovil";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idAutomovilxSucursal", idAutomovilxSucursal);
            comando.Parameters.AddWithValue("@idSucursal", idSucursal);
            try
            {
                conexion.Open();
                idAutomovil1 = (int)comando.ExecuteScalar();
                conexion.Close();
                Response.Redirect("VerExtras.aspx?Valor=" + idCliente + "Valor1=" + idSucursal + "Valor2=" + idAutomovil1); Response.Redirect("escogerSucursal.aspx?Valor=" + idCliente);

            }
            catch (Exception )
            {
              //  LabelError.Visible = true;

            }
            

        }
    }
}
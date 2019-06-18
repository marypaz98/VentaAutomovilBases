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


        protected void GridView1_SelectedIndexChanged(object sender, GridViewSelectEventArgs e)
        {



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String idCliente = Request.QueryString["Valor"];
            String idSucursal = Request.QueryString["Valor1"];
            String placa = TextBox1.Text;
            int idAutomovil1;
            SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-FA0O96B;Initial Catalog=Fabrica;Integrated Security=True");
            SqlCommand comando = conexion.CreateCommand();
            comando.CommandText = "SelectIdAutomovil1";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@placa", placa);
            try
            {
                conexion.Open();
                idAutomovil1 = (int)comando.ExecuteScalar();
                Console.WriteLine("Hola");
                Console.WriteLine(idAutomovil1);
                conexion.Close();
                Response.Redirect("VerExtras.aspx?Valor=" + idCliente + "&Valor1=" + idSucursal + "&Valor2=" + idAutomovil1);


            }
            catch (Exception)
            {

                LabelError.Visible = true;


            }
        }
    }
}
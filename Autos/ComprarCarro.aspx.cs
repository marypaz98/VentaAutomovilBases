using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
namespace Autos
{
    public partial class ComprarCarro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ButtonComprar_Click(object sender, EventArgs e)
        {
            try
            {
                int idCliente = System.Convert.ToInt32(Request.QueryString["Valor"]);
                int idSucursal = System.Convert.ToInt32(Request.QueryString["Valor1"]);
                String placa = Request.QueryString["Valor2"];
                int idTipoPago = ListBox1.SelectedIndex + 1;
                SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-FA0O96B;Initial Catalog=Fabrica;Integrated Security=True");
                SqlCommand comando = conexion.CreateCommand();
                comando.CommandText = "venderCarro";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@placa", placa);
                comando.Parameters.AddWithValue("@idCliente", idCliente);
                comando.Parameters.AddWithValue("@sucursal", idSucursal);
                comando.Parameters.AddWithValue("@idTipoPago", idTipoPago);
                if (ListBox2.SelectedIndex == 1 && IsNumeric(TextBox1.Text))
                {
                    int plazo = System.Convert.ToInt32(TextBox1.Text);
                    comando.Parameters.AddWithValue("@financiamiento", 1);
                    comando.Parameters.AddWithValue("plazo", plazo);
                }
                else
                {
                    comando.Parameters.AddWithValue("@financiamiento", 0);
                }
            }
            catch (Exception)
            {
                Label2.Visible = true;
            }

        }

        protected void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBox2.SelectedIndex == 1)
            {
                Label1.Visible = true;
                TextBox1.Visible = true;
            }
        }
        private bool IsNumeric(string num)
        {
            try
            {
                double x = Convert.ToDouble(num);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
       
    }
}
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
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonAceptar_Click(object sender, EventArgs e)
        {

                guardarDatos(TextUsuario.Text,TextContrasenna.Text);
           
        }
        protected void guardarDatos(string usuario, string contrasenna)
        {
            SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-FA0O96B;Initial Catalog=Fabrica;Integrated Security=True");
            SqlCommand comando = conexion.CreateCommand();
            comando.CommandText = "sp_validarEntradaAbonado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@contrasenna", contrasenna);
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
             //   string Valor = TextUsuario.Text;
             //   Response.Redirect("OpcCliente.aspx?Valor=" + Valor);

            }
            catch (Exception e)
            {
                LabelError.Visible = true;

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
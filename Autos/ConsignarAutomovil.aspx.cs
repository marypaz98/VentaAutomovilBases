using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Autos
{
    public partial class ConsignarAutomovil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int idCliente = System.Convert.ToInt32(Request.QueryString["Valor"]);
            int idSucursal = System.Convert.ToInt32(Request.QueryString["Valor1"]);
            int idTipoAutomovil = System.Convert.ToInt32(TextBox1.Text);
            int idTipoCombustible = System.Convert.ToInt32(TextBox2.Text);
            String placa = TextBox3.Text;
            Double precioBase = System.Convert.ToDouble(TextBox4.Text);
            int anno = System.Convert.ToInt32(TextBox5.Text);
            String color = TextBox6.Text;
            String marca = TextBox7.Text;
            int cantidadPasajeros = System.Convert.ToInt32(TextBox8.Text);
            int nPuertas = System.Convert.ToInt32(TextBox9.Text);
            SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-FA0O96B;Initial Catalog=Fabrica;Integrated Security=True");
            SqlCommand comando = conexion.CreateCommand();
            comando.CommandText = "sp_ConsignarCarro";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idSucursal",idSucursal);
            comando.Parameters.AddWithValue("@dTipoAutomovil", idTipoAutomovil);
            comando.Parameters.AddWithValue("@idTipoCombustible", idTipoAutomovil);
            comando.Parameters.AddWithValue("@placa", placa);
            comando.Parameters.AddWithValue("@precioBase", precioBase);
            comando.Parameters.AddWithValue("@anno", anno);
            comando.Parameters.AddWithValue("@color", color);
            comando.Parameters.AddWithValue("@marca", marca);
            comando.Parameters.AddWithValue("@cantidadPasajeros", cantidadPasajeros);
            comando.Parameters.AddWithValue("@nPuertas", nPuertas);
            comando.Parameters.AddWithValue("@idCliente", idCliente);
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
                Label1.Text = "Carro consignado con exito";
                Label1.Visible = true;
            }
            catch (Exception)
            {
                Label1.Text = "Se produjo un error al agregar el carro";
                Label1.Visible = true;
            }

        }
    }
}
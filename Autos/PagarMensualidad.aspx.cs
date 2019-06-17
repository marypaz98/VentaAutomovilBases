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
    public partial class PagarMensualidad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //String Valor = Request.QueryString["Valor1"];
            //SqlDataSource1.SelectParameters["idSucursal"].DefaultValue = Valor;
        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }

        protected void ButtonPagar_Click(object sender, EventArgs e)
        {
            String idCliente = Request.QueryString["Valor"];
            String idSucursal = Request.QueryString["Valor1"];
            int idAutomovil, idFinanciamiento;
            SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-FA0O96B;Initial Catalog=Fabrica;Integrated Security=True");
            SqlCommand comando = conexion.CreateCommand();
            comando.CommandText = "SelectIdAutomovil1";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@placa", TextBox2.Text);
            try
            {
                conexion.Open();
                idAutomovil = (int)comando.ExecuteScalar();
                conexion.Close();
                SqlConnection conexion1 = new SqlConnection(@"Data Source=DESKTOP-FA0O96B;Initial Catalog=Fabrica;Integrated Security=True");
                SqlCommand comando1 = conexion1.CreateCommand();
                comando1.CommandText = "obtenerFinaciamiento";
                comando1.CommandType = CommandType.StoredProcedure;
                comando1.Parameters.AddWithValue("@idSucursal", System.Convert.ToInt32(idSucursal));
                comando1.Parameters.AddWithValue("@idAutomovil", idAutomovil);
                comando1.Parameters.AddWithValue("@idCliente", System.Convert.ToInt32(idCliente));
                try
                {
                    conexion1.Open();
                    idFinanciamiento = (int)comando1.ExecuteScalar();
                    conexion1.Close();
                    if (idSucursal == "1")
                    {
                        SqlConnection conexion2 = new SqlConnection(@"Data Source=DESKTOP-FA0O96B;Initial Catalog=Sucursal_1;Integrated Security=True");
                        SqlCommand comando2 = conexion2.CreateCommand();
                        comando2.CommandText = "pagarMensualidad";
                        comando2.CommandType = CommandType.StoredProcedure;
                        comando2.Parameters.AddWithValue("@idFinanciamiento", idFinanciamiento);
                        comando2.Parameters.AddWithValue("@idAutomovil", idAutomovil);
                        comando2.Parameters.AddWithValue("@idCliente", System.Convert.ToInt32(idCliente));
                        comando2.Parameters.AddWithValue("@monto", TextBox1.Text);
                        try
                        {
                            conexion2.Open();
                            String msj = (String)comando2.ExecuteScalar();
                            conexion1.Close();
                            LabelError.Text = msj;
                            LabelError.Visible = true;
                        }
                        catch (Exception)
                        {
                            LabelError.Text = "Ha ocurrido un error";
                            LabelError.Visible = true;
                        }
                    }
                    else if (idSucursal == "2")
                    {
                        SqlConnection conexion2 = new SqlConnection(@"Data Source=DESKTOP-FA0O96B;Initial Catalog=Sucursal_2;Integrated Security=True");
                        SqlCommand comando2 = conexion2.CreateCommand();
                        comando2.CommandText = "pagarMensualidad";
                        comando2.CommandType = CommandType.StoredProcedure;
                        comando2.Parameters.AddWithValue("@idFinanciamiento", idFinanciamiento);
                        comando2.Parameters.AddWithValue("@idAutomovil", idAutomovil);
                        comando2.Parameters.AddWithValue("@idCliente", System.Convert.ToInt32(idCliente));
                        comando2.Parameters.AddWithValue("@monto", TextBox1.Text);
                        try
                        {
                            conexion2.Open();
                            String msj = (String)comando2.ExecuteScalar();
                            conexion1.Close();
                            LabelError.Text = msj;
                            LabelError.Visible = true;
                        }
                        catch (Exception)
                        {
                            LabelError.Text = "Ha ocurrido un error";

                        }
                    }
                    else if (idSucursal == "3")
                    {
                        SqlConnection conexion2 = new SqlConnection(@"Data Source=DESKTOP-FA0O96B;Initial Catalog=Sucursal_2;Integrated Security=True");
                        SqlCommand comando2 = conexion2.CreateCommand();
                        comando2.CommandText = "pagarMensualidad";
                        comando2.CommandType = CommandType.StoredProcedure;
                        comando2.Parameters.AddWithValue("@idFinanciamiento", idFinanciamiento);
                        comando2.Parameters.AddWithValue("@idAutomovil", idAutomovil);
                        comando2.Parameters.AddWithValue("@idCliente", System.Convert.ToInt32(idCliente));
                        comando2.Parameters.AddWithValue("@monto", TextBox1.Text);
                        try
                        {
                            conexion2.Open();
                            String msj = (String)comando2.ExecuteScalar();
                            conexion1.Close();
                            LabelError.Text = msj;
                            LabelError.Visible = true;
                        }
                        catch (Exception)
                        {
                            LabelError.Text = "Ha ocurrido un error";

                        }

                    }
                    // Response.Redirect("escogerSucursal.aspx?Valor=" + idCliente);

                }
                catch (Exception)
                {
                    LabelError.Text = "Ha ocurrido un error";
                    LabelError.Visible = true;

                }



            }
            catch (Exception)
            {
                LabelError.Text = "Ha ocurrido un error";
                LabelError.Visible = true;
            }
        }
    }
}
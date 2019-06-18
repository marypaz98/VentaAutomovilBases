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
    public partial class ConsultarModelo1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String idCliente = Request.QueryString["Valor"];
            String idSucursal = Request.QueryString["Valor1"];
            String marca = Request.QueryString["Valor2"];
            String anno = Request.QueryString["Valor3"];
            String s;
            SqlConnection conexion;
            DataTable dt = new DataTable();
            SqlCommand comando;
            if (idSucursal == "1") {
                 conexion = new SqlConnection(@"Data Source=DESKTOP-FA0O96B;Initial Catalog=Sucursal_1;Integrated Security=True");
                comando = conexion.CreateCommand();
                Label1.Text = "Sucursal 1";
                    Label1.Visible = true; }
            else if (idSucursal == "2")
            {
                conexion = new SqlConnection(@"Data Source=DESKTOP-FA0O96B;Initial Catalog=Sucursal_2;Integrated Security=True");
                comando = conexion.CreateCommand();
                Label1.Text = "Sucursal 2";
                Label1.Visible = true;
            }
            else
            {
                conexion = new SqlConnection(@"Data Source=DESKTOP-FA0O96B;Initial Catalog=Sucursal_3;Integrated Security=True");
                comando = conexion.CreateCommand();
                Label1.Text = "Sucursal 3";
                Label1.Visible = true;
            }
            comando.CommandText = "consultarModelo";
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@marca", marca);
            comando.Parameters.AddWithValue("@anno", System.Convert.ToInt32(anno));
            comando.Parameters.AddWithValue("@idCliente", System.Convert.ToInt32(idCliente));
            try
            {
                
                conexion.Open();
                s = (String)comando.ExecuteScalar();
                conexion.Close();
                if (s == "1")
                {
                    Label1.Text = "1";
                    Label1.Visible = true;
                    comando.CommandText = "consultarCarros";
                    comando.CommandType = System.Data.CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@marca", marca);
                    comando.Parameters.AddWithValue("@año", anno);
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    try
                    {
                        conexion.Open();
                        da.Fill(dt);
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                    finally
                    {
                        if ( conexion.State == ConnectionState.Open)
                            conexion.Close();
                    }
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                    GridView1.Visible = true;
                }
                else if (s == "-1")
                {
                    Button1.Visible = true;
                    Label2.Visible = true;
                    TextBox1.Visible = true;
                }
                else
                {
                    Label1.Text = s;
                    Label1.Visible = true;
                }

            }
            catch(Exception)
            {
            //    Label1.Text = "Ha ocurrido un error con la conexion a la base datos";
              //  Label1.Visible = true;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String idCliente = Request.QueryString["Valor"];
            String idSucursal = Request.QueryString["Valor1"];
            SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-FA0O96B;Initial Catalog=Fabrica;Integrated Security=True");
            SqlCommand comando = conexion.CreateCommand();
            if (idSucursal == "1")
            {
                comando.CommandText = "realizarPedidoSucursal1";
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idSucursal", System.Convert.ToInt32(idSucursal));
                comando.Parameters.AddWithValue("@idAutomovil", System.Convert.ToInt32(TextBox1.Text));
                comando.Parameters.AddWithValue("@idCliente", System.Convert.ToInt32(idCliente));
                try
                {
                    conexion.Open();
                    conexion.Close();
                    Label1.Text = "Pedido realizado de manera exitosa";
                    Label1.ForeColor = System.Drawing.Color.Blue;
                    Label1.Visible = true;
                }
                catch (Exception)
                {
                    Label1.Text = "Ha ocurrido un error con la conexion  a la base de datos";
                    Label1.Visible = true;
                }
            }
            else if (idSucursal == "2")
            {
                comando.CommandText = "realizarPedidoSucursal2";
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idSucursal", System.Convert.ToInt32(idSucursal));
                comando.Parameters.AddWithValue("@idAutomovil", System.Convert.ToInt32(TextBox1.Text));
                comando.Parameters.AddWithValue("@idCliente", System.Convert.ToInt32(idCliente));
                try
                {
                    conexion.Open();
                    conexion.Close();
                    Label1.Text = "Pedido realizado de manera exitosa";
                    Label1.ForeColor = System.Drawing.Color.Blue;
                    Label1.Visible = true;
                }
                catch (Exception)
                {
                    Label1.Text = "Ha ocurrido un error con la conexion  a la base de datos";
                    Label1.Visible = true;
                }
            }
            else
            {
                comando.CommandText = "realizarPedidoSucursal3";
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idSucursal", System.Convert.ToInt32(idSucursal));
                comando.Parameters.AddWithValue("@idAutomovil", System.Convert.ToInt32(TextBox1.Text));
                comando.Parameters.AddWithValue("@idCliente", System.Convert.ToInt32(idCliente));
                try
                {
                    conexion.Open();
                    conexion.Close();
                    Label1.Text = "Pedido realizado de manera exitosa";
                    Label1.ForeColor = System.Drawing.Color.Blue;
                    Label1.Visible = true;
                }
                catch (Exception)
                {
                    Label1.Text = "Ha ocurrido un error con la conexion  a la base de datos";
                    Label1.Visible = true;
                }
            }
            //Response.Redirect("PediFabrica.aspx?Valor="+idCliente + "Valor1="+idSucursal+"Valor2="+TextBox1.Text);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Autos
{
    public partial class AgregarExtras : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String idCliente = Request.QueryString["Valor"];
            String idSucursal = Request.QueryString["Valor1"];
            int idAutomovil = System.Convert.ToInt32(Request.QueryString["Valor2"]);
            Response.Redirect("ComprarCarro.aspx?Valor=" + idCliente + "&Valor1=" + idSucursal + "&Valor2=" + idAutomovil);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TextBox1.Text)|| !string.IsNullOrEmpty(TextBox2.Text) || !string.IsNullOrEmpty(TextBox3.Text) || !string.IsNullOrEmpty(TextBox4.Text))
            {
                // If so, loop through all checked items and print results.  
                String idCliente = Request.QueryString["Valor"];
                String idSucursal = Request.QueryString["Valor1"];
                int idAutomovil = System.Convert.ToInt32(Request.QueryString["Valor2"]);
                string s = "";
                SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-FA0O96B;Initial Catalog=Fabrica;Integrated Security=True");
                SqlCommand comando = conexion.CreateCommand();
                if ((TextBox1.Text) != "")
                {
                    comando.CommandText = "spAgregarExtraxAutomovil";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@idAutomovil", idAutomovil);
                    comando.Parameters.AddWithValue("@idExra", System.Convert.ToInt32(TextBox1.Text));
                    try
                    {
                        conexion.Open();
                        s = (String)comando.ExecuteScalar();
                        conexion.Close();
                       // Response.Redirect("ComprarCarro.aspx?Valor=" + idCliente + "&Valor1=" + idSucursal + "&Valor2=" + idAutomovil);


                    }
                    catch (Exception)
                    {
                        Label1.Text = "Ha ocurrido un error";
                        Label1.Visible = true;
                        //  LabelError.Visible = true;

                    }
                }
                if (TextBox2.Text != "")
                {
                    comando.CommandText = "spAgregarExtraxAutomovil";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@idAutomovil", idAutomovil);
                    comando.Parameters.AddWithValue("@idExra", System.Convert.ToInt32(TextBox1.Text));
                    try
                    {
                        conexion.Open();
                        s = (String)comando.ExecuteScalar();
                        conexion.Close();
                        // Response.Redirect("ComprarCarro.aspx?Valor=" + idCliente + "&Valor1=" + idSucursal + "&Valor2=" + idAutomovil);


                    }
                    catch (Exception)
                    {
                        Label1.Text = "Ha ocurrido un error";
                        Label1.Visible = true;
                        //  LabelError.Visible = true;

                    }
                }
                if (TextBox3.Text != "")
                {
                    comando.CommandText = "spAgregarExtraxAutomovil";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@idAutomovil", idAutomovil);
                    comando.Parameters.AddWithValue("@idExra", System.Convert.ToInt32(TextBox1.Text));
                    try
                    {
                        conexion.Open();
                        s = (String)comando.ExecuteScalar();
                        conexion.Close();
                        // Response.Redirect("ComprarCarro.aspx?Valor=" + idCliente + "&Valor1=" + idSucursal + "&Valor2=" + idAutomovil);


                    }
                    catch (Exception)
                    {
                        Label1.Text = "Ha ocurrido un error";
                        Label1.Visible = true;
                        //  LabelError.Visible = true;

                    }
                }
                if (TextBox4.Text != "")
                {
                    comando.CommandText = "spAgregarExtraxAutomovil";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@idAutomovil", idAutomovil);
                    comando.Parameters.AddWithValue("@idExra", System.Convert.ToInt32(TextBox1.Text));
                    try
                    {
                        conexion.Open();
                        s = (String)comando.ExecuteScalar();
                        conexion.Close();
                        // Response.Redirect("ComprarCarro.aspx?Valor=" + idCliente + "&Valor1=" + idSucursal + "&Valor2=" + idAutomovil);


                    }
                    catch (Exception)
                    {
                        Label1.Text = "Ha ocurrido un error";
                        Label1.Visible = true;
                        //  LabelError.Visible = true;

                    }
                }



                //  s = s + "Checked Item " + (x + 1).ToString() + " = " + checkedListBox1.CheckedItems[x].ToString() + "\n";

                //  MessageBox.Show(s);

                Response.Redirect("ComprarCarro.aspx?Valor=" + idCliente + "&Valor1=" + idSucursal + "&Valor2=" + idAutomovil);
            }
            else
            {
                Label1.Text = "Debe marcar por lo menos un extra";
                Label1.Visible = true;
            }
        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

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

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (CheckBoxList1.Items.Count != 0)
            {
                // If so, loop through all checked items and print results.  
                String idCliente = Request.QueryString["Valor"];
                String idSucursal = Request.QueryString["Valor1"];
                int idAutomovil = System.Convert.ToInt32(Request.QueryString["Valor2"]);
                string s = "";
                SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-FA0O96B;Initial Catalog=Fabrica;Integrated Security=True");
                SqlCommand comando = conexion.CreateCommand();
                for (int x = 0; x < CheckBoxList1.Items.Count; x++)
                {
                    comando.CommandText = "spAgregarExtraxAutomovil";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@idAutomovil", idAutomovil);
                    comando.Parameters.AddWithValue("@idExtra", x + 1);

                    //  s = s + "Checked Item " + (x + 1).ToString() + " = " + checkedListBox1.CheckedItems[x].ToString() + "\n";
                }
                //  MessageBox.Show(s);
                try
                {
                    conexion.Open();
                    s = (String)comando.ExecuteScalar();
                    conexion.Close();
                    if( s == "1"){
                        Response.Redirect("ComprarCarro.aspx?Valor=" + idCliente + "Valor1=" + idSucursal + "Valor2=" + idAutomovil);
                    }
                    else
                    {
                        Label1.Text = s;
                        Label1.Visible = true;
                    }
                    
                    //Response.Redirect("escogerSucursal.aspx?Valor=" + idCliente);

                }
                catch (Exception )
                {
                    Label1.Text = "Ha ocurrido un error";
                    Label1.Visible = true;
                    //  LabelError.Visible = true;

                }

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

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
    public partial class registrarse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonRegistrarse_Click(object sender, EventArgs e)
        {
            String nombre, apellido1, apellido2, usuario, contrasenna, ubicacion, msj;
            int edad, cedula;
            nombre = TextBoxUbicacion.Text;
            apellido1 = TextBoxApellido1.Text;
            apellido2 = TextBoxApellido2.Text;
            usuario = TextBoxUsuario.Text;
            contrasenna = TextBoxContrasenna.Text;
            ubicacion = TextBoxUbicacion.Text;
            edad = System.Convert.ToInt32(TextBoxEdad.Text);
            cedula = System.Convert.ToInt32(TextBoxCedula.Text);
            SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-FA0O96B;Initial Catalog=Fabrica;Integrated Security=True");
            SqlCommand comando = conexion.CreateCommand();
            comando.CommandText = "registrarUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@contrasenna", contrasenna);
            comando.Parameters.AddWithValue("@ubicacion",ubicacion);
            comando.Parameters.AddWithValue("@nombre",nombre);
            comando.Parameters.AddWithValue("@apellido1", apellido1);
            comando.Parameters.AddWithValue("@apellido2", apellido2);
            comando.Parameters.AddWithValue("@cedula", cedula);
            comando.Parameters.AddWithValue("@edad", edad);
            try
            {
                conexion.Open();
                msj = (String)comando.ExecuteScalar();
                conexion.Close();
                Label1.Text = msj;
                //Response.Redirect("escogerSucursal.aspx?Valor=" + idCliente);

            }
            catch (Exception )
            {
                Label1.Text = "Ha ocurrido un problema con la conexión a la base de datos";
               // LabelError.Visible = true;

            }



        }
    }
}
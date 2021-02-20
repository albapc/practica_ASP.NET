using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Prueba
{
    public partial class UsuariosAlta : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string nombre = TextBox1.Text;
            string usuario = TextBox2.Text;
            string password = TextBox3.Text;
            string email = TextBox4.Text;
            string direccion = TextBox5.Text;
            string ciudad = TextBox6.Text;
            string conexion = ConfigurationManager.ConnectionStrings["conexionUsuarios"].ConnectionString;

            //SqlConnection con = new SqlConnection("Data Source=PLX00135100911\\SQLEXPRESS;Database=AdventureWorksLT2017;Integrated Security=SSPI;Trusted_Connection=true;");
            SqlConnection con = new SqlConnection(conexion);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO SalesLT.Usuarios (nombre, usuario, password, email, direccion, ciudad) VALUES(@param1,@param2,@param3,@param4,@param5,@param6)";

            cmd.Parameters.AddWithValue("@param1", nombre);
            cmd.Parameters.AddWithValue("@param2", usuario);
            cmd.Parameters.AddWithValue("@param3", password);
            cmd.Parameters.AddWithValue("@param4", email);
            cmd.Parameters.AddWithValue("@param5", direccion);
            cmd.Parameters.AddWithValue("@param6", ciudad);

            cmd.ExecuteNonQuery();
            con.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListaUsuarios.aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Prueba
{
    public partial class View : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetData();
            }
        }

        private void GetData()
        {
            SqlDataReader dr;
            string conexion = ConfigurationManager.ConnectionStrings["conexionUsuarios"].ConnectionString;
            using (SqlConnection con = new SqlConnection(conexion))
            {
                con.Open();
                // replace with your query
                using (SqlCommand cmd = new SqlCommand($"SELECT nombre, usuario, email, direccion, ciudad FROM SalesLT.Usuarios WHERE ID={Request["id"]}", con))
                {
                    dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    if (dr.Read())
                    {
                        Nombre.Text = dr["nombre"].ToString();
                        Usuario.Text = dr["usuario"].ToString();
                        Email.Text = dr["email"].ToString();
                        Direccion.Text = dr["direccion"].ToString();
                        Ciudad.Text = dr["ciudad"].ToString();
                    }
                }
            }
        }
    }
}
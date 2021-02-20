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
    public partial class ListaUsuarios : System.Web.UI.Page
    {

        SqlDataReader dr;
        string conexion = ConfigurationManager.ConnectionStrings["conexionUsuarios"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetData();
            }
        }


        private void GetData()
        {

            using (SqlConnection con = new SqlConnection(conexion))
            {
                con.Open();
                // replace with your query
                using (SqlCommand cmd = new SqlCommand("SELECT ID, nombre, usuario, email, direccion, ciudad FROM SalesLT.Usuarios", con))
                {
                    dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    GridView1.DataSource = dr;
                    GridView1.DataBind();
                }
            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(conexion);

            foreach (GridViewRow gvrow in GridView1.Rows)
            {

                CheckBox chck = gvrow.FindControl("CheckBox1") as CheckBox;
                if (chck.Checked)
                {
                    var valor = gvrow.Cells[0].Text;

                    SqlCommand cmd = new SqlCommand("delete from SalesLT.Usuarios where ID=@id", con);
                    cmd.Parameters.AddWithValue("ID", int.Parse(valor));
                    con.Open();
                    int id = cmd.ExecuteNonQuery();
                    con.Close();
                    GetData();
                }
            }
        }
    }
}

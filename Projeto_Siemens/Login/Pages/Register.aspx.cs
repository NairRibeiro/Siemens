using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient; //Adicionado
using System.Configuration; //Adicionado

public partial class Pages_Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringRegisto"].ConnectionString);
            conn.Open();
            string insertquery = "insert into[Users]([User], Email, Password) values(@user, @email, @password)";
            SqlCommand con = new SqlCommand(insertquery, conn);
            con.Parameters.AddWithValue("@user", TextBoxUtilizador.Text);
            con.Parameters.AddWithValue("@email", TextBoxEmail.Text);
            con.Parameters.AddWithValue("@password", TextBoxPass.Text);
            con.ExecuteNonQuery();
            //Response.Redirect("Gestor.aspx");
            Response.Write("Sucessso");
            conn.Close();
            TextBoxUtilizador.Text = string.Empty;
            TextBoxEmail.Text = string.Empty;
            TextBoxPass.Text = string.Empty;
            TextBoxPassVer.Text = string.Empty;
        }
        catch (Exception ex)
        {
            Response.Write("Erro:" + ex.ToString());
        }
    }
}
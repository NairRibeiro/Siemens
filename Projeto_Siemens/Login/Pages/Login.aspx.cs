using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class Pages_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBoxUser.Text = string.Empty;
        TextBoxPass.Text = string.Empty;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            SqlDataSource sds = new SqlDataSource();
            sds.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionStringRegisto"].ToString();
            sds.SelectParameters.Add("utilizador", TypeCode.String, TextBoxUser.Text);
            sds.SelectParameters.Add("password", TypeCode.String, TextBoxPass.Text);
            sds.SelectCommand = "SELECT * FROM [Users] WHERE [User] = @utilizador COLLATE SQL_Latin1_General_CP1_CS_AS AND [Password] = @password COLLATE SQL_Latin1_General_CP1_CS_AS";
            DataView dv = (DataView)sds.Select(DataSourceSelectArguments.Empty);

            String uti1 = TextBoxUser.Text;
            String password1 = TextBoxPass.Text;
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringRegisto"].ToString());
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM [Users] WHERE [User] = @utilizador1 COLLATE SQL_Latin1_General_CP1_CS_AS AND [Password] = @password1 COLLATE SQL_Latin1_General_CP1_CS_AS", connection);
            sqlCmd.Parameters.Add(new SqlParameter("@utilizador1", uti1));
            sqlCmd.Parameters.Add(new SqlParameter("@password1", password1));
            connection.Open();
            SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCmd);
            sqlDa.Fill(dt);         // Quando existe vai buscar dados do user 

            try
            {
                if (dv.Count == 0)
                {
                    Response.Write("Utilizador ou Password Errados");
                    TextBoxUser.Text = "";
                    TextBoxPass.Text = "";
                }
                else
                {
                    //Response.Write("Utilizador Existe");
                    connection.Close();
                    Session["SessaoUtilizador"] = TextBoxUser.Text;
                    Session["SessaoUtilizadorID"] = dt.Rows[0]["Id"].ToString(); //Pode ser em vez de .Rows .Count >0
                    //Response.Cookies["CookieUtilizador"].Value = TextBoxPass.Text;
                    //Response.Cookies["CookieUtilizador"].Expires = DateTime.Now.AddMinutes(1);
                    Response.Redirect("~/Pages/Personal.aspx");
                }
            }
            catch (Exception ex)
            {
                Response.Write("Erro:" + ex.ToString());

            }
        }
        catch
        {
            Response.Write("Erro na ligação" );
        }
    }
}
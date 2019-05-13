using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient; //Adicionado
using System.Configuration;  //Adicionado
using System.Data;  //Adicionado

public partial class BackOffice_BackLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlDataSource sds = new SqlDataSource();
        sds.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionStringRegisto"].ToString();
        sds.SelectParameters.Add("utilizador", TypeCode.String, TextBox1.Text);
        sds.SelectParameters.Add("password", TypeCode.String, TextBox2.Text);
        sds.SelectCommand = "SELECT * FROM [Users] WHERE [User] = @utilizador COLLATE SQL_Latin1_General_CP1_CS_AS AND [Password] = @password COLLATE SQL_Latin1_General_CP1_CS_AS AND [Admin] = 'S'";
        DataView dv = (DataView)sds.Select(DataSourceSelectArguments.Empty);
        //vai verificar os registos utilizador e password

        String uti1 = TextBox1.Text;
        String password1 = TextBox2.Text;
        DataTable dt = new DataTable();
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringRegisto"].ToString());
        SqlCommand sqlCmd = new SqlCommand("SELECT * FROM [Users] WHERE [User] = @utilizador1 COLLATE SQL_Latin1_General_CP1_CS_AS AND [Password] = @password1 COLLATE SQL_Latin1_General_CP1_CS_AS", connection);
        sqlCmd.Parameters.Add(new SqlParameter("@utilizador1", uti1));
        sqlCmd.Parameters.Add(new SqlParameter("@password1", password1));
        connection.Open();
        SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCmd);
        sqlDa.Fill(dt);

        try
        {
            if (dv.Count == 0) // Se nenhum registo coincidir 
            {
                Response.Write("Utilizador ou Password Errados");
                TextBox1.Text = "";
                TextBox2.Text = ""; //Usar função como feita "limpar dados()" projecto anterior
            } //Fazer + if´s para confirmar se é por que não é [Admin] ou não está [Active]
            else
            {
                connection.Close();
                //Response.Write("Utilizador Extiste")
                Session["SessaoAdministrador"] = TextBox1.Text;
                Session["SessaoAdministradorID"] = dt.Rows[0]["Id"].ToString();
                //Response.Cookies["CookieAdministrador"].Value = TextBox2.Text;
                //Response.Cookies["CookieAdministrador"].Expires = DateTime.Now.AddMinutes(1);
                Response.Redirect("Gestor.aspx");

            }
        }
        catch (Exception ex)
        {
            Response.Write("ERRO:" + ex.ToString());
        }
    }
}
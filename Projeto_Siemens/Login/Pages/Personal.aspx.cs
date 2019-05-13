using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient; //Adicionado
using System.Configuration; //Adicionado
using System.Data; //Adicionado

public partial class Pages_Personal : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {

            if (Session["SessaoUtilizador"] != null)
            {
                Label1.Text += Session["SessaoUtilizador"].ToString();
                Label2.Text += Session["SessaoUtilizadorID"].ToString(); //Vai estar visilibe = false

            }
            else
            {
                Response.Redirect("Login.aspx");
            }

            LinkButton4.Attributes["OnClick"] = "return confirm('Tem a certeza que quer atualizar os seus dados?')"; //dar hipotese ao utilizador de verificar se quer realmente atualizar os dados 


            //string test;
            //try
            //{
            //    test = Request.Cookies["CookieUtilizador"].Value;
            //}
            //catch (NullReferenceException)
            //{
            //    test = string.Empty;
            //}
            //if (!string.IsNullOrEmpty(test)) // ! se nao estiver vazio
            //{
            //    Label2.Text += test;
            //}
        }
    }

    protected void LinkButton1_Click(object sender, EventArgs e) //Logout
    {
        Session["SessaoUtilizador"] = null; // sair da sessao
        Response.Redirect("Login.aspx");
    }

    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        LinkButton3.Enabled = true; //possivel de editar
        LinkButton4.Enabled = true;
        String LID = Label2.Text;
        DataTable dt = new DataTable();
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringRegisto"].ToString());
        SqlCommand sqlCmd = new SqlCommand("SELECT * FROM [Users] WHERE [Id] = @LID", connection);
        sqlCmd.Parameters.Add(new SqlParameter("@LID", LID));
        connection.Open();
        SqlDataReader reader = sqlCmd.ExecuteReader();
        try
        {
            if (reader.Read())
            {
                TextBox1.Enabled = false;
                TextBox2.Enabled = false;
                TextBox1.Text = reader["User"].ToString();
                TextBox2.Text = reader["Email"].ToString();
                reader.Close();
                connection.Close();
            }
            else
            {
                Label2.Visible = true;
                Label2.Text = "Foi Impossível Carregar Dados";
            }
        }
        catch (Exception ex)
        {
            Response.Write("Erro:" + ex.ToString());
        }
    }

    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false; // fechar o painel 
        LinkButton3.Enabled = false;
        LinkButton4.Enabled = false;
    }

    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        try
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringRegisto"].ConnectionString);
            conn.Open(); //abrir conexão
            string insertquery = " Update [Users] SET [User] = @uti, Email = @mail Where Id = @ID ";
            SqlCommand Con = new SqlCommand(insertquery, conn);
            Con.Parameters.AddWithValue("@uti", TextBox1.Text);
            Con.Parameters.AddWithValue("@mail", TextBox2.Text);
            Con.Parameters.AddWithValue("@ID", Label2.Text);
            Con.ExecuteNonQuery(); //executar
            conn.Close(); //fechar conexão 
            TextBox1.Enabled = false; // colocar a cizento
            TextBox2.Enabled = false;


        }
        catch (Exception ex)
        {
            Response.Write("ERRO:" + ex.ToString());
        }
    }

    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        TextBox1.Enabled = true; // colocar a branco para editar
        TextBox2.Enabled = true;
        LinkButton3.Enabled = true;
        LinkButton3.Visible = true;
    }
}
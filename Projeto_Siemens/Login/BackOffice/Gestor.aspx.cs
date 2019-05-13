using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient; 
using System.Configuration; 
using System.Data; 

public partial class BackOffice_Gestor : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {

            if (Session["SessaoAdministrador"] != null)
            {
                Label1.Text += Session["SessaoAdministrador"].ToString();
                Label2.Text += Session["SessaoAdministradorID"].ToString();
            }
            else
            {
                Response.Redirect("BackLogin.aspx");
            
            }
            //LinkButton4.Attributes["OnClick"] = "return confirm('Tem a certeza que quer atualizar os seus dados?')";
        }
    }

    protected void LinkButton1_Click(object sender, EventArgs e) //Logout
    {
        Session["SessaoAdministrador"] = null;
        Response.Redirect("BackLogin.aspx");
    }

    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        LinkButton3.Enabled = true; //possivel de editar
        LinkButton4.Enabled = true;
        String LDI = Label2.Text;
        DataTable dt = new DataTable();
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringRegisto"].ToString());
        SqlCommand sqlCmd = new SqlCommand("SELECT * FROM [Users] WHERE [Id] = @LDI ", connection);
        sqlCmd.Parameters.Add(new SqlParameter("@Ldi", LDI));
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

    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        TextBox1.Enabled = true;    //colocar a branco para editar
        TextBox2.Enabled = true;
        LinkButton3.Enabled = true;
        LinkButton3.Visible = true;
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

    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false; // fechar o painel 
        LinkButton3.Enabled = false;
        LinkButton4.Enabled = false;
    }
}
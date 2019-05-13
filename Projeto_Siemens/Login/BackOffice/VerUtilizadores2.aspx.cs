using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

public partial class BackOffice_VerUtilizadores2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            DataTable dt = Dados();
            StringBuilder tabela = new StringBuilder();
            tabela.Append("<style type='text/css'>.TFtable{width:70%;border-collapse:collapse;}.TFtable td{padding:5px;border:#4e95f4 1px solid;}.TFtable tr{background: #b8d1f3;}.TFtable tr:nth - child(odd){background:#b8d1f3;}.TFtable tr:nth - child(even){background: #dae5f4;}</style>");
            tabela.Append("<table border='1px' cellpadding='0' cellspacing='0' class='TFtable' style='fontfamily:Arial; font-size:small;'>");
            tabela.Append("<tr valign='top'>");

            //Adiciona Cabeçalhos      
            tabela.Append("<tr>");
                foreach (DataColumn coluna in dt.Columns)
                {
                    tabela.Append("<th>");
                    tabela.Append(coluna.ColumnName);
                    tabela.Append("</th>");
            }

            tabela.Append("</tr>");

            //Adiciona os dados      
            foreach (DataRow linha in dt.Rows)
            {
                tabela.Append("<tr>");

                foreach (DataColumn coluna in dt.Columns)
                {
                    tabela.Append("<td>");
                    tabela.Append(linha[coluna.ColumnName]);
                    tabela.Append("</td>");
                }

                tabela.Append("</tr>");
            }

            //Fim Tabela             
            tabela.Append("</table>");

            //Adiciona a Tabela ao Placeholder             
            PlaceHolder1.Controls.Add(new Literal { Text = tabela.ToString() });

            }
        }

    private DataTable Dados()
    {
        string conexao = ConfigurationManager.ConnectionStrings["ConnectionStringRegisto"].ConnectionString;

        using (SqlConnection conn = new SqlConnection(conexao))
        {
            using (SqlCommand comando = new SqlCommand("SELECT * FROM [Users] "))
            {
                using (SqlDataAdapter adaptadorSQL = new SqlDataAdapter())
                {
                    comando.Connection = conn; adaptadorSQL.SelectCommand = comando;

                    using (DataTable tabela = new DataTable())
                    {
                        adaptadorSQL.Fill(tabela);
                        return tabela;
                    }
                 }
             }
         }
     }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class BackOffice_VerUtilizadores : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LinkButton2_Click(object sender, EventArgs e) //LogOut
    {
        Session["SessaoAdministrador"] = null;
        Response.Redirect("Gestor.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        FormView1.ChangeMode(FormViewMode.Insert);
    }

    protected void FormView1_ItemDeleted(object sender, FormViewDeletedEventArgs e)
    {
        // ligar a formviw à gridview
        GridView1.DataBind();
    }

    protected void FormView1_ItemInserted(object sender, FormViewInsertedEventArgs e)
    {
        GridView1.DataBind();
    }

    protected void FormView1_ItemUpdated(object sender, FormViewUpdatedEventArgs e)
    {
        GridView1.DataBind();
    }
}


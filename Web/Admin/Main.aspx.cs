using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca;

public partial class Admin_Main : System.Web.UI.Page
{
    private ListaJugador ListaJugador
    {
        get
        {
            return (ListaJugador)Session["ListaJugadorSession"];
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["ListaJugadorSession"] == null)
        {
            Response.Redirect("/Inicio.aspx");
        }
        else
        {
            gvUsers.DataSource = ListaJugador;
            gvUsers.DataBind();

        }
    }





    protected void gvUsers_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName.CompareTo("Eliminar") == 0)
        {
            try
            {
                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = gvUsers.Rows[index];

                ListItem item = new ListItem();
                item.Text = Server.HtmlDecode(row.Cells[1].Text);

                string nick = item.Text;
                ListaJugador.Eliminar(ListaJugador, nick);
                Response.AppendHeader("Refresh", "0");
            }
            catch (Exception)
            {

            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca;
public partial class Inicio : System.Web.UI.Page
{
    private Jugador Jugador
    {
        get
        {
            return (Jugador)Session["JugadorSession"];
        }

    }
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            // para cuando carga el login sin datos por usar un atras del navegador
            if (Jugador.Id == 0)
            {
                Session["JugadorSession"] = null;
                Response.AppendHeader("Refresh", "0");
            }
        }
        catch (Exception)
        {

        }


        if (Jugador != null)
        {
            pnlUser.Visible = true;
            pnlLogin.Visible = false;
            lblUser.Text = string.Format("Bienvenido, {0}  ", Jugador.Nickname);

        }
        if (Jugador == null)
        {
            pnlUser.Visible = false;
            pnlLogin.Visible = true;
            lblUser.Text = string.Empty;
        }
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if (Jugador == null)
        {
            Response.Redirect("User/Login.aspx");

        }

    }

    protected void btnRegistrar_Click(object sender, EventArgs e)
    {
        if (Jugador == null)
        {
            Response.Redirect("User/Registro.aspx");

        }
    }

    protected void btnCerrarSesion_Click(object sender, EventArgs e)
    {
        Session["JugadorSession"] = null;
        Response.AppendHeader("Refresh", "0");
    }

    protected void btnPerfil_Click(object sender, EventArgs e)
    {
        if (Jugador != null)
        {
            Response.Redirect("User/Perfil.aspx");

        }
    }
}
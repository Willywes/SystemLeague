using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca;
using System.Threading;

public partial class User_Login : System.Web.UI.Page
{
    private ListaJugador ListaJugador
    {
        get
        {
            return (ListaJugador)Session["ListaJugadorSession"];
        }
    }
    private Jugador Jugador
    {
        get
        {
            if (Session["JugadorSession"] == null)
            {
                Session["JugadorSession"] = new Jugador();
            }
            return (Jugador)Session["JugadorSession"];
        }
        set
        {
            Session["JugadorSession"] = value;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Jugador != null && Jugador.Id != 0) //Mejorar esta shit
        {
            Response.Redirect("/Inicio.aspx");
        }
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        try
        {

            if (Session["ListaJugadorSession"] == null)
            {
                throw new ArgumentException("No existen usuarios registrados");
            }
            string user = txtUsuario.Text;
            string pass = txtPass.Text;

            if (ListaJugador.ComprobarNick(ListaJugador, user))
            {
                Jugador = ListaJugador.CargarJugador(ListaJugador,user);
                
                if (Jugador.Contrasena.Equals(pass))
                {
                    lblOuput.Text = "Bienvenido, Redirigiendo al inicio";
                    Response.Redirect("/Inicio.aspx");
                }
                else
                {
                    Jugador = null;
                    throw new ArgumentException("La contraseña no coincide");
                    
                }
            }
            else
            {
                throw new ArgumentException("El usuario no existe");
            }

        }
        catch (Exception ex)
        {
            lblOuput.Text = ex.Message;
        }
    }
}
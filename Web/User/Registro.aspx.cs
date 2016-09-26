using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca;
using System.Threading;

public partial class User_Registro : System.Web.UI.Page
{
    

    private Jugador Jugador
    {
        get
        {
            return (Jugador)Session["JugadorSession"];
        }

    }
    private ListaJugador ListaJugador
    {
        get
        {
            if (Session["ListaJugadorSession"] == null)
            {
                Session["ListaJugadorSession"] = new ListaJugador();
            }
            return (ListaJugador)Session["ListaJugadorSession"];
        }
        set
        {
            Session["ListaJugadorSession"] = value;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Jugador != null)
        {
            Response.Redirect("/Inicio.aspx");
        }
    }
    private int generarId(DateTime time)
    {
        int c = ListaJugador.count++;
        return int.Parse(c + time.ToString("HHmmss"));
    }

    protected void btnRegistrar_Click(object sender, EventArgs e)
    {
        try
        {
            if (ListaJugador != null)
            {
                if (ListaJugador.ComprobarNick(ListaJugador, txtUsuario.Text))
                {
                    throw new ArgumentException("El Nombre de usuario ya existe\nIntente con otro diferente");
                }
            }
            Jugador j = new Jugador();

            j.FechaRegistro = DateTime.Now;
            j.Id = generarId(j.FechaRegistro);
            j.Nickname = txtUsuario.Text;
            j.Contrasena = txtPass.Text;
            j.Mail = txtMail.Text;
            j.FechaRegistro = DateTime.Now;


            ListaJugador.Add(j);

            lblOuput.Text = string.Format("Jugador {0}, registrado con éxito", j.Nickname);
            Response.Redirect("/Inicio.aspx");
        }
        catch (Exception ex)
        {
            lblOuput.Text = ex.Message;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca;
using System.Threading;
using Biblioteca.Negocio;

public partial class User_Registro : System.Web.UI.Page
{

    PlayerColeccion playerColeccion = new PlayerColeccion();


    private Player Jugador
    {
        get
        {
            return (Player)Session["JugadorSession"];
        }

    }
    private PlayerColeccion ListaJugador
    {
        get
        {
            if (Session["ListaJugadorSession"] == null)
            {
                Session["ListaJugadorSession"] = new PlayerColeccion();
            }
            return (PlayerColeccion)Session["ListaJugadorSession"];
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
        //int c = ListaJugador.count++;
        return int.Parse(time.ToString("HHmmss"));
    }

    protected void btnRegistrar_Click(object sender, EventArgs e)
    {
        try
        {
            if (playerColeccion != null)
            {
                if (playerColeccion.ComprobarNick(txtUsuario.Text))
                {
                    throw new ArgumentException("El Nombre de usuario ya existe\nIntente con otro diferente");
                }
            }

            if (!txtPass.Text.Equals(txtPass2.Text))
            {
                throw new ArgumentException("Las contraseñas no coinciden");
            }

            if (!txtMail.Text.Equals(txtMail2.Text))
            {
                throw new ArgumentException("Las mail no coinciden");
            }

            Player player = new Player();            

            player.FechaRegistro = DateTime.Now;
            player.Id = generarId(player.FechaRegistro);
            player.Nick = txtUsuario.Text;
            player.Pass = txtPass.Text;
            player.Email = txtMail.Text;

            player.Create();

            lblOuput.Text = string.Format("Jugador {0}, registrado con éxito", player.Nick);
            Response.Redirect("/Inicio.aspx");
        }
        catch (Exception ex)
        {
            lblOuput.Text = ex.Message;
        }
    }
}
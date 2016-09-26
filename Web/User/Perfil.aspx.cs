using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Biblioteca;

public partial class User_Perfil : System.Web.UI.Page
{

    private Jugador Jugador
    {
        get
        {
            return (Jugador)Session["JugadorSession"];
        }
        set
        {
            Session["JugadorSession"] = value;
        }

    }

    private ListaJugador ListaJugador
    {
        get
        {
            return (ListaJugador)Session["ListaJugadorSession"];
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Jugador == null)
        {
            Response.Redirect("/User/Login.aspx");
        }
        lblFecharegistro.Text = Jugador.FechaRegistro.ToString();
        lblUsuario.Text = Jugador.Nickname;
        lblMail.Text = Jugador.Mail;

    }

    protected void btnModificar_Click(object sender, EventArgs e)
    {
        pnlModificable.Visible = true;
        pnlPerfil.Visible = false;

        txtUsuario.Text = Jugador.Nickname;
        txtMail.Text = Jugador.Mail;
        txtPass.Text = Jugador.Contrasena;
    }

    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        try
        {
            if (ListaJugador.ComprobarNick(ListaJugador, Jugador.Nickname))
            {
                // eliminamos el usuario de la lista
                if (ListaJugador.Eliminar(ListaJugador, Jugador.Nickname))
                {
                    // comprobamos si se repite el usuario en la lista, para no utilizar el nombre de otro ya registrado
                    if (ListaJugador.ComprobarNick(ListaJugador, txtUsuario.Text))
                    {
                        throw new ArgumentException("Este nombre de usuario ya esta siendo utlizado");
                    }
                }

            }

            Jugador j = Jugador; // pasamos la sesion a un nuevo jugador

            j.Nickname = txtUsuario.Text;
            j.Contrasena = txtPass.Text;
            j.Mail = txtMail.Text;

            ListaJugador.Add(j); // lo devolvemos a la lista

            if (!ListaJugador.Modificar(ListaJugador, j.Nickname, j.Contrasena, j.Mail))
            {
                throw new ArgumentException("Error no se puede modifical el usuario.");
            }
            
            //ListaJugador.Add(j); // lo devolvemos a la lista
            Jugador = j; // devolvemos la actualizacion a la session


            pnlModificable.Visible = false;
            pnlPerfil.Visible = true;
            Response.AppendHeader("Refresh", "0");
        }
        catch (Exception ex)
        {

            lblOuput.Text = ex.Message;
        }


    }

    
}
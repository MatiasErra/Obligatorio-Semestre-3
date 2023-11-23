using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ObligatirioSemes3.Presentacion
{
    public partial class IniciarSesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIniciar_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;
            ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
          if(Web.IniciarSesion(user, pass) != 0)
            {
                lblMensajes.Text = "Inicio de sesion exitoso";
                System.Web.HttpContext.Current.Session["userSesion"] = user;
                System.Web.HttpContext.Current.Session["IdSesion"] = Web.IniciarSesion(user, pass);
                Response.Redirect("~/Presentacion/FoldCli/HomeCli.aspx");



            }
          else if(Web.IniciarSesionA(user, pass))
            {
                lblMensajes.Text = "Inicio de sesion Existoso";
                Response.Redirect("~/Presentacion/frmReparacion");
            }

          else
            {
                lblMensajes.Text = "No se pudo iniciar sesion";
            }

        }

        protected void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Presentacion/regCliente");
        }
    }
}
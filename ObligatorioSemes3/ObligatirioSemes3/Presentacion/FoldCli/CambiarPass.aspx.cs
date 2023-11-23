using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using ObligatirioSemes3.Dominio;
using System.Web.UI.WebControls;

namespace ObligatirioSemes3.Presentacion.FoldCli
{
    public partial class CambiarPass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtUser.Text = (string)System.Web.HttpContext.Current.Session["userSesion"];
        }


        private void limpiar()
        {


         
            txtPass.Text = "";



        }

        private bool faltanDatos()
        {
            if (txtUser.Text == ""|| txtPass.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        protected void btnAlta_Click(object sender, EventArgs e)
        {
            if (!faltanDatos())
            {
                ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
                Cliente cliente = new Cliente();

               int id = (int)System.Web.HttpContext.Current.Session["IdSesion"];
        
               string pass = txtPass.Text;
                if (Web.CambiarPass(id, pass))
                {
                    lblMensajes.Text = "Contseña cambiada con exito.";

                    limpiar();
                }
                else
                {
                    lblMensajes.Text = "No se pudo cambiar la Contraseña";
                    limpiar();
                }
            }
            else
            {
                lblMensajes.Text = "Faltan Datos";
            }
        }
    }
}
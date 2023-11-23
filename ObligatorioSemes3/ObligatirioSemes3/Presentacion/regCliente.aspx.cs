using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ObligatirioSemes3.Dominio;

namespace ObligatirioSemes3.Presentacion
{
    public partial class regCliente : System.Web.UI.Page
    {

        #region
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
   
   

        private void limpiar()
        {
          
            txtCi.Text = "";
            txtApe.Text = "";
           txtDireccion.Text = "";
         
            txtNombre.Text = "";
          txtPass.Text = "";
         txtUser.Text = "";
            txtMail.Text = "";
            txtTel.Text = "";

        }

        private void CargarCli (int id)
        {
            ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
          Cliente lstCli = Web.BuscarCli(id);
     
            txtNombre.Text = lstCli.Nombre.ToString();
            txtApe.Text = lstCli.Apellido.ToString();
            txtUser.Text = lstCli.User.ToString();
            txtPass.Text = lstCli.Password.ToString();
            txtCi.Text = lstCli.Ci.ToString();
            txtMail.Text = lstCli.Mail.ToString();
       
            txtDireccion.Text = lstCli.Dir.ToString();
            txtTel.Text = lstCli.Tel.ToString();
      
        }

   
          private bool faltanDatos()
        {
            if ( txtCi.Text == "" || txtApe.Text == "" || txtDireccion.Text == "" ||  txtNombre.Text == "" 
                || txtUser.Text == "" || txtPass.Text == "" || txtMail.Text == "" | txtTel.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
        protected void btnAlta_Click(object sender, EventArgs e)
        {
             if (!faltanDatos())
           {

                ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
                Cliente cliente = new Cliente();
                cliente.Nombre = txtNombre.Text;
                cliente.Apellido = txtApe.Text;
                cliente.User = txtUser.Text;
                cliente.Password = txtPass.Text;
                cliente.Dir = txtDireccion.Text;
                cliente.Ci = Convert.ToInt16(txtCi.Text);
                cliente.Tel = Convert.ToInt16(txtTel.Text);
                cliente.Mail = txtMail.Text;
      
            string Dir = txtDireccion.Text;

           

     
                if (Web.AltaCliente(cliente))
                {
                    lblMensajes.Text = " Cliente dado de alta con exito.";
                  
                    limpiar();
                }
                else
                {
                    lblMensajes.Text = "No se pudo dar de alta el Cliente";
                    limpiar();
                }
           
                
                }
            else
            {
                lblMensajes.Text = "Faltan Datos";
            }
     
        
        }

 
        protected void btnLimpiar_Click(object sender, EventArgs e)
        {

        }


    }
}
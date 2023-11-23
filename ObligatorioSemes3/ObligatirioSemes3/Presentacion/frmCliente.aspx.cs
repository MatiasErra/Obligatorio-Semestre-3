using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ObligatirioSemes3.Dominio;

namespace ObligatirioSemes3.Presentacion
{
    public partial class abmCliente : System.Web.UI.Page
    {
        #region
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void lstCliente_Init(object sender, EventArgs e)
        {
            listar();
        }
        private void listar()
        {

            ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
            lstCliente.DataSource = null;
            lstCliente.DataSource = Web.lstClientes();
            lstCliente.DataBind();
        }

        private void limpiar()
        {

            txtCi.Text = "";
            txtApe.Text = "";
            txtDireccion.Text = "";
            txtFecha.Text = "";
            txtNombre.Text = "";
            txtPass.Text = "";
            txtUser.Text = "";
            txtMail.Text = "";
            txtTel.Text = "";

        }

        private void CargarCli(int id)
        {
            ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
            Cliente lstCli = Web.BuscarCli(id);

            txtNombre.Text = lstCli.Nombre.ToString();
            txtApe.Text = lstCli.Apellido.ToString();
            txtUser.Text = lstCli.User.ToString();
            txtPass.Text = lstCli.Password.ToString();
            txtCi.Text = lstCli.Ci.ToString();
            txtMail.Text = lstCli.Mail.ToString();
            txtFecha.Text = lstCli.FchRegistro.ToString();
            txtDireccion.Text = lstCli.Dir.ToString();
            txtTel.Text = lstCli.Tel.ToString();

        }


        private bool faltanDatos()
        {
            if (txtCi.Text == "" || txtApe.Text == "" || txtDireccion.Text == "" || txtFecha.Text == "" || txtNombre.Text == ""
                || txtUser.Text == "" || txtPass.Text == "" || txtMail.Text == "" | txtTel.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool faltaIdCli()
        {
            if (lstCliente.SelectedIndex == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private int TraerCli()
        {


            if (this.lstCliente.SelectedValue != null)
            {
                ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
                string CliSt = this.lstCliente.SelectedItem.ToString();
                string[] CliArr = CliSt.Split(' ');
                int Id = Convert.ToInt16(CliArr[0]);
                Cliente rep = Web.BuscarCli(Id);
                if (rep != null)
                {
                    return Id;

                }
                else
                {
                    return 0;

                }
            }

            else
            {
                return 0;

            }



        }

        #endregion

        protected void btnAlta_Click(object sender, EventArgs e)
        {
            if (!faltanDatos())
            {

                string nombre = txtNombre.Text;
                string apellido = txtApe.Text;
                string user = txtUser.Text;
                string pass = txtPass.Text;
                int ci = Convert.ToInt16(txtCi.Text);
                int tel = Convert.ToInt16(txtTel.Text);
                string mail = txtMail.Text;
                string Fech = txtFecha.Text;
                string Dir = txtDireccion.Text;



                ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
                Cliente cliente = new Cliente(nombre, apellido, pass, user, ci, tel, mail, Fech, Dir);
                if (Web.AltaCliente(cliente))
                {
                    lblMensajes.Text = "Admin dado de alta con exito.";
                    listar();
                    limpiar();
                }
                else
                {
                    lblMensajes.Text = "No se pudo dar de alta el Administrador";
                    limpiar();
                }


            }
            else
            {
                lblMensajes.Text = "Faltan Datos";
            }

        }

        protected void btnBaja_Click(object sender, EventArgs e)
        {
            if (!faltaIdCli())
            {

                ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
                int Id = TraerCli();

                if (Web.BajaCliente(Id))
                {
                    lblMensajes.Text = "Cliente eliminado con exito.";
                   listar();
                    limpiar();
                }
                else
                {
                    lblMensajes.Text = "No se pudo eliminar el Cliente";
                    limpiar();
                }
            }
            else
            {
                lblMensajes.Text = "Faltan selecionar un Cliente de la lista";

            }
        }
    

        protected void btnMod_Click(object sender, EventArgs e)
        {
            if (!faltanDatos())
            {
                Cliente cli = new Cliente();
                ControladoraWeb Web = ControladoraWeb.obtenerInstancia();

                cli.Id = TraerCli();
                cli.Nombre = txtNombre.Text;
                cli.Apellido = txtApe.Text;
                cli.User = txtUser.Text;
                cli.Password = txtPass.Text;
                cli.Ci = Convert.ToInt32(txtCi.Text);
                cli.Tel = Convert.ToInt32(txtTel.Text);
                cli.Mail = txtMail.Text;
                cli.FchRegistro = txtFecha.Text;
                cli.Dir = txtDireccion.Text;
            


                if (Web.ModCliente((cli)))
                {
                    lblMensajes.Text = "Reparacion modificada con exito.";
                    listar();
                    limpiar();

                }
                else
                {
                    lblMensajes.Text = "No se pudo modificar el Vehiculo";
                    limpiar();
                }




            }
            else
            {
                lblMensajes.Text = "Faltan Datos";
            }
        }
    

        protected void btnSelect_Click(object sender, EventArgs e)
        {
            if (this.lstCliente.SelectedIndex > -1)
            {
                string linea = this.lstCliente.SelectedItem.ToString();
                string[] partes = linea.Split(' ');
                short id = Convert.ToInt16(partes[0]);
                this.CargarCli(id);
         
            }
            else
            {
                this.lblMensajes.Text = "Debe seleccionar un cliente de la lista.";

          
            }
        }
    }
}
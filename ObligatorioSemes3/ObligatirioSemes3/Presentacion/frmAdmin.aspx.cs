using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ObligatirioSemes3.Dominio;

namespace ObligatirioSemes3.Presentacion
{
    public partial class frmAdmin : System.Web.UI.Page
    {

        #region
        private void listar()
        {

            ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
            lstAdmin.DataSource = null;
            lstAdmin.DataSource = Web.lstAdmin();
            lstAdmin.DataBind();
        }

        private void limpiar()
        {
          
            txtNombre.Text = "";
            txtApe.Text = "";
            txtPass.Text = "";
            txtUser.Text = "";

        }

            private bool faltanDatos()
        {
            if (txtNombre.Text == "" || txtApe.Text == ""  || txtUser.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void cargarAdmin(int pId)
        {

           ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
           Admin unAdmin = Web.BuscarAdmin(pId);
     
            txtNombre.Text = unAdmin.Nombre.ToString();
            txtApe.Text = unAdmin.Apellido.ToString();
            txtUser.Text = unAdmin.User.ToString();
            txtPass.Text = unAdmin.Password.ToString();
            
        }

        private int TraerAdmin()
        {


            if (this.lstAdmin.SelectedIndex != -1)
            {
                ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
                string CliSt = this.lstAdmin.SelectedItem.ToString();
                string[] CliArr = CliSt.Split(' ');
                int Id = Convert.ToInt16(CliArr[0]);
                Admin rep = Web.BuscarAdmin(Id);
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

        private bool faltaAdmin()
        {
            if (lstAdmin.SelectedIndex == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
            {

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

           

                ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
                Dominio.Admin unAdmin = new Dominio.Admin( nombre, apellido, pass, user);
                if (Web.AltaAdmin(unAdmin))
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

        protected void btnSelect_Click(object sender, EventArgs e)
        {
            {
                if (this.lstAdmin.SelectedIndex > -1)
                {
                    string linea = this.lstAdmin.SelectedItem.ToString();
                    string[] partes = linea.Split(' ');
                    short id = Convert.ToInt16(partes[0]);
                    this.cargarAdmin(id);
                    this.lstAdmin.SelectedIndex = -1;
                }
                else
                {
                    this.lblMensajes.Text = "Debe seleccionar un admin de la lista.";

                    this.lblMensajes.Text = lstAdmin.SelectedIndex.ToString() + " " + this.lstAdmin.Items[0].ToString();
                }
            }
        }

        protected void btnBaja_Click(object sender, EventArgs e)
        {
            if (!this.faltaAdmin())
            {
                ControladoraWeb Web = ControladoraWeb.obtenerInstancia();

                int id = TraerAdmin();
               string User = (string)System.Web.HttpContext.Current.Session["userSesion"];
                string Pass = (string)System.Web.HttpContext.Current.Session["Password"];
                if (User != null)
                {


                    if ((Web.IniciarSesionSA(User, Pass)))
                    {
                        if (Web.BajaAdmin(id))

                        {
                            this.listar();
                            this.limpiar();

                            this.lblMensajes.Text = "Admin eliminado con exito.";
                        }
                        else
                        {
                            this.lblMensajes.Text = "No existe Admin con este Id.";
                        }
                    }
                    else
                    {
                       lblMensajes.Text = "Error al intentar borrar el admin";
                    }
                }
                else
                {
                    this.lblMensajes.Text = "Debe iniciar sesion para poder eliminar";
                }
                    
            }
            else
                this.lblMensajes.Text = "Faltan Datos";
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            if (!faltanDatos())
            {
                ControladoraWeb Web = ControladoraWeb.obtenerInstancia();

              
                string User = (string)System.Web.HttpContext.Current.Session["userSesion"];
                string Pass = (string)System.Web.HttpContext.Current.Session["Password"];
                if (User != null)
                {


                    if ((Web.IniciarSesionSA(User, Pass)))
                    {
                        Admin admin = new Admin();

                        admin.Id = TraerAdmin();
                        admin.Nombre = this.txtNombre.Text;
                        admin.Apellido = this.txtApe.Text;
             
                        admin.User = this.txtUser.Text;


                        if (Web.ModAdmin(admin))
                        {

                            this.listar();
                            this.limpiar();

                            this.lblMensajes.Text = "Se modificaron los datos del admin";

                        }

                        else
                        {

                            this.lblMensajes.Text = "No se pudo modificar ese admin";



                        }

                    }
                    else
                    {
                        lblMensajes.Text = "Error al intentar Modificar el admin";
                    }
                }

                else
                {
                    lblMensajes.Text = "Debe iniciar sesion para poder modificar los datos";

                }
            }
            else
                this.lblMensajes.Text = "Faltan Datos";

        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        protected void lstAdmin_Init(object sender, EventArgs e)
        {
            listar();
        }

        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string user = txtUserSA.Text;
            string pass = txtPassSA.Text;
            ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
            if (Web.IniciarSesionSA(user, pass))
            {
                lblMensajes.Text = "Inicio de sesion exitoso";
                System.Web.HttpContext.Current.Session["userSesion"] = user;
                System.Web.HttpContext.Current.Session["Password"] = pass;
                lblMensajes.Text = "Sesion Iniciada como super Admin";



            }
            else
            lblMensajes.Text = "No se pudo iniciar sesion como super Admin";
        }
    }
}
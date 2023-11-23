using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ObligatirioSemes3.Dominio;


namespace ObligatirioSemes3.Presentacion
{
    public partial class frmMecanico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        #region 

        private void listar()
        {

            ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
            lstMecanico.DataSource = null;
            lstMecanico.DataSource = Web.LstMecanico();
            lstMecanico.DataBind();
        }

  

        private bool faltanDatos()
        {
            if (txtCI.Text == "" || txtTel.Text == "" || txtFechaIng.Text == "" || txtValorHora.Text == "" ||  txtNom.Text == "" || txtApe.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected void lstMecanico_Init(object sender, EventArgs e)
        {
            listar();
        }


        private bool faltaIdMecanico()
        {
            if (lstMecanico.SelectedIndex == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void cargarMec(int pId)
        {

            ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
            Dominio.Mecanico unMec = Web.BuscarMec(pId);

            txtNom.Text = unMec.Nombre.ToString();
            txtApe.Text = unMec.Apellido.ToString();
            txtCI.Text = unMec.Ci.ToString();
            txtTel.Text = unMec.Tel.ToString();
            txtFechaIng.Text = unMec.FchaIngreso.ToString();
            txtValorHora.Text = unMec.ValorHora.ToString();
   

        }
        private void limpiar()
        {
             txtNom.Text = "";
            txtApe.Text = "";
             txtCI.Text = "";
           txtTel.Text = "";
           txtFechaIng.Text = "";
        txtValorHora.Text = "";
            lstMecanico.SelectedIndex = -1;



        }

        private int TraerMec()
        {


            if (this.lstMecanico.SelectedValue != null)
            {
                ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
                string CliSt = this.lstMecanico.SelectedItem.ToString();
                string[] CliArr = CliSt.Split(' ');
                int Id = Convert.ToInt16(CliArr[0]);
                Mecanico rep = Web.BuscarMec(Id);
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
            if (!faltanDatos()) {

                ControladoraWeb web = ControladoraWeb.obtenerInstancia();
                Mecanico unMec = new Mecanico();

                unMec.Nombre = txtNom.Text;
                unMec.Apellido = txtApe.Text;
                unMec.Ci = txtCI.Text;
                unMec.Tel = txtTel.Text;
                unMec.FchaIngreso = txtFechaIng.Text;
                unMec.ValorHora = double.Parse(txtValorHora.Text);
               


                if (web.AltaMecanico(unMec))
                {
                    lblMensajes.Text = "Repuesto dado de alta con exito.";
                    listar();
                    limpiar();


                }
                else
                {
                    lblMensajes.Text = "No se pudo dar de alta el Repuesto";
              
                }
            }
            else
            {
                lblMensajes.Text = "Faltan Datos";
            }
        }

        protected void btnBaja_Click(object sender, EventArgs e)
        {
            if (!this.faltaIdMecanico())
            {
                ControladoraWeb ConWeb = ControladoraWeb.obtenerInstancia();
                int Id = TraerMec();

                if (ConWeb.BajaMecanico(Id))
                {
                    this.listar();
               

                    this.lblMensajes.Text = "Mecanico eliminado con exito.";
                    limpiar();
                }
                else
                {
                    this.lblMensajes.Text = "No existe un mecanico con este Id.";
                }
            }
            else
                this.lblMensajes.Text = "Faltan Datos";
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            if (!faltanDatos())
            {
                ControladoraWeb ConWeb = ControladoraWeb.obtenerInstancia();
                Mecanico unMec = new Mecanico();
                unMec.Id = TraerMec();
                unMec.Nombre = txtNom.Text;
                unMec.Apellido = txtApe.Text;
                unMec.Ci = txtCI.Text;
                unMec.Tel = txtTel.Text;
                unMec.FchaIngreso = txtFechaIng.Text;
                unMec.ValorHora = double.Parse(txtValorHora.Text);
        


                if (ConWeb.ModMecanico(unMec))
                {
                    this.listar();
                    

                    this.lblMensajes.Text = "Se modificaron los datos del Mecanico";
                    limpiar();
                }

                else
                {
                    this.lblMensajes.Text = "No se pudo modificar esete Mecanico";
                    this.listar();
                }
            }
            else
                this.lblMensajes.Text = "Faltan Datos";


        }
        protected void btnSelect_Click(object sender, EventArgs e)
        {
            {
                if (this.lstMecanico.SelectedIndex > -1)
                {
                    string linea = this.lstMecanico.SelectedItem.ToString();
                    string[] partes = linea.Split(' ');
                    short id = Convert.ToInt16(partes[0]);
                    this.cargarMec(id);

                }
                else
                {
                    this.lblMensajes.Text = "Debe seleccionar un repuesto de la lista.";

                    
                }
            }
        }

      
    }
    
}
    

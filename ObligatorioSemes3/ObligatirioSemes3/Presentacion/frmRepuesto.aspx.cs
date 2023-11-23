using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ObligatirioSemes3.Dominio;

namespace ObligatirioSemes3.Presentacion
{
    public partial class frmRepuesto : System.Web.UI.Page
    {


        #region
        private void listar()
        {

            ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
            lstRepues.DataSource = null;
            lstRepues.DataSource = Web.lstRepues();
            lstRepues.DataBind();
        }

        protected void lstRep_Init(object sender, EventArgs e)
        {
            listar();
        }
        private void limpiar()
        {
            txtNom.Text = "";
            txtDesc.Text = "";
            txtTipo.Text = "";
            txtCosto.Text = "";
            txtStock.Text = "";
      

        }

        private bool faltanDatos()
        {
            if ( txtCosto.Text == "" || txtDesc.Text == "" || txtTipo.Text == "" || txtNom.Text == "" || txtStock.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool faltaIdRepues()
        {
            if (lstRepues.SelectedIndex == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private int TraerRepues()
        {
            if (!faltaIdRepues())
            {
                if (this.lstRepues.SelectedValue != null)
                {
                    ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
                    string CliSt = this.lstRepues.SelectedItem.ToString();
                    string[] CliArr = CliSt.Split(' ');
                    int Id = Convert.ToInt16(CliArr[0]);
                    Repuesto repu = Web.BuscarRepues(Id);
                    if (repu != null)
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
            else
            {
                lblMensajes.Text = "Faltan Datos";
                return 0;
            }
            

        }



        private void cargarRep(int pId)
        {

            ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
            Dominio.Repuesto unRep = Web.BuscarRepues(pId);
            
            txtCosto.Text = unRep.Costo.ToString();
            txtDesc.Text = unRep.Desc.ToString();
            txtTipo.Text = unRep.Tipo.ToString();
            txtNom.Text = unRep.Nombre.ToString();
            txtStock.Text = unRep.Stock.ToString();


        
            


        }

        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAlta_Click(object sender, EventArgs e)
        {
            if (!faltanDatos())
            {
                ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
                Repuesto unRep = new Repuesto();

                unRep.Nombre = txtNom.Text;
                unRep.Desc = txtDesc.Text;
                unRep.Costo = Convert.ToInt16(txtCosto.Text);
                unRep.Tipo = txtTipo.Text;
                unRep.Stock = txtStock.Text;
        
                if (Web.AltaRepues(unRep))
                {
                    lblMensajes.Text = "Repuesto dado de alta con exito.";
                    listar();
                    limpiar();
                }
                else
                {
                    lblMensajes.Text = "No se pudo dar de alta el Repuesto";
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
            if (!this.faltaIdRepues())
            {
                ControladoraWeb ConWeb = ControladoraWeb.obtenerInstancia();

                int id = TraerRepues();
                if (ConWeb.BajaRepues(id))
                {
                    this.listar();
                    this.limpiar();

                    this.lblMensajes.Text = "Repuesto eliminado con exito.";
                }
                else
                {
                    this.lblMensajes.Text = "No existe Repuesto con este Id.";
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
                Repuesto unRep = new Repuesto();
                unRep.Nombre = txtNom.Text;
                unRep.Id = TraerRepues();
                unRep.Desc = txtDesc.Text;
                unRep.Costo = Convert.ToInt16(txtCosto.Text);
                unRep.Tipo = txtTipo.Text;
                unRep.Stock = txtStock.Text;


                if (ConWeb.ModRepues(unRep))
                {
                    this.listar();
                    this.limpiar();

                    this.lblMensajes.Text = "Se modificaron los datos del Repuesto";
                }

                else
                {
                    this.lblMensajes.Text = "No se pudo modificar esete Repuesto";
                    this.listar();
                }
            }
            else
                this.lblMensajes.Text = "Faltan Datos";
        }

        protected void btnSelect_Click(object sender, EventArgs e)
        {
            {
                if (this.lstRepues.SelectedIndex > -1)
                {
                    string linea = this.lstRepues.SelectedItem.ToString();
                    string[] partes = linea.Split(' ');
                    short id = Convert.ToInt16(partes[0]);
                    this.cargarRep(id);

                }
                else
                {
                    this.lblMensajes.Text = "Debe seleccionar un repuesto de la lista.";

                    this.lblMensajes.Text = lstRepues.SelectedIndex.ToString() + " " + this.lstRepues.Items[0].ToString();
                }
            }
        }

     
    }
}
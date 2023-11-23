using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ObligatirioSemes3.Presentacion
{
    public partial class Estadisticas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void limpiar()
        {

            txtFchI.Text = "";
            txtFchF.Text = "";
  

        }

        private bool faltanDatos()
        {
            if (txtFchI.Text == "" || txtFchF.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void listar(string FechaI, string FechaF)
        {

            ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
            LstRep.DataSource = null;
            LstRep.DataSource = Web.LstReparRepDadoFch(FechaI, FechaF);
            LstRep.DataBind();
        }


        protected void LstRep_Init(object sender, EventArgs e)
        {
            ControladoraWeb Web = new ControladoraWeb();
            LstRep.DataSource = null;
            LstRep.DataSource = Web.LstReparReparadas();
            LstRep.DataBind();
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (!faltanDatos())
            {
                string FechaI = txtFchI.Text;
                string FechaF = txtFchF.Text;
                ControladoraWeb Web = new ControladoraWeb();
                if (Web.LstReparRepDadoFch(FechaI, FechaF) != null)
                {
                    listar(FechaI, FechaF);
                    limpiar();
    
                }
                else
                {
                    lblMensajes.Text = "No se encontraron reparaciones con esas fechas";
                }

            }
            else
            {
                lblMensajes.Text = "Faltan datos";
            }



        }

        protected void lstRepuesto_Init(object sender, EventArgs e)
        {
            ControladoraWeb Web = new ControladoraWeb();
            lstRepuesto.DataSource = null;
            lstRepuesto.DataSource = Web.LstRepuesto_ORD();
            lstRepuesto.DataBind();
        }

        protected void lstCant_Init(object sender, EventArgs e)
        {
            ControladoraWeb Web = new ControladoraWeb();
            lstCant.DataSource = null;
            lstCant.DataSource = Web.CantRepuesto();
            lstCant.DataBind();


        }
    }
}
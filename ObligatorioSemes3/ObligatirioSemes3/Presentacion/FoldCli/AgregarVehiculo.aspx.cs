using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ObligatirioSemes3.Dominio;

namespace ObligatirioSemes3.Presentacion.FoldCli
{
    public partial class frmVehiculo1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        #region
    

        private void limpiar()
        {

            txtAnio.Text = "";
            txtMat.Text = "";
            txtMdel.Text = "";
            txtMar.Text = "";
            txtColor.Text = "";




        }

        private bool faltanDatos()
        {
            if (txtAnio.Text == "" || txtMat.Text == "" || txtMar.Text == "" || txtMdel.Text == "" || txtColor.Text == "" )
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


                Vehiculo veh = new Vehiculo();
                ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
                var obj = System.Web.HttpContext.Current.Session["IdSesion"];
                int id = (int)obj;
                veh.Matricula = txtMat.Text;
                veh.Marca = txtMar.Text;
                veh.Modelo = txtMdel.Text;
                veh.Año = txtAnio.Text;
                veh.Color = txtColor.Text;
                veh.Cli = Web.BuscarCli(id);


                if (Web.AltaVehiculos(veh))
                {
                    lblMensajes.Text = "Vehiculo dado de alta con exito.";
                    
                    limpiar();
                }
                else
                {
                    lblMensajes.Text = "No se pudo dar de alta el Vehiculo";
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
            limpiar();

        }

    
    }

}


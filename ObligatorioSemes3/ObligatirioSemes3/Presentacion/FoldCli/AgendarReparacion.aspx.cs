using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using ObligatirioSemes3.Dominio;
using System.Web.UI.WebControls;


namespace ObligatirioSemes3.Presentacion.FoldCli
{
    public partial class AgendarReparacion : System.Web.UI.Page
    {

  
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void limpiar()
        {

            
            txtFechaReservada.Text = "";
            lstVeh.SelectedIndex = -1;



        }

        private bool faltanDatos()
        {
            if (txtFechaReservada.Text == "" || lstVeh.SelectedIndex == -1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private Vehiculo TraerVeh()
        {
            if (!faltanDatos())
            {

                if (this.lstVeh.SelectedValue != null)
                {
                    ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
                    string CliSt = this.lstVeh.SelectedItem.ToString();
                    string[] CliArr = CliSt.Split(' ');
                    int Id = Convert.ToInt16(CliArr[0]);
                    Vehiculo veh = Web.BuscarVeh(Id);
                    if (veh != null)
                    {
                        return veh;

                    }
                    else
                    {
                        return null;

                    }
                }

                else
                {
                    return null;

                }

            }
            else
            {
                lblMensajes.Text = "Faltan Datos";
                return null;
            }
        }



        protected void btnAlta_Click(object sender, EventArgs e)
        {
            if (!faltanDatos())
            {
                Reparacion rep = new Reparacion();
                ControladoraWeb Web = ControladoraWeb.obtenerInstancia();

                rep.FchaReservada = txtFechaReservada.Text;
                rep.Vehiculo = TraerVeh();


                if (Web.UniqueVehRes(rep.Vehiculo.IdVehiculo, rep.FchaReservada))
                {

                    if (Web.AltaReparCli(rep))
                    {
                        lblMensajes.Text = "Reparacion Agendada con exito.";

                        limpiar();
                    }
                    else
                    {
                        lblMensajes.Text = "No se pudo agendar la Reparacion";
                        limpiar();
                    }
                }
                else
                {
                    lblMensajes.Text = "Ya existe una fecha reservada para ese vehiculo";
                }

            }
            else
            {
                lblMensajes.Text = "Faltan Datos";
            }
        }

        protected void lstVeh_Init(object sender, EventArgs e)
        {
            ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
           
            lstVeh.DataSource = null;
            var obj = System.Web.HttpContext.Current.Session["IdSesion"];
            int id = (int)obj;
            lstVeh.DataSource = Web.BuscarVehLst(id);
            lstVeh.DataBind();
        }

        protected void lstVehRepar_Init(object sender, EventArgs e)
        {
            ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
            lstVehRepar.DataSource = null;
            var obj = System.Web.HttpContext.Current.Session["IdSesion"];
            int id = (int)obj;
            lstVehRepar.DataSource = Web.LstVehRepRepar(id);
            lstVehRepar.DataBind();
        }
    }
}
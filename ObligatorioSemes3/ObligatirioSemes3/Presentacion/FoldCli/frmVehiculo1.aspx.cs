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

        protected void lstCli_Init(object sender, EventArgs e)
        {
            ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
            lstCli.DataSource = null;
            lstCli.DataSource = Web.lstClientes();
            lstCli.DataBind();
        }
        #region
        private void listar()
        {

            ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
            lstVeh.DataSource = null;
            lstVeh.DataSource = Web.LstVehiculos();
            lstVeh.DataBind();

        }

        private void limpiar()
        {

            txtAnio.Text = "";
            txtMat.Text = "";
            txtMdel.Text = "";
            txtMar.Text = "";
            txtColor.Text = "";
            lstCli.SelectedIndex = -1;
            lstVeh.SelectedIndex = -1;



        }

        private bool faltanDatos()
        {
            if (txtAnio.Text == "" || txtMat.Text == "" || txtMar.Text == "" || txtMdel.Text == "" || txtColor.Text == "" || lstCli.SelectedIndex == -1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        private bool faltaIdVeh()
        {
            if (lstVeh.SelectedIndex == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private Cliente TraerCli()
        {
            if (!faltanDatos())
            {

                if (this.lstCli.SelectedValue != null)
                {
                    ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
                    string CliSt = this.lstCli.SelectedItem.ToString();
                    string[] CliArr = CliSt.Split(' ');
                    int Id = Convert.ToInt16(CliArr[0]);
                    Cliente cli = Web.BuscarCli(Id);
                    if (cli != null)
                    {
                        return cli;

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

        private int TraerVeh()
        {
            if (!faltaIdVeh())
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
                lblMensajes.Text = "Faltan selecionar un Vehiculo";
                return 0;
            }
        }

        private void CargarVeh(int id)
        {
            ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
            Vehiculo Veh = Web.BuscarVeh(id);

            txtMat.Text = Veh.Matricula.ToString();
            txtMar.Text = Veh.Marca.ToString();
            txtMdel.Text = Veh.Modelo.ToString();
            txtAnio.Text = Veh.Año.ToString();
            txtColor.Text = Veh.Color.ToString();

            Cliente cliente = Web.BuscarCli(Veh.Cli.Id);
            lstCli.SelectedValue = cliente.ToString();



        }


        #endregion

        protected void btnAlta_Click(object sender, EventArgs e)
        {
            if (!faltanDatos())
            {
                Vehiculo veh = new Vehiculo();
                veh.Matricula = txtMat.Text;
                veh.Marca = txtMar.Text;
                veh.Modelo = txtMdel.Text;
                veh.Año = txtAnio.Text;
                veh.Color = txtColor.Text;
                veh.Cli = TraerCli();
                ControladoraWeb Web = ControladoraWeb.obtenerInstancia();

                if (Web.AltaVehiculos(veh))
                {
                    lblMensajes.Text = "Vehiculo dado de alta con exito.";
                    listar();
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

        protected void btnSelect_Click(object sender, EventArgs e)
        {
            {
                if (this.lstVeh.SelectedIndex > -1)
                {
                    string linea = this.lstVeh.SelectedItem.ToString();
                    string[] partes = linea.Split(' ');
                    short id = Convert.ToInt16(partes[0]);
                    this.CargarVeh(id);

                }
                else
                {
                    this.lblMensajes.Text = "Debe seleccionar un vehiculo de la lista.";


                }
            }
        }

        protected void lstVeh_Init(object sender, EventArgs e)
        {
            listar();
        }

        protected void btnModificarCli_Click(object sender, EventArgs e)
        {
            if (!faltanDatos())
            {
                Vehiculo veh = new Vehiculo();
                ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
                veh.IdVehiculo = TraerVeh();
                veh.Matricula = txtMat.Text;
                veh.Marca = txtMar.Text;
                veh.Modelo = txtMdel.Text;
                veh.Año = txtAnio.Text;
                veh.Color = txtColor.Text;
                veh.Cli = TraerCli();


                if (Web.ModVehiculo((veh)))
                {
                    lblMensajes.Text = "Vehiculo modificado con exito.";
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

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();

        }

        protected void btnBajaCli_Click(object sender, EventArgs e)
        {
            if (!faltaIdVeh())
            {
                Vehiculo veh = new Vehiculo();
                ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
                int Id = TraerVeh();

                if (Web.BajaVehiculo(Id))
                {
                    lblMensajes.Text = "Vehiculo eliminado con exito.";
                    listar();
                    limpiar();
                }
                else
                {
                    lblMensajes.Text = "No se pudo eliminar el Vehiculo";
                    limpiar();
                }
            }
            else
            {
                lblMensajes.Text = "Faltan selecionar un Vehiculo de la lista";

            }

        }
    }

}


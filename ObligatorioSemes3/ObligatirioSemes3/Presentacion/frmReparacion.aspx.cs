using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using ObligatirioSemes3.Dominio;
using System.Web.UI.WebControls;

namespace ObligatirioSemes3.Presentacion
{
    public partial class frmReparacion : System.Web.UI.Page
    {
        private static List<Repuesto> _listaRepuAdd = new List<Repuesto>();
        private static List<string> _cantidad = new List<string>();


        public List<Repuesto> ListaRepuAdd()
        {
            return _listaRepuAdd;
        }

        public List<string> ListarCant()
        {
            return _cantidad;
        }


        protected void Page_Load(object sender, EventArgs e)
        {

        }


        #region

        protected void lstRepar_Init(object sender, EventArgs e)
        {
            listarRepar();
        }


        protected void lstVeh_Init(object sender, EventArgs e)
        {
            listarVeh();
        }

        protected void lstMec_Init(object sender, EventArgs e)
        {
            listarMec();
        }


        protected void lstRepuesto_Init(object sender, EventArgs e)
        {
            listarRepuesto();
        }
        private void listarVeh()
        {
            ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
            lstVeh.DataSource = null;
            lstVeh.DataSource = Web.LstVehiculos();
            lstVeh.DataBind();

        }
        private void listarMec()
        {
            ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
            lstMec.DataSource = null;
            lstMec.DataSource = Web.LstMecanico();
            lstMec.DataBind();

        }

        private void listarRepuesto()
        {
            ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
            lstRepuesto.DataSource = null;
            lstRepuesto.DataSource = Web.lstRepues();
            lstRepuesto.DataBind();

        }


        private void listarReparacion_Rep(int id)
        {
            ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
            lstReparacion_Rep.DataSource = null;
            lstReparacion_Rep.DataSource = Web.lstRepar_Repu(id);
            lstReparacion_Rep.DataBind();

        }


        private void listarRepAdd()
        {
            ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
            lstRepuestoAdd.DataSource = null;
            lstRepuestoAdd.DataSource = ListaRepuAdd();
            lstRepuestoAdd.DataBind();
            lstCantidad.DataSource = null;
            lstCantidad.DataSource = ListarCant();
            lstCantidad.DataBind();

        }


        private void listarRepar()
        {

            ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
            lstRepar.DataSource = null;
            lstRepar.DataSource = Web.LstReparReparadas();
            lstRepar.DataBind();
            lstReparAgendado.DataSource = null;
            lstReparAgendado.DataSource = Web.LstReparAgend();
            lstReparAgendado.DataBind();
            lstReparReparacion.DataSource = null;
            lstReparReparacion.DataSource = Web.LstReparEnRep();
            lstReparReparacion.DataBind();
        }

        private void limpiar()
        {

            txtDescripcion.Text = "";
            txtFechaEntrada.Text = "";
            txtFechaReservada.Text = "";
            txtFechaSalida.Text = "";
            txtCant.Text = "";
            txtHoras.Text = "";
            lstRepuesto.SelectedIndex = -1;
            lstVeh.SelectedIndex = -1;
            lblMensajes.Text = "";



        }

        private bool faltanDatos()
        {
            if (txtDescripcion.Text == "" || txtFechaEntrada.Text == "" || txtFechaReservada.Text == ""
            || lstVeh.SelectedIndex == -1 || lstMec.SelectedIndex == -1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

      

        private bool FaltalstReparacion_Rep()
        {
            if (lstReparacion_Rep.SelectedIndex == -1)
            {
                return true;
            }
            else
                return false;

        }

        private bool faltaReparado()
        {
            if (lstRepar.SelectedIndex == -1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        private bool faltaCantLinea()
        {
            if (lstCantidad.SelectedIndex == -1)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        private bool faltaCant()
        {
            if (txtCant.Text == "" )
            { 
                return true;
            }
            else
            {
                return false;
            }

        }


        private bool faltaIdRepuesto()
        {
            if (lstRepuesto.SelectedIndex == -1)
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

        private int TraerRepar()
        {


            if (this.lstRepar.SelectedIndex != -1)
            {
                ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
                string CliSt = this.lstRepar.SelectedItem.ToString();
                string[] CliArr = CliSt.Split(' ');
                int Id = Convert.ToInt16(CliArr[0]);
                Reparacion rep = Web.BuscarRepar(Id);
                if (rep != null)
                {
                    return Id;

                }
                else
                {
                    return 0;

                }
            }

           else if (this.lstReparAgendado.SelectedIndex != -1)
            {
                ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
                string CliSt = this.lstReparAgendado.SelectedItem.ToString();
                string[] CliArr = CliSt.Split(' ');
                int Id = Convert.ToInt16(CliArr[0]);
                Reparacion rep = Web.BuscarRepar(Id);
                if (rep != null)
                {
                    return Id;

                }
                else
                {
                    return 0;

                }
            }

            else if (this.lstReparReparacion.SelectedIndex != -1)
            {
                ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
                string CliSt = this.lstReparReparacion.SelectedItem.ToString();
                string[] CliArr = CliSt.Split(' ');
                int Id = Convert.ToInt16(CliArr[0]);
                Reparacion rep = Web.BuscarRepar(Id);
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


        private int TraerRepuestosEnRepar()
        {


            if (this.lstReparacion_Rep.SelectedIndex != -1)
            {
                ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
                string CliSt = this.lstReparacion_Rep.SelectedItem.ToString();
                string[] CliArr = CliSt.Split(' ');
                int Id = Convert.ToInt16(CliArr[0]);
                Reparacion rep = Web.BuscarRepar(Id);
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


            private Repuesto TraerRepuestos()
        {
            if (!faltaIdRepuesto())
            {

                if (this.lstRepuesto.SelectedValue != null)
                {
                    ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
                    string CliSt = this.lstRepuesto.SelectedItem.ToString();
                    string[] CliArr = CliSt.Split(' ');
                    int Id = Convert.ToInt16(CliArr[0]);
                    Repuesto rep = Web.BuscarRepues(Id);
                    if (rep != null)
                    {
                        return rep;

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
                lblMensajes.Text = "Faltan selecionar una Reparacion";
                return null;
            }
        }

        private Repuesto TraerRepuestosAdd()
        {
         
            {

                if (this.lstRepuestoAdd.SelectedValue != null)
                {
                    ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
                    string CliSt = this.lstRepuestoAdd.SelectedItem.ToString();
                    string[] CliArr = CliSt.Split(' ');
                    int Id = Convert.ToInt16(CliArr[0]);
                    Repuesto rep = Web.BuscarRepues(Id);
                    if (rep != null)
                    {
                        return rep;

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
     
        }



        private Mecanico TraerMec()
        {
            if (!faltanDatos())
            {

                if (this.lstMec.SelectedValue != null)
                {
                    ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
                    string CliSt = this.lstMec.SelectedItem.ToString();
                    string[] CliArr = CliSt.Split(' ');
                    int Id = Convert.ToInt16(CliArr[0]);
                    Mecanico rep = Web.BuscarMec(Id);
                    if (rep != null)
                    {
                        return rep;

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
                lblMensajes.Text = "Faltan selecionar una Mecanico";
                return null;
            }
        }



        private void CargarReparar_Rep(int id)
        {
            ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
            Reparacion rep = Web.BuscarRepar(id);

            txtDescripcion.Text = rep.Descripcion.ToString();
            txtFechaEntrada.Text = rep.FchaEntrada.ToString();
            txtFechaReservada.Text = rep.FchaReservada.ToString();
            txtFechaSalida.Text = rep.FchaSalida.ToString();
            txtHoras.Text = rep.Horas.ToString();

            Mecanico mec = Web.BuscarMec(rep.Mecanico.Id);
            lstMec.SelectedValue = mec.ToString();

            Vehiculo veh = Web.BuscarVeh(rep.Vehiculo.IdVehiculo);
            lstVeh.SelectedValue = veh.ToString();


            listarReparacion_Rep(rep.Id);

        }

        private void CargarRepararEnRep(int id)
        {
            ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
            Reparacion rep = Web.BuscarRepar(id);

            txtDescripcion.Text = rep.Descripcion.ToString();
            txtFechaEntrada.Text = rep.FchaEntrada.ToString();
            txtFechaReservada.Text = rep.FchaReservada.ToString();
       



            Mecanico mec = Web.BuscarMec(rep.Mecanico.Id);
            lstMec.SelectedValue = mec.ToString();

            Vehiculo veh = Web.BuscarVeh(rep.Vehiculo.IdVehiculo);
            lstVeh.SelectedValue = veh.ToString();

     



        }


        private void CargarReparar_Age(int id)
        {
            ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
            Reparacion rep = Web.BuscarReparAgen(id);

   
        
            txtFechaReservada.Text = rep.FchaReservada.ToString();
         
           

            Vehiculo veh = Web.BuscarVeh(rep.Vehiculo.IdVehiculo);
            lstVeh.SelectedValue = veh.ToString();




        }


        #endregion

        protected void btnAlta_Click(object sender, EventArgs e)
        {
            if (!faltanDatos())
            {
                ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
                Reparacion rep = new Reparacion();
                rep.Descripcion = txtDescripcion.Text;
                rep.FchaReservada = txtFechaReservada.Text;
                rep.FchaEntrada = txtFechaEntrada.Text;
          
                rep.Mecanico = TraerMec();
             
                rep.Vehiculo = TraerVeh();

                if (txtFechaSalida.Text == "")
                {
                    rep.FchaSalida = null;
                    if (Web.AltaReparEnRep(rep))
                    {
                        lblMensajes.Text = "Reparacion dado de alta con exito.";
                        listarRepar();
                        limpiar();
                   

                    }
                    else
                    {
                        lblMensajes.Text = "No se pudo dar la Reparacion";
                        limpiar();
                    }
                }
                else
                {
                    rep.FchaSalida = txtFechaSalida.Text;
                    rep.Horas = int.Parse(txtHoras.Text);
                    if (Web.AltaRepar(rep))
                    {
                        lblMensajes.Text = "Reparacion dado de alta con exito.";
                        listarRepar();
                        limpiar();
              
                    }
                    else
                    {
                        lblMensajes.Text = "No se pudo dar la Reparacion";
                        limpiar();
                    }
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
                if (this.lstRepar.SelectedIndex > -1)
                {
                    string linea = this.lstRepar.SelectedItem.ToString();
                    string[] partes = linea.Split(' ');
                    short id = Convert.ToInt16(partes[0]);
                    this.CargarReparar_Rep(id);

                }
              
                else if (this.lstReparAgendado.SelectedIndex > -1)
                {
                    string linea = this.lstReparAgendado.SelectedItem.ToString();
                    string[] partes = linea.Split(' ');
                    short id = Convert.ToInt16(partes[0]);
                    this.CargarReparar_Age(id);

                }
                else if (this.lstReparReparacion.SelectedIndex > -1)
                {
                    string linea = this.lstReparReparacion.SelectedItem.ToString();
                    string[] partes = linea.Split(' ');
                    short id = Convert.ToInt16(partes[0]);
                    this.CargarRepararEnRep(id);

                }

                else
                {
                    this.lblMensajes.Text = "Debe seleccionar una reparacion de la lista.";


                }

            }
        }



        protected void btnModificar_Click(object sender, EventArgs e)
        {

            if (!faltanDatos())
            {
                Reparacion Rep = new Reparacion();
                ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
                Rep.Id = TraerRepar();
                Rep.Descripcion = txtDescripcion.Text;
                Rep.FchaEntrada = txtFechaEntrada.Text;
                Rep.FchaSalida = txtFechaSalida.Text;
                Rep.Horas = int.Parse(txtHoras.Text);
                Rep.FchaReservada = txtFechaReservada.Text;
                Rep.Mecanico = TraerMec();
        
                Rep.Vehiculo = TraerVeh();


                if (Web.ModRepar((Rep)))
                {
                    lblMensajes.Text = "Reparacion modificada con exito.";
                    listarRepar();
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

   

        protected void btnBaja_Click(object sender, EventArgs e)
        {
          
                ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
                int Id = TraerRepar();

                if (Web.BajaRepar(Id))
                {
                    lblMensajes.Text = "Reparacion eliminada con exito.";
                limpiar();
                listarRepar();
                 listarReparacion_Rep(Id);
                  
                }
                else
                {
                    lblMensajes.Text = "No se pudo eliminar la reparacion";
                    limpiar();
               }
            
        
        }

        protected void btnAltaRep_Click(object sender, EventArgs e)
        {

            if (!faltaCant())
            {
                Repuesto Rep = TraerRepuestos();
                string cant = txtCant.Text;

                if (AltaRepAdd(Rep))
                {
                    _cantidad.Add(cant);
                    listarRepAdd();
                    limpiar();
                  



                }
                else
                {
                    limpiar();
                    lblMensajes.Text = "No se pudo agregar el repuesto por que ya esta agregado";
                }
            }
            else
            {
                lblMensajes.Text = "Falta Agregar la cantidad";
            }
            


        }

        public bool AltaRepAdd (Repuesto rep)
        {
            Repuesto unRep = BuscarRepAdd(rep.Id);
            if (unRep == null)
            {
                _listaRepuAdd.Add(rep);
                return true;

            }
            else
            {
                return false;
            }

        }



        public Repuesto BuscarRepAdd(int pId)
        {
            foreach (Repuesto unRep in _listaRepuAdd)
            {
                if (unRep.Id == pId)
                {
                    return unRep;

                }
            }
            return null;

        }

      

        protected void btnBajaRep_Click(object sender, EventArgs e)
        {
            Repuesto Rep = TraerRepuestosAdd();
            if (!faltaCantLinea())
            {

                if (BajaRepuestoAdd(Rep.Id))
                {
                    listarRepAdd();
                    limpiar();


                }
                else
                {
                    limpiar();
                    lblMensajes.Text = "No se pudo Eliminar el repuesto ";
                }
            }
            else
                lblMensajes.Text = "Falta selecionar una cantidad de la lista";


        }

        public bool BajaRepuestoAdd(int id)
        {
            if (!faltaCantLinea())
            {
                Repuesto unRep = BuscarRepAdd(id);
                if (unRep != null)
                {
                    _listaRepuAdd.Remove(unRep);
                    _cantidad.RemoveAt(lstCantidad.SelectedIndex);
         
                  
                    return true;
                }
                else
                    return false;
            }
            else
            { 
                lblMensajes.Text = "Falta selecionar una cantidad de la lista";
                return false;
            }


        }

        protected void btnSelectCant_Click(object sender, EventArgs e)
        {
            {
                if (this.lstCantidad.SelectedIndex > -1)
                {
                    string linea = this.lstCantidad.SelectedItem.ToString();
                    string[] partes = linea.Split(' ');
                    string cantidad = partes[0];
                    txtCant.Text = cantidad;
                   

                }

                else
                {
                    lblMensajes.Text = "Debe selecionar una cantidad";
                }
            }

        }

        protected void btnAltaRep_Rep_Click(object sender, EventArgs e)
        {
            if (!faltaReparado())
            {
                ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
                Reparacion_Repuesto rep_rep = new Reparacion_Repuesto();
                int id = TraerRepar();
                int j = 0;
                  while ( j < _listaRepuAdd.Count)

                    {
                    for (int i = 0; i < _cantidad.Count; i++)
                    {
                        rep_rep.Cant = _cantidad[i];

                        rep_rep.Repuesto = _listaRepuAdd[i];

                        Reparacion unRep = Web.BuscarRepar(id);
                        rep_rep.Reparacion = unRep;

                        if (Web.UniqueRepar_Repar(rep_rep.Reparacion.Id, rep_rep.Repuesto.Id))
                        {


                            if (Web.AltaRepar_Repu(rep_rep))
                            {

                                lblMensajes.Text = "Repuesto Agregados";
                                listarReparacion_Rep(rep_rep.Reparacion.Id);
                                listarRepar();
                            }
                            else
                            {
                                lblMensajes.Text = "No se pudo Agregar";
                            }
                            j++;


                        }
                        else
                        {
                            lblMensajes.Text = "Ya se agregaron estos Repuestos";
                        }

                    }
                     }
  

       
            }
            else
            {
                lblMensajes.Text = "Selecionar una reparacion";
            }
        }

        protected void btnBajaRep_Rep_Click(object sender, EventArgs e)
        {
            if (!faltaReparado() || !FaltalstReparacion_Rep())
            {
                ControladoraWeb Web = ControladoraWeb.obtenerInstancia();
                int idRepar = TraerRepar();
                int IdRepuesto = TraerRepuestosEnRepar();

                if (Web.BajaRepar_Repu(IdRepuesto, idRepar))
                {
                    lblMensajes.Text = "Repuesto eliminada con exito.";
                    listarReparacion_Rep(idRepar);
                    listarRepar();
                    limpiar();
                }
                else
                {
                    lblMensajes.Text = "No se pudo eliminar el Repuesto";
                    limpiar();
                }
            }
            else
                lblMensajes.Text = "Faltan Datos";
        }

        protected void lstRepuestoAdd_Init(object sender, EventArgs e)
        {
            listarRepAdd();
        }
    }
       

}
    

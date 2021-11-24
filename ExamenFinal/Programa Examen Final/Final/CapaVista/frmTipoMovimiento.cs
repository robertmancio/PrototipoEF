using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

//0901-18-1982 Roberto López 
namespace CapaVista
{
    public partial class frmTipoMovimiento : Form
    {
        private string usuario = "";
        public frmTipoMovimiento()
        {
            InitializeComponent();
            CenterToScreen();
            //Parametrización navegador
            /*arreglo de textboxs*/
            TextBox[] alias = navegador1.funAsignandoTexts(this);
            //definicion de textboxs, tabla y BD
            navegador1.funAsignarAliasVista(alias, "tipomovimiento", "hotelSanCarlos");
            navegador1.funAsignarSalidadVista(this);

            //definicion del campo de estado / para dar de bajars
            navegador1.campoEstado = "estado";

            //el id de aplicacion para ayudas y reportes, quedara obsoleto en la nueva version
            navegador1.idAplicacion = "10004";//en la nueva se usara el nombre

            //-- Estos atributos no cambian
            //inicio de elementos para ejecutar la ayuda
            navegador1.tablaAyuda = "Aplicacion";
            navegador1.campoAyuda = "pkId";
            //fin de elementos para ejecutar la ayuda

            // Inicio datos para ejecurar reportes
            navegador1.funReportesVista("ruta", "idAplicacion", "Reporte");
            // Final datos para ejecutar reportes
            //-- fin de atributos no cambiantes

            //enviar el data grid view para la navegación
            navegador1.pideGrid(this.dgvEmpleado);
            //llena el data grid
            navegador1.llenaTabla();
            //pide la referencia a la form para poder cerrarla
            navegador1.pedirRef(this);

            navegador1.funLlenarComboControl(cmbCuentaContable, "cuentacontable", "pkIdCuentaContable", "tipoCuenta", "estado");


        }
        //Actualización de permisos que se debe realizar después de tener la variable usuario ingresada
        public void funActualizarUsuario(string user)
        {
            usuario = user;
            navegador1.usuario = user;
            navegador1.aplicacion = "Mantenimiento Tipo Movimiento";
            navegador1.funActualizarPermisos();
            navegador1.idmodulo = "10";
            navegador1.funReportesVista("ruta", "idAplicacion", "Reporte");

        }

        private void dvgCuentas_SelectionChanged(object sender, EventArgs e)
        {
            navegador1.funSeleccionarDTVista(dgvEmpleado);
        }

        private void rdbActivo_CheckedChanged(object sender, EventArgs e)
        {
            navegador1.funCambioEstatusRBVista(txtEstado, rdbActivo, "A");
        }

        private void rdbInactivo_CheckedChanged(object sender, EventArgs e)
        {
            navegador1.funCambioEstatusRBVista(txtEstado, rdbInactivo, "I");
        }

        private void cmbCuentaCont_SelectedIndexChanged(object sender, EventArgs e)
        {
            navegador1.funComboTextboxVista(cmbCuentaContable, txtCuentaContable);
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            navegador1.funSetearRBVista(rdbActivo, rdbInactivo, txtEstado);
        }

        private void txtCuentaCont_TextChanged(object sender, EventArgs e)
        {
            navegador1.funTextboxComboVista(cmbCuentaContable, txtCuentaContable);
        }

        private void txtIdCuenta_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaRRHH
{
    public partial class frmMovimientosBancarios : Form
    {
        private string usuario = "";
        public frmMovimientosBancarios()
        {
            InitializeComponent();
                CenterToScreen();
                //Parametrización navegador
                /*arreglo de textboxs*/
                TextBox[] alias = navegador1.funAsignandoTexts(this);
                //definicion de textboxs, tabla y BD
                navegador1.funAsignarAliasVista(alias, "movimientosbancarios", "hotelSanCarlos");
                navegador1.funAsignarSalidadVista(this);

                //definicion del campo de estado / para dar de bajars
                navegador1.campoEstado = "estado";

                //el id de aplicacion para ayudas y reportes, quedara obsoleto en la nueva version
                navegador1.idAplicacion = "10005";//en la nueva se usara el nombre

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
                navegador1.pideGrid(this.dvgMovimientosBancarios);
                //llena el data grid
                navegador1.llenaTabla();
                //pide la referencia a la form para poder cerrarla
                navegador1.pedirRef(this);
                navegador1.funLlenarComboControl(cmbBanco, "banco", "pkIdBanco", "nombre", "estado");
                navegador1.funLlenarComboControl(cmbCuenta, "cuentabancaria", "pkIdcuenta", "cuenta", "estado");
                navegador1.funLlenarComboControl(cmbTipoMov, "tipomovimiento", "pkIdtipoMovimiento", "nombre", "estado");   




        }
            //Actualización de permisos que se debe realizar después de tener la variable usuario ingresada
            public void funActualizarUsuario(string user)
            {
                usuario = user;
                navegador1.usuario = user;
                navegador1.aplicacion = "Movimientos Bancarios";
                navegador1.funActualizarPermisos();
                navegador1.idmodulo = "10";
                navegador1.funReportesVista("ruta", "idAplicacion", "Reporte");

            }

            private void dvgCuentas_SelectionChanged(object sender, EventArgs e)
            {
                navegador1.funSeleccionarDTVista(dvgMovimientosBancarios);
            }

            private void rdbActivo_CheckedChanged(object sender, EventArgs e)
            {
                navegador1.funCambioEstatusRBVista(txtEstado, rdbActivo, "A");
            }
            private void rdbInactivo_CheckedChanged(object sender, EventArgs e)
            {
                navegador1.funCambioEstatusRBVista(txtEstado, rdbInactivo, "I");
            }

            private void cmbBanco_SelectedIndexChanged(object sender, EventArgs e)
            {
            navegador1.funComboTextboxVista(cmbBanco, txtBanco);
            }
            private void txtBanco_TextChanged(object sender, EventArgs e)
            {
            navegador1.funTextboxComboVista(cmbBanco, txtBanco);
            }

            private void cmbCuenta_SelectedIndexChanged(object sender, EventArgs e)
            {
            navegador1.funComboTextboxVista(cmbCuenta, txtCta);
            }
            private void txtCuenta_TextChanged(object sender, EventArgs e)
            {
            navegador1.funTextboxComboVista(cmbCuenta, txtCta);
            }

            private void cmbTipoMov_SelectedIndexChanged(object sender, EventArgs e)
            {
            navegador1.funComboTextboxVista(cmbTipoMov, txtTipoMovimiento);
            }
            private void txtTipoMov_TextChanged(object sender, EventArgs e)
            {
            navegador1.funTextboxComboVista(cmbTipoMov, txtTipoMovimiento);
            }
            private void txtEstado_TextChanged(object sender, EventArgs e)
            {
            navegador1.funSetearRBVista(rdbActivo, rdbInactivo, txtEstado);
            }



        private void btnGuardarFechaEmision(object sender, EventArgs e)
            {
                String dt = "";
                dt = dtEmision.Value.ToString("yyyy-MM-dd");//lo pasa al formato necesitado por mysql
                txtFechaEmision.Text = dt;
                // MessageBox.Show(txtFecha.Text);
            }
            private void dtFechaEmision_ValueChanged(object sender, EventArgs e)
            {
                navegador1.funDPTextBoxVista(dtEmision, txtFechaEmision);
            }

            private void txtFechaEm_TextChanged(object sender, EventArgs e)
            {
                navegador1.funTextBoxDPTVista(dtEmision, txtFechaEmision);
                navegador1.funDPTextBoxVista(dtEmision, txtFechaEmision);
            }
        private void btnVencimiento(object sender, EventArgs e)
        {
            String dt = "";
            dt = dtVencimiento.Value.ToString("yyyy-MM-dd");//lo pasa al formato necesitado por mysql
            txtVencimiento.Text = dt;
            // MessageBox.Show(txtFecha.Text);
        }
        private void dtVencimiento_ValueChanged(object sender, EventArgs e)
        {
            navegador1.funDPTextBoxVista(dtVencimiento, txtVencimiento);
        }

        private void txtVencimientoTextChanged(object sender, EventArgs e)
        {
            navegador1.funTextBoxDPTVista(dtVencimiento, txtVencimiento);
            navegador1.funDPTextBoxVista(dtVencimiento, txtVencimiento);
        }

    }
}


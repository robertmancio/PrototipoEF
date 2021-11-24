
namespace CapaVistaRRHH
{
    partial class frmMovimientosBancarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtEmision = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbActivo = new System.Windows.Forms.RadioButton();
            this.rdbInactivo = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrestacionLaboral = new System.Windows.Forms.Label();
            this.lblempleado = new System.Windows.Forms.Label();
            this.txtCta = new System.Windows.Forms.TextBox();
            this.txtBanco = new System.Windows.Forms.TextBox();
            this.txtConcepto = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.navegador1 = new DLL.nav.navegador();
            this.dvgMovimientosBancarios = new System.Windows.Forms.DataGridView();
            this.cmbBanco = new System.Windows.Forms.ComboBox();
            this.cmbCuenta = new System.Windows.Forms.ComboBox();
            this.cmbTipoMov = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtFechaEmision = new System.Windows.Forms.TextBox();
            this.txtVencimiento = new System.Windows.Forms.TextBox();
            this.txtTipoMovimiento = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgMovimientosBancarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dtEmision
            // 
            this.dtEmision.Location = new System.Drawing.Point(198, 341);
            this.dtEmision.Name = "dtEmision";
            this.dtEmision.Size = new System.Drawing.Size(121, 20);
            this.dtEmision.TabIndex = 67;
            this.dtEmision.ValueChanged += new System.EventHandler(this.dtFechaEmision_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rdbActivo);
            this.groupBox1.Controls.Add(this.rdbInactivo);
            this.groupBox1.Location = new System.Drawing.Point(37, 529);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 101);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado";
            // 
            // rdbActivo
            // 
            this.rdbActivo.AutoSize = true;
            this.rdbActivo.Location = new System.Drawing.Point(23, 29);
            this.rdbActivo.Name = "rdbActivo";
            this.rdbActivo.Size = new System.Drawing.Size(55, 17);
            this.rdbActivo.TabIndex = 46;
            this.rdbActivo.TabStop = true;
            this.rdbActivo.Text = "Activo";
            this.rdbActivo.UseVisualStyleBackColor = true;
            this.rdbActivo.CheckedChanged += new System.EventHandler(this.rdbActivo_CheckedChanged);
            // 
            // rdbInactivo
            // 
            this.rdbInactivo.AutoSize = true;
            this.rdbInactivo.Location = new System.Drawing.Point(23, 62);
            this.rdbInactivo.Name = "rdbInactivo";
            this.rdbInactivo.Size = new System.Drawing.Size(63, 17);
            this.rdbInactivo.TabIndex = 47;
            this.rdbInactivo.TabStop = true;
            this.rdbInactivo.Text = "Inactivo";
            this.rdbInactivo.UseVisualStyleBackColor = true;
            this.rdbInactivo.CheckedChanged += new System.EventHandler(this.rdbInactivo_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(43, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "ID Movimientos Bancarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(43, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Tipo Movimiento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 25);
            this.label1.TabIndex = 57;
            this.label1.Text = "Movimientos Bancarios:";
            // 
            // lblPrestacionLaboral
            // 
            this.lblPrestacionLaboral.AutoSize = true;
            this.lblPrestacionLaboral.BackColor = System.Drawing.Color.Transparent;
            this.lblPrestacionLaboral.Location = new System.Drawing.Point(43, 265);
            this.lblPrestacionLaboral.Name = "lblPrestacionLaboral";
            this.lblPrestacionLaboral.Size = new System.Drawing.Size(44, 13);
            this.lblPrestacionLaboral.TabIndex = 56;
            this.lblPrestacionLaboral.Text = "Cuenta:";
            // 
            // lblempleado
            // 
            this.lblempleado.AutoSize = true;
            this.lblempleado.BackColor = System.Drawing.Color.Transparent;
            this.lblempleado.Location = new System.Drawing.Point(43, 229);
            this.lblempleado.Name = "lblempleado";
            this.lblempleado.Size = new System.Drawing.Size(41, 13);
            this.lblempleado.TabIndex = 55;
            this.lblempleado.Text = "Banco:";
            // 
            // txtCta
            // 
            this.txtCta.Location = new System.Drawing.Point(336, 262);
            this.txtCta.Name = "txtCta";
            this.txtCta.Size = new System.Drawing.Size(50, 20);
            this.txtCta.TabIndex = 65;
            this.txtCta.Tag = "fkIdCuenta";
            this.txtCta.Visible = false;
            this.txtCta.TextChanged += new System.EventHandler(this.txtCuenta_TextChanged);
            // 
            // txtBanco
            // 
            this.txtBanco.Location = new System.Drawing.Point(336, 226);
            this.txtBanco.Name = "txtBanco";
            this.txtBanco.Size = new System.Drawing.Size(50, 20);
            this.txtBanco.TabIndex = 68;
            this.txtBanco.Tag = "fkIdBanco";
            this.txtBanco.Visible = false;
            this.txtBanco.TextChanged += new System.EventHandler(this.txtBanco_TextChanged);
            // 
            // txtConcepto
            // 
            this.txtConcepto.Location = new System.Drawing.Point(198, 420);
            this.txtConcepto.Name = "txtConcepto";
            this.txtConcepto.Size = new System.Drawing.Size(121, 20);
            this.txtConcepto.TabIndex = 60;
            this.txtConcepto.Tag = "concepto";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(198, 463);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(121, 20);
            this.txtValor.TabIndex = 62;
            this.txtValor.Tag = "valor";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(198, 187);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(121, 20);
            this.txtId.TabIndex = 66;
            this.txtId.Tag = "pkIdMovimientosBancarios";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(0, -1);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1189, 87);
            this.navegador1.TabIndex = 61;
            // 
            // dvgMovimientosBancarios
            // 
            this.dvgMovimientosBancarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgMovimientosBancarios.Location = new System.Drawing.Point(484, 152);
            this.dvgMovimientosBancarios.Name = "dvgMovimientosBancarios";
            this.dvgMovimientosBancarios.ReadOnly = true;
            this.dvgMovimientosBancarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgMovimientosBancarios.Size = new System.Drawing.Size(659, 346);
            this.dvgMovimientosBancarios.TabIndex = 59;
            this.dvgMovimientosBancarios.SelectionChanged += new System.EventHandler(this.dvgCuentas_SelectionChanged);
            // 
            // cmbBanco
            // 
            this.cmbBanco.FormattingEnabled = true;
            this.cmbBanco.Location = new System.Drawing.Point(198, 225);
            this.cmbBanco.Name = "cmbBanco";
            this.cmbBanco.Size = new System.Drawing.Size(121, 21);
            this.cmbBanco.TabIndex = 69;
            this.cmbBanco.SelectedIndexChanged += new System.EventHandler(this.cmbBanco_SelectedIndexChanged);
            // 
            // cmbCuenta
            // 
            this.cmbCuenta.FormattingEnabled = true;
            this.cmbCuenta.Location = new System.Drawing.Point(198, 261);
            this.cmbCuenta.Name = "cmbCuenta";
            this.cmbCuenta.Size = new System.Drawing.Size(121, 21);
            this.cmbCuenta.TabIndex = 70;
            this.cmbCuenta.SelectedIndexChanged += new System.EventHandler(this.cmbCuenta_SelectedIndexChanged);
            // 
            // cmbTipoMov
            // 
            this.cmbTipoMov.FormattingEnabled = true;
            this.cmbTipoMov.Location = new System.Drawing.Point(198, 299);
            this.cmbTipoMov.Name = "cmbTipoMov";
            this.cmbTipoMov.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoMov.TabIndex = 71;
            this.cmbTipoMov.SelectedIndexChanged += new System.EventHandler(this.cmbTipoMov_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(46, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 72;
            this.label3.Text = "Fecha Emision:";
            // 
            // dtVencimiento
            // 
            this.dtVencimiento.Location = new System.Drawing.Point(198, 381);
            this.dtVencimiento.Name = "dtVencimiento";
            this.dtVencimiento.Size = new System.Drawing.Size(121, 20);
            this.dtVencimiento.TabIndex = 73;
            this.dtVencimiento.ValueChanged += new System.EventHandler(this.dtVencimiento_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(43, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 74;
            this.label5.Text = "Fecha Vencimiento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(46, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 75;
            this.label6.Text = "Concepto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(46, 466);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 76;
            this.label7.Text = "Valor:";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(243, 570);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(54, 20);
            this.txtEstado.TabIndex = 77;
            this.txtEstado.Tag = "estado";
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // txtFechaEmision
            // 
            this.txtFechaEmision.Location = new System.Drawing.Point(336, 344);
            this.txtFechaEmision.Name = "txtFechaEmision";
            this.txtFechaEmision.Size = new System.Drawing.Size(54, 20);
            this.txtFechaEmision.TabIndex = 78;
            this.txtFechaEmision.Tag = "fechaEmision";
            this.txtFechaEmision.TextChanged += new System.EventHandler(this.txtFechaEm_TextChanged);
            // 
            // txtVencimiento
            // 
            this.txtVencimiento.Location = new System.Drawing.Point(336, 381);
            this.txtVencimiento.Name = "txtVencimiento";
            this.txtVencimiento.Size = new System.Drawing.Size(54, 20);
            this.txtVencimiento.TabIndex = 79;
            this.txtVencimiento.Tag = "fechaVencimiento";
            this.txtVencimiento.TextChanged += new System.EventHandler(this.txtVencimientoTextChanged);
            // 
            // txtTipoMovimiento
            // 
            this.txtTipoMovimiento.Location = new System.Drawing.Point(336, 300);
            this.txtTipoMovimiento.Name = "txtTipoMovimiento";
            this.txtTipoMovimiento.Size = new System.Drawing.Size(54, 20);
            this.txtTipoMovimiento.TabIndex = 80;
            this.txtTipoMovimiento.Tag = "tipoMovimiento_pkIdtipoMovimiento";
            this.txtTipoMovimiento.TextChanged += new System.EventHandler(this.txtTipoMov_TextChanged);
            // 
            // frmMovimientosBancarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaVistaRRHH.Properties.Resources._90_Simple_Backgrounds_Edit_and_Download_Visual_Learning_Center;
            this.ClientSize = new System.Drawing.Size(1182, 672);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtVencimiento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTipoMov);
            this.Controls.Add(this.cmbCuenta);
            this.Controls.Add(this.cmbBanco);
            this.Controls.Add(this.dtEmision);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPrestacionLaboral);
            this.Controls.Add(this.lblempleado);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtConcepto);
            this.Controls.Add(this.txtVencimiento);
            this.Controls.Add(this.txtFechaEmision);
            this.Controls.Add(this.txtTipoMovimiento);
            this.Controls.Add(this.txtCta);
            this.Controls.Add(this.txtBanco);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.dvgMovimientosBancarios);
            this.Name = "frmMovimientosBancarios";
            this.Text = "frmMovimientosBancarios";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgMovimientosBancarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtEmision;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbActivo;
        private System.Windows.Forms.RadioButton rdbInactivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrestacionLaboral;
        private System.Windows.Forms.Label lblempleado;
        private System.Windows.Forms.TextBox txtCta;
        private System.Windows.Forms.TextBox txtBanco;
        private System.Windows.Forms.TextBox txtConcepto;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtId;
        private DLL.nav.navegador navegador1;
        private System.Windows.Forms.DataGridView dvgMovimientosBancarios;
        private System.Windows.Forms.ComboBox cmbBanco;
        private System.Windows.Forms.ComboBox cmbCuenta;
        private System.Windows.Forms.ComboBox cmbTipoMov;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtVencimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtFechaEmision;
        private System.Windows.Forms.TextBox txtVencimiento;
        private System.Windows.Forms.TextBox txtTipoMovimiento;
    }
}
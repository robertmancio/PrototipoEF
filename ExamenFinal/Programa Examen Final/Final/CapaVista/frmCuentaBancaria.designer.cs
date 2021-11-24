
namespace CapaVista
{
    partial class frmCuentaBancaria
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
            this.dvgCuentaBancaria = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrestacionLaboral = new System.Windows.Forms.Label();
            this.lblempleado = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.navegador1 = new DLL.nav.navegador();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbActivo = new System.Windows.Forms.RadioButton();
            this.rdbInactivo = new System.Windows.Forms.RadioButton();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.txtDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCuentaBancaria)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dvgCuentaBancaria
            // 
            this.dvgCuentaBancaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCuentaBancaria.Location = new System.Drawing.Point(484, 153);
            this.dvgCuentaBancaria.Name = "dvgCuentaBancaria";
            this.dvgCuentaBancaria.ReadOnly = true;
            this.dvgCuentaBancaria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgCuentaBancaria.Size = new System.Drawing.Size(659, 346);
            this.dvgCuentaBancaria.TabIndex = 37;
            this.dvgCuentaBancaria.SelectionChanged += new System.EventHandler(this.dvgCuentas_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(90, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Fecha Apertura:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Cuenta Bancaria:";
            // 
            // lblPrestacionLaboral
            // 
            this.lblPrestacionLaboral.AutoSize = true;
            this.lblPrestacionLaboral.BackColor = System.Drawing.Color.Transparent;
            this.lblPrestacionLaboral.Location = new System.Drawing.Point(90, 279);
            this.lblPrestacionLaboral.Name = "lblPrestacionLaboral";
            this.lblPrestacionLaboral.Size = new System.Drawing.Size(46, 13);
            this.lblPrestacionLaboral.TabIndex = 31;
            this.lblPrestacionLaboral.Text = "Usuario:";
            // 
            // lblempleado
            // 
            this.lblempleado.AutoSize = true;
            this.lblempleado.BackColor = System.Drawing.Color.Transparent;
            this.lblempleado.Location = new System.Drawing.Point(90, 235);
            this.lblempleado.Name = "lblempleado";
            this.lblempleado.Size = new System.Drawing.Size(44, 13);
            this.lblempleado.TabIndex = 30;
            this.lblempleado.Text = "Cuenta:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(198, 272);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(121, 20);
            this.txtUsuario.TabIndex = 38;
            this.txtUsuario.Tag = "usuario";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.navegador1.Location = new System.Drawing.Point(0, 0);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(1189, 87);
            this.navegador1.TabIndex = 42;
            // 
            // txtCuenta
            // 
            this.txtCuenta.Location = new System.Drawing.Point(198, 232);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(121, 20);
            this.txtCuenta.TabIndex = 43;
            this.txtCuenta.Tag = "cuenta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(90, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "ID Cuenta";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rdbActivo);
            this.groupBox1.Controls.Add(this.rdbInactivo);
            this.groupBox1.Location = new System.Drawing.Point(114, 360);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 50;
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
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(334, 401);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(45, 20);
            this.txtEstado.TabIndex = 51;
            this.txtEstado.Tag = "estado";
            this.txtEstado.Visible = false;
            this.txtEstado.TextChanged += new System.EventHandler(this.txtEstado_TextChanged);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(198, 188);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(121, 20);
            this.txtId.TabIndex = 52;
            this.txtId.Tag = "pkIdcuenta";
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(198, 324);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(121, 20);
            this.dtDate.TabIndex = 53;
            this.dtDate.ValueChanged += new System.EventHandler(this.dtFinContrato_ValueChanged);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(428, 324);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(50, 20);
            this.txtDate.TabIndex = 54;
            this.txtDate.Tag = "fechaApertura";
            this.txtDate.Visible = false;
            this.txtDate.TextChanged += new System.EventHandler(this.txtFinContrato_TextChanged);
            // 
            // frmCuentaBancaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CapaVistaRRHH.Properties.Resources._90_Simple_Backgrounds_Edit_and_Download_Visual_Learning_Center;
            this.ClientSize = new System.Drawing.Size(1189, 551);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPrestacionLaboral);
            this.Controls.Add(this.lblempleado);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtCuenta);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.dvgCuentaBancaria);
            this.Name = "frmCuentaBancaria";
            this.Text = "10002 Cuenta Bancaria";
            ((System.ComponentModel.ISupportInitialize)(this.dvgCuentaBancaria)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgCuentaBancaria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrestacionLaboral;
        private System.Windows.Forms.Label lblempleado;
        private System.Windows.Forms.TextBox txtUsuario;
        private DLL.nav.navegador navegador1;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbActivo;
        private System.Windows.Forms.RadioButton rdbInactivo;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.TextBox txtDate;
    }
}
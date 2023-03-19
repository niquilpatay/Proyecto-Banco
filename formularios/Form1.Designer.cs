namespace banco
{
    partial class frmNvoClienteCuenta
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelcbu = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCBU_2 = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.cboTipoCuenta = new System.Windows.Forms.ComboBox();
            this.dtpUltMov = new System.Windows.Forms.DateTimePicker();
            this.btnNuevo_Cliente = new System.Windows.Forms.Button();
            this.btn_Agregar_Cliente = new System.Windows.Forms.Button();
            this.btnBorrar_Cliente = new System.Windows.Forms.Button();
            this.btnNueva_Cuenta = new System.Windows.Forms.Button();
            this.btn_Agregar_Cuenta = new System.Windows.Forms.Button();
            this.btnBorrar_Cuenta = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cuentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Actualizar_Cuenta = new System.Windows.Forms.Button();
            this.btn_Actualizar_Cliente = new System.Windows.Forms.Button();
            this.rbtActiva = new System.Windows.Forms.RadioButton();
            this.rbtInactiva = new System.Windows.Forms.RadioButton();
            this.btnDesactivar = new System.Windows.Forms.Button();
            this.btnCuentasInactivas = new System.Windows.Forms.Button();
            this.txtDNI_2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Apellido";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(65, 41);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(317, 20);
            this.txtDNI.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(65, 72);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(317, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(65, 102);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(317, 20);
            this.txtApellido.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(394, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Agregar cuenta";
            // 
            // labelcbu
            // 
            this.labelcbu.AutoSize = true;
            this.labelcbu.Location = new System.Drawing.Point(396, 48);
            this.labelcbu.Name = "labelcbu";
            this.labelcbu.Size = new System.Drawing.Size(29, 13);
            this.labelcbu.TabIndex = 13;
            this.labelcbu.Text = "CBU";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(396, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Saldo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(396, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Tipo de cuenta";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(396, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Último Mov.";
            // 
            // txtCBU_2
            // 
            this.txtCBU_2.Location = new System.Drawing.Point(442, 41);
            this.txtCBU_2.Name = "txtCBU_2";
            this.txtCBU_2.Size = new System.Drawing.Size(465, 20);
            this.txtCBU_2.TabIndex = 14;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(442, 72);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(465, 20);
            this.txtSaldo.TabIndex = 16;
            // 
            // cboTipoCuenta
            // 
            this.cboTipoCuenta.FormattingEnabled = true;
            this.cboTipoCuenta.Location = new System.Drawing.Point(481, 101);
            this.cboTipoCuenta.Name = "cboTipoCuenta";
            this.cboTipoCuenta.Size = new System.Drawing.Size(426, 21);
            this.cboTipoCuenta.TabIndex = 18;
            // 
            // dtpUltMov
            // 
            this.dtpUltMov.Location = new System.Drawing.Point(481, 131);
            this.dtpUltMov.Name = "dtpUltMov";
            this.dtpUltMov.Size = new System.Drawing.Size(426, 20);
            this.dtpUltMov.TabIndex = 20;
            // 
            // btnNuevo_Cliente
            // 
            this.btnNuevo_Cliente.Location = new System.Drawing.Point(12, 135);
            this.btnNuevo_Cliente.Name = "btnNuevo_Cliente";
            this.btnNuevo_Cliente.Size = new System.Drawing.Size(370, 23);
            this.btnNuevo_Cliente.TabIndex = 9;
            this.btnNuevo_Cliente.Text = "Nuevo";
            this.btnNuevo_Cliente.UseVisualStyleBackColor = true;
            this.btnNuevo_Cliente.Click += new System.EventHandler(this.btnNuevo_Cliente_Click);
            // 
            // btn_Agregar_Cliente
            // 
            this.btn_Agregar_Cliente.Location = new System.Drawing.Point(12, 164);
            this.btn_Agregar_Cliente.Name = "btn_Agregar_Cliente";
            this.btn_Agregar_Cliente.Size = new System.Drawing.Size(183, 23);
            this.btn_Agregar_Cliente.TabIndex = 10;
            this.btn_Agregar_Cliente.Text = "Agregar";
            this.btn_Agregar_Cliente.UseVisualStyleBackColor = true;
            this.btn_Agregar_Cliente.Click += new System.EventHandler(this.btn_Agregar_Actualizar_Cliente_Click);
            // 
            // btnBorrar_Cliente
            // 
            this.btnBorrar_Cliente.Location = new System.Drawing.Point(13, 194);
            this.btnBorrar_Cliente.Name = "btnBorrar_Cliente";
            this.btnBorrar_Cliente.Size = new System.Drawing.Size(369, 23);
            this.btnBorrar_Cliente.TabIndex = 11;
            this.btnBorrar_Cliente.Text = "Borrar";
            this.btnBorrar_Cliente.UseVisualStyleBackColor = true;
            this.btnBorrar_Cliente.Click += new System.EventHandler(this.btnBorrar_Cliente_Click);
            // 
            // btnNueva_Cuenta
            // 
            this.btnNueva_Cuenta.Location = new System.Drawing.Point(388, 168);
            this.btnNueva_Cuenta.Name = "btnNueva_Cuenta";
            this.btnNueva_Cuenta.Size = new System.Drawing.Size(519, 23);
            this.btnNueva_Cuenta.TabIndex = 21;
            this.btnNueva_Cuenta.Text = "Nueva";
            this.btnNueva_Cuenta.UseVisualStyleBackColor = true;
            this.btnNueva_Cuenta.Click += new System.EventHandler(this.btnNueva_Cuenta_Click);
            // 
            // btn_Agregar_Cuenta
            // 
            this.btn_Agregar_Cuenta.Location = new System.Drawing.Point(388, 198);
            this.btn_Agregar_Cuenta.Name = "btn_Agregar_Cuenta";
            this.btn_Agregar_Cuenta.Size = new System.Drawing.Size(257, 23);
            this.btn_Agregar_Cuenta.TabIndex = 22;
            this.btn_Agregar_Cuenta.Text = "Agregar";
            this.btn_Agregar_Cuenta.UseVisualStyleBackColor = true;
            this.btn_Agregar_Cuenta.Click += new System.EventHandler(this.btn_Agregar_Actualizar_Cuenta_Click);
            // 
            // btnBorrar_Cuenta
            // 
            this.btnBorrar_Cuenta.Location = new System.Drawing.Point(388, 228);
            this.btnBorrar_Cuenta.Name = "btnBorrar_Cuenta";
            this.btnBorrar_Cuenta.Size = new System.Drawing.Size(519, 23);
            this.btnBorrar_Cuenta.TabIndex = 23;
            this.btnBorrar_Cuenta.Text = "Borrar";
            this.btnBorrar_Cuenta.UseVisualStyleBackColor = true;
            this.btnBorrar_Cuenta.Click += new System.EventHandler(this.btnBorrar_Cuenta_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(373, 265);
            this.dataGridView1.TabIndex = 24;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(388, 286);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(519, 203);
            this.dataGridView2.TabIndex = 25;
            // 
            // cuentasBindingSource
            // 
            this.cuentasBindingSource.DataMember = "cuentas";
            // 
            // btn_Actualizar_Cuenta
            // 
            this.btn_Actualizar_Cuenta.Location = new System.Drawing.Point(651, 198);
            this.btn_Actualizar_Cuenta.Name = "btn_Actualizar_Cuenta";
            this.btn_Actualizar_Cuenta.Size = new System.Drawing.Size(256, 23);
            this.btn_Actualizar_Cuenta.TabIndex = 26;
            this.btn_Actualizar_Cuenta.Text = "Actualizar";
            this.btn_Actualizar_Cuenta.UseVisualStyleBackColor = true;
            this.btn_Actualizar_Cuenta.Click += new System.EventHandler(this.btn_Actualizar_Cuenta_Click);
            // 
            // btn_Actualizar_Cliente
            // 
            this.btn_Actualizar_Cliente.Location = new System.Drawing.Point(201, 164);
            this.btn_Actualizar_Cliente.Name = "btn_Actualizar_Cliente";
            this.btn_Actualizar_Cliente.Size = new System.Drawing.Size(181, 23);
            this.btn_Actualizar_Cliente.TabIndex = 27;
            this.btn_Actualizar_Cliente.Text = "Actualizar";
            this.btn_Actualizar_Cliente.UseVisualStyleBackColor = true;
            this.btn_Actualizar_Cliente.Click += new System.EventHandler(this.btn_Actualizar_Cliente_Click);
            // 
            // rbtActiva
            // 
            this.rbtActiva.AutoSize = true;
            this.rbtActiva.Location = new System.Drawing.Point(388, 260);
            this.rbtActiva.Name = "rbtActiva";
            this.rbtActiva.Size = new System.Drawing.Size(55, 17);
            this.rbtActiva.TabIndex = 28;
            this.rbtActiva.TabStop = true;
            this.rbtActiva.Text = "Activa";
            this.rbtActiva.UseVisualStyleBackColor = true;
            // 
            // rbtInactiva
            // 
            this.rbtInactiva.AutoSize = true;
            this.rbtInactiva.Location = new System.Drawing.Point(449, 260);
            this.rbtInactiva.Name = "rbtInactiva";
            this.rbtInactiva.Size = new System.Drawing.Size(63, 17);
            this.rbtInactiva.TabIndex = 29;
            this.rbtInactiva.TabStop = true;
            this.rbtInactiva.Text = "Inactiva";
            this.rbtInactiva.UseVisualStyleBackColor = true;
            // 
            // btnDesactivar
            // 
            this.btnDesactivar.Location = new System.Drawing.Point(518, 257);
            this.btnDesactivar.Name = "btnDesactivar";
            this.btnDesactivar.Size = new System.Drawing.Size(206, 23);
            this.btnDesactivar.TabIndex = 30;
            this.btnDesactivar.Text = "Desactivar cuenta";
            this.btnDesactivar.UseVisualStyleBackColor = true;
            this.btnDesactivar.Click += new System.EventHandler(this.btnDesactivar_Click);
            // 
            // btnCuentasInactivas
            // 
            this.btnCuentasInactivas.Location = new System.Drawing.Point(731, 257);
            this.btnCuentasInactivas.Name = "btnCuentasInactivas";
            this.btnCuentasInactivas.Size = new System.Drawing.Size(176, 23);
            this.btnCuentasInactivas.TabIndex = 31;
            this.btnCuentasInactivas.Text = "Mostrar cuentas inactivas";
            this.btnCuentasInactivas.UseVisualStyleBackColor = true;
            this.btnCuentasInactivas.Click += new System.EventHandler(this.btnCuentasInactivas_Click);
            // 
            // txtDNI_2
            // 
            this.txtDNI_2.Location = new System.Drawing.Point(697, 9);
            this.txtDNI_2.Name = "txtDNI_2";
            this.txtDNI_2.Size = new System.Drawing.Size(210, 20);
            this.txtDNI_2.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(630, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "DNI Cliente";
            // 
            // frmNvoClienteCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(919, 496);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDNI_2);
            this.Controls.Add(this.btnCuentasInactivas);
            this.Controls.Add(this.btnDesactivar);
            this.Controls.Add(this.rbtInactiva);
            this.Controls.Add(this.rbtActiva);
            this.Controls.Add(this.btn_Actualizar_Cliente);
            this.Controls.Add(this.btn_Actualizar_Cuenta);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBorrar_Cuenta);
            this.Controls.Add(this.btn_Agregar_Cuenta);
            this.Controls.Add(this.btnNueva_Cuenta);
            this.Controls.Add(this.btnBorrar_Cliente);
            this.Controls.Add(this.btn_Agregar_Cliente);
            this.Controls.Add(this.btnNuevo_Cliente);
            this.Controls.Add(this.dtpUltMov);
            this.Controls.Add(this.cboTipoCuenta);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtCBU_2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelcbu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Navy;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmNvoClienteCuenta";
            this.Text = "NUEVO CLIENTE / CUENTA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuentasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelcbu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCBU_2;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.ComboBox cboTipoCuenta;
        private System.Windows.Forms.DateTimePicker dtpUltMov;
        private System.Windows.Forms.Button btnNuevo_Cliente;
        private System.Windows.Forms.Button btn_Agregar_Cliente;
        private System.Windows.Forms.Button btnBorrar_Cliente;
        private System.Windows.Forms.Button btnNueva_Cuenta;
        private System.Windows.Forms.Button btn_Agregar_Cuenta;
        private System.Windows.Forms.Button btnBorrar_Cuenta;
        private System.Windows.Forms.DataGridView dataGridView1;
        //private bancoDataSet bancoDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        //private bancoDataSetTableAdapters.clientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        //private bancoDataSet1 bancoDataSet1;
        private System.Windows.Forms.BindingSource cuentasBindingSource;
       // private bancoDataSet1TableAdapters.cuentasTableAdapter cuentasTableAdapter;
        private System.Windows.Forms.Button btn_Actualizar_Cuenta;
        private System.Windows.Forms.Button btn_Actualizar_Cliente;
        private System.Windows.Forms.RadioButton rbtActiva;
        private System.Windows.Forms.RadioButton rbtInactiva;
        private System.Windows.Forms.Button btnDesactivar;
        private System.Windows.Forms.Button btnCuentasInactivas;
        private System.Windows.Forms.TextBox txtDNI_2;
        private System.Windows.Forms.Label label3;
    }
}


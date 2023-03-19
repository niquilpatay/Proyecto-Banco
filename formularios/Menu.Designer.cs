namespace banco
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clienteCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoClienteCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesYSaldoTotalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesYSusMovimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteCuentaToolStripMenuItem,
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(263, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clienteCuentaToolStripMenuItem
            // 
            this.clienteCuentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoClienteCuentaToolStripMenuItem});
            this.clienteCuentaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.clienteCuentaToolStripMenuItem.Name = "clienteCuentaToolStripMenuItem";
            this.clienteCuentaToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.clienteCuentaToolStripMenuItem.Text = "Cliente / Cuenta";
            // 
            // nuevoClienteCuentaToolStripMenuItem
            // 
            this.nuevoClienteCuentaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nuevoClienteCuentaToolStripMenuItem.Name = "nuevoClienteCuentaToolStripMenuItem";
            this.nuevoClienteCuentaToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.nuevoClienteCuentaToolStripMenuItem.Text = "Nuevo Cliente / Cuenta";
            this.nuevoClienteCuentaToolStripMenuItem.Click += new System.EventHandler(this.nuevoClienteCuentaToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesYSaldoTotalToolStripMenuItem,
            this.clientesYSusMovimientosToolStripMenuItem,
            this.cuentasToolStripMenuItem});
            this.reportesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // clientesYSaldoTotalToolStripMenuItem
            // 
            this.clientesYSaldoTotalToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.clientesYSaldoTotalToolStripMenuItem.Name = "clientesYSaldoTotalToolStripMenuItem";
            this.clientesYSaldoTotalToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.clientesYSaldoTotalToolStripMenuItem.Text = "Clientes y saldo total";
            this.clientesYSaldoTotalToolStripMenuItem.Click += new System.EventHandler(this.clientesYSaldoTotalToolStripMenuItem_Click);
            // 
            // clientesYSusMovimientosToolStripMenuItem
            // 
            this.clientesYSusMovimientosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.clientesYSusMovimientosToolStripMenuItem.Name = "clientesYSusMovimientosToolStripMenuItem";
            this.clientesYSusMovimientosToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.clientesYSusMovimientosToolStripMenuItem.Text = "Clientes y sus movimientos";
            this.clientesYSusMovimientosToolStripMenuItem.Click += new System.EventHandler(this.clientesYSusMovimientosToolStripMenuItem_Click);
            // 
            // cuentasToolStripMenuItem
            // 
            this.cuentasToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cuentasToolStripMenuItem.Name = "cuentasToolStripMenuItem";
            this.cuentasToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.cuentasToolStripMenuItem.Text = "Cuentas";
            this.cuentasToolStripMenuItem.Click += new System.EventHandler(this.cuentasToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(263, 132);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "MENU";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clienteCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoClienteCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesYSaldoTotalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesYSusMovimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasToolStripMenuItem;
    }
}
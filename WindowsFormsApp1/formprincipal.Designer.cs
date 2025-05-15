namespace WindowsFormsApp1
{
    partial class formprincipal
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
            this.menuReclamo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHacerReclamo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHistorialReclamos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReclamosSolucionados = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRevisarReclamos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHistorialMensajes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPuntuaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPuntuarVendedor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPuntuacionesDadas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPuntuacionesRecibidas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuListaUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuListaVendedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUnlogin = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuReclamo,
            this.menuPuntuaciones,
            this.menuAdmin,
            this.menuUnlogin});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuReclamo
            // 
            this.menuReclamo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHacerReclamo,
            this.menuHistorialReclamos,
            this.menuReclamosSolucionados,
            this.menuRevisarReclamos,
            this.menuHistorialMensajes});
            this.menuReclamo.Name = "menuReclamo";
            this.menuReclamo.Size = new System.Drawing.Size(70, 20);
            this.menuReclamo.Text = "Reclamos";
            this.menuReclamo.Click += new System.EventHandler(this.reclamosToolStripMenuItem_Click_1);
            // 
            // menuHacerReclamo
            // 
            this.menuHacerReclamo.Name = "menuHacerReclamo";
            this.menuHacerReclamo.Size = new System.Drawing.Size(198, 22);
            this.menuHacerReclamo.Text = "Hacer reclamo";
            // 
            // menuHistorialReclamos
            // 
            this.menuHistorialReclamos.Name = "menuHistorialReclamos";
            this.menuHistorialReclamos.Size = new System.Drawing.Size(198, 22);
            this.menuHistorialReclamos.Text = "Historial de reclamos";
            // 
            // menuReclamosSolucionados
            // 
            this.menuReclamosSolucionados.Name = "menuReclamosSolucionados";
            this.menuReclamosSolucionados.Size = new System.Drawing.Size(198, 22);
            this.menuReclamosSolucionados.Text = "Reclamos solucionados";
            this.menuReclamosSolucionados.Click += new System.EventHandler(this.historialDeMensajesToolStripMenuItem_Click);
            // 
            // menuRevisarReclamos
            // 
            this.menuRevisarReclamos.Name = "menuRevisarReclamos";
            this.menuRevisarReclamos.Size = new System.Drawing.Size(198, 22);
            this.menuRevisarReclamos.Text = "Revisar reclamos";
            // 
            // menuHistorialMensajes
            // 
            this.menuHistorialMensajes.Name = "menuHistorialMensajes";
            this.menuHistorialMensajes.Size = new System.Drawing.Size(198, 22);
            this.menuHistorialMensajes.Text = "Historial de mensajes";
            // 
            // menuPuntuaciones
            // 
            this.menuPuntuaciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPuntuarVendedor,
            this.menuPuntuacionesDadas,
            this.menuPuntuacionesRecibidas});
            this.menuPuntuaciones.Name = "menuPuntuaciones";
            this.menuPuntuaciones.Size = new System.Drawing.Size(91, 20);
            this.menuPuntuaciones.Text = "Puntuaciones";
            this.menuPuntuaciones.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // menuPuntuarVendedor
            // 
            this.menuPuntuarVendedor.Name = "menuPuntuarVendedor";
            this.menuPuntuarVendedor.Size = new System.Drawing.Size(196, 22);
            this.menuPuntuarVendedor.Text = "Puntuar vendedor";
            // 
            // menuPuntuacionesDadas
            // 
            this.menuPuntuacionesDadas.Name = "menuPuntuacionesDadas";
            this.menuPuntuacionesDadas.Size = new System.Drawing.Size(196, 22);
            this.menuPuntuacionesDadas.Text = "Puntuaciones dadas";
            // 
            // menuPuntuacionesRecibidas
            // 
            this.menuPuntuacionesRecibidas.Name = "menuPuntuacionesRecibidas";
            this.menuPuntuacionesRecibidas.Size = new System.Drawing.Size(196, 22);
            this.menuPuntuacionesRecibidas.Text = "Puntuaciones recibidas";
            // 
            // menuAdmin
            // 
            this.menuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuListaUsuarios,
            this.menuListaVendedores});
            this.menuAdmin.Name = "menuAdmin";
            this.menuAdmin.Size = new System.Drawing.Size(95, 20);
            this.menuAdmin.Text = "Administrador";
            // 
            // menuListaUsuarios
            // 
            this.menuListaUsuarios.Name = "menuListaUsuarios";
            this.menuListaUsuarios.Size = new System.Drawing.Size(162, 22);
            this.menuListaUsuarios.Text = "Lista usuarios";
            // 
            // menuListaVendedores
            // 
            this.menuListaVendedores.Name = "menuListaVendedores";
            this.menuListaVendedores.Size = new System.Drawing.Size(162, 22);
            this.menuListaVendedores.Text = "Lista vendedores";
            // 
            // menuUnlogin
            // 
            this.menuUnlogin.Name = "menuUnlogin";
            this.menuUnlogin.Size = new System.Drawing.Size(61, 20);
            this.menuUnlogin.Text = "Unlogin";
            this.menuUnlogin.Click += new System.EventHandler(this.menuUnlogin_Click);
            // 
            // formprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formprincipal";
            this.Text = "Sistema de Reclamos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuReclamo;
        private System.Windows.Forms.ToolStripMenuItem menuHacerReclamo;
        private System.Windows.Forms.ToolStripMenuItem menuHistorialReclamos;
        private System.Windows.Forms.ToolStripMenuItem menuReclamosSolucionados;
        private System.Windows.Forms.ToolStripMenuItem menuUnlogin;
        private System.Windows.Forms.ToolStripMenuItem menuRevisarReclamos;
        private System.Windows.Forms.ToolStripMenuItem menuPuntuaciones;
        private System.Windows.Forms.ToolStripMenuItem menuPuntuarVendedor;
        private System.Windows.Forms.ToolStripMenuItem menuPuntuacionesDadas;
        private System.Windows.Forms.ToolStripMenuItem menuAdmin;
        private System.Windows.Forms.ToolStripMenuItem menuListaUsuarios;
        private System.Windows.Forms.ToolStripMenuItem menuListaVendedores;
        private System.Windows.Forms.ToolStripMenuItem menuPuntuacionesRecibidas;
        private System.Windows.Forms.ToolStripMenuItem menuHistorialMensajes;
    }
}
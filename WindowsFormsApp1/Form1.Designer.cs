namespace WindowsFormsApp1
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reclamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hacerReclamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialReclamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puntuacionesDadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reclamosSolucionadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reclamosToolStripMenuItem,
            this.vendedoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reclamosToolStripMenuItem
            // 
            this.reclamosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hacerReclamoToolStripMenuItem,
            this.historialReclamosToolStripMenuItem,
            this.reclamosSolucionadosToolStripMenuItem});
            this.reclamosToolStripMenuItem.Name = "reclamosToolStripMenuItem";
            this.reclamosToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.reclamosToolStripMenuItem.Text = "Reclamos";
            this.reclamosToolStripMenuItem.Click += new System.EventHandler(this.reclamosToolStripMenuItem_Click);
            // 
            // hacerReclamoToolStripMenuItem
            // 
            this.hacerReclamoToolStripMenuItem.Name = "hacerReclamoToolStripMenuItem";
            this.hacerReclamoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hacerReclamoToolStripMenuItem.Text = "Hacer reclamo";
            // 
            // historialReclamosToolStripMenuItem
            // 
            this.historialReclamosToolStripMenuItem.Name = "historialReclamosToolStripMenuItem";
            this.historialReclamosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.historialReclamosToolStripMenuItem.Text = "Historial reclamos";
            // 
            // vendedoresToolStripMenuItem
            // 
            this.vendedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.puntuacionesDadasToolStripMenuItem});
            this.vendedoresToolStripMenuItem.Name = "vendedoresToolStripMenuItem";
            this.vendedoresToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.vendedoresToolStripMenuItem.Text = "Vendedores";
            // 
            // puntuacionesDadasToolStripMenuItem
            // 
            this.puntuacionesDadasToolStripMenuItem.Name = "puntuacionesDadasToolStripMenuItem";
            this.puntuacionesDadasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.puntuacionesDadasToolStripMenuItem.Text = "Puntuaciones dadas";
            // 
            // reclamosSolucionadosToolStripMenuItem
            // 
            this.reclamosSolucionadosToolStripMenuItem.Name = "reclamosSolucionadosToolStripMenuItem";
            this.reclamosSolucionadosToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.reclamosSolucionadosToolStripMenuItem.Text = "Reclamos solucionados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reclamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hacerReclamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historialReclamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puntuacionesDadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reclamosSolucionadosToolStripMenuItem;
    }
}


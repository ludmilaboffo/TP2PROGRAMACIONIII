
namespace Grupo4TPWinform
{
    partial class frmPrincipal
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
            this.tsmListarArts = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevaMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevaCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBuscar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmListarArts,
            this.agregarArticulosToolStripMenuItem,
            this.modificarArticulosToolStripMenuItem,
            this.tsmBuscar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(523, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmListarArts
            // 
            this.tsmListarArts.Name = "tsmListarArts";
            this.tsmListarArts.Size = new System.Drawing.Size(123, 20);
            this.tsmListarArts.Text = "Listado de Articulos";
            this.tsmListarArts.Click += new System.EventHandler(this.tsmListarArts_Click);
            // 
            // agregarArticulosToolStripMenuItem
            // 
            this.agregarArticulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevaMarcaToolStripMenuItem});
            this.agregarArticulosToolStripMenuItem.Name = "agregarArticulosToolStripMenuItem";
            this.agregarArticulosToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.agregarArticulosToolStripMenuItem.Text = "Marcas";
            // 
            // agregarNuevaMarcaToolStripMenuItem
            // 
            this.agregarNuevaMarcaToolStripMenuItem.Name = "agregarNuevaMarcaToolStripMenuItem";
            this.agregarNuevaMarcaToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.agregarNuevaMarcaToolStripMenuItem.Text = "Agregar nueva marca";
            // 
            // modificarArticulosToolStripMenuItem
            // 
            this.modificarArticulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevaCategoriaToolStripMenuItem});
            this.modificarArticulosToolStripMenuItem.Name = "modificarArticulosToolStripMenuItem";
            this.modificarArticulosToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.modificarArticulosToolStripMenuItem.Text = "Categorias";
            // 
            // agregarNuevaCategoriaToolStripMenuItem
            // 
            this.agregarNuevaCategoriaToolStripMenuItem.Name = "agregarNuevaCategoriaToolStripMenuItem";
            this.agregarNuevaCategoriaToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.agregarNuevaCategoriaToolStripMenuItem.Text = "Agregar nueva categoria";
            // 
            // tsmBuscar
            // 
            this.tsmBuscar.Name = "tsmBuscar";
            this.tsmBuscar.Size = new System.Drawing.Size(132, 20);
            this.tsmBuscar.Text = "Busqueda de Articulo";
            this.tsmBuscar.Click += new System.EventHandler(this.tsmBuscar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(523, 443);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmListarArts;
        private System.Windows.Forms.ToolStripMenuItem agregarArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmBuscar;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevaMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevaCategoriaToolStripMenuItem;
    }
}
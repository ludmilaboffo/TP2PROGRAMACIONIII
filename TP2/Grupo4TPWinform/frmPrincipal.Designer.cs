
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
            System.Windows.Forms.MenuStrip menuStrip1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.tsmListarArts = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevaMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevaCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBuscar = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = System.Drawing.Color.DarkMagenta;
            menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            menuStrip1.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            menuStrip1.GripMargin = new System.Windows.Forms.Padding(2);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmListarArts,
            this.agregarArticulosToolStripMenuItem,
            this.modificarArticulosToolStripMenuItem,
            this.tsmBuscar});
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(501, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmListarArts
            // 
            this.tsmListarArts.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmListarArts.ForeColor = System.Drawing.Color.White;
            this.tsmListarArts.Name = "tsmListarArts";
            this.tsmListarArts.Size = new System.Drawing.Size(161, 20);
            this.tsmListarArts.Text = "Listado de Articulos";
            this.tsmListarArts.Click += new System.EventHandler(this.tsmListarArts_Click);
            // 
            // agregarArticulosToolStripMenuItem
            // 
            this.agregarArticulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevaMarcaToolStripMenuItem});
            this.agregarArticulosToolStripMenuItem.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarArticulosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.agregarArticulosToolStripMenuItem.Name = "agregarArticulosToolStripMenuItem";
            this.agregarArticulosToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.agregarArticulosToolStripMenuItem.Text = "Marcas";
            // 
            // agregarNuevaMarcaToolStripMenuItem
            // 
            this.agregarNuevaMarcaToolStripMenuItem.Name = "agregarNuevaMarcaToolStripMenuItem";
            this.agregarNuevaMarcaToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.agregarNuevaMarcaToolStripMenuItem.Text = "Agregar nueva marca";
            // 
            // modificarArticulosToolStripMenuItem
            // 
            this.modificarArticulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevaCategoriaToolStripMenuItem});
            this.modificarArticulosToolStripMenuItem.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarArticulosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.modificarArticulosToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.modificarArticulosToolStripMenuItem.Name = "modificarArticulosToolStripMenuItem";
            this.modificarArticulosToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.modificarArticulosToolStripMenuItem.Text = "Categorias";
            this.modificarArticulosToolStripMenuItem.ForeColorChanged += new System.EventHandler(this.tsmBuscar_Click);
            // 
            // agregarNuevaCategoriaToolStripMenuItem
            // 
            this.agregarNuevaCategoriaToolStripMenuItem.Name = "agregarNuevaCategoriaToolStripMenuItem";
            this.agregarNuevaCategoriaToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.agregarNuevaCategoriaToolStripMenuItem.Text = "Agregar nueva categoria";
            // 
            // tsmBuscar
            // 
            this.tsmBuscar.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmBuscar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsmBuscar.Name = "tsmBuscar";
            this.tsmBuscar.Size = new System.Drawing.Size(168, 20);
            this.tsmBuscar.Text = "Busqueda de Articulo";
            this.tsmBuscar.Click += new System.EventHandler(this.tsmBuscar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(493, 559);
            this.Controls.Add(menuStrip1);
            this.Font = new System.Drawing.Font("Bodoni MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de articulos";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem tsmListarArts;
        private System.Windows.Forms.ToolStripMenuItem agregarArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevaMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevaCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmBuscar;
    }
}

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
            this.articulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarArticulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articulosToolStripMenuItem,
            this.agregarArticulosToolStripMenuItem,
            this.modificarArticulosToolStripMenuItem,
            this.eliminarArticulosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(610, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // articulosToolStripMenuItem
            // 
            this.articulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarToolStripMenuItem,
            this.buscarToolStripMenuItem});
            this.articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
            this.articulosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.articulosToolStripMenuItem.Text = "Articulos";
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarToolStripMenuItem.Text = "Listar";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.buscarToolStripMenuItem.Text = "Buscar";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // agregarArticulosToolStripMenuItem
            // 
            this.agregarArticulosToolStripMenuItem.Name = "agregarArticulosToolStripMenuItem";
            this.agregarArticulosToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.agregarArticulosToolStripMenuItem.Text = "Agregar Articulos";
            this.agregarArticulosToolStripMenuItem.Click += new System.EventHandler(this.agregarArticulosToolStripMenuItem_Click);
            // 
            // modificarArticulosToolStripMenuItem
            // 
            this.modificarArticulosToolStripMenuItem.Name = "modificarArticulosToolStripMenuItem";
            this.modificarArticulosToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.modificarArticulosToolStripMenuItem.Text = "Modificar Articulos";
            this.modificarArticulosToolStripMenuItem.Click += new System.EventHandler(this.modificarArticulosToolStripMenuItem_Click);
            // 
            // eliminarArticulosToolStripMenuItem
            // 
            this.eliminarArticulosToolStripMenuItem.Name = "eliminarArticulosToolStripMenuItem";
            this.eliminarArticulosToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.eliminarArticulosToolStripMenuItem.Text = "Eliminar Articulos";
            this.eliminarArticulosToolStripMenuItem.Click += new System.EventHandler(this.eliminarArticulosToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 271);
            this.Controls.Add(this.menuStrip1);
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
        private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarArticulosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarArticulosToolStripMenuItem;
    }
}
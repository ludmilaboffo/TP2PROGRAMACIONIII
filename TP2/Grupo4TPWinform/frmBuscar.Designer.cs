
namespace Grupo4TPWinform
{
    partial class frmBuscar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gpbBuscar = new System.Windows.Forms.GroupBox();
            this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lbCampo = new System.Windows.Forms.Label();
            this.lblArticulosBuscados = new System.Windows.Forms.Label();
            this.dgvListarBusqueda = new System.Windows.Forms.DataGridView();
            this.gpbBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbBuscar
            // 
            this.gpbBuscar.BackColor = System.Drawing.Color.Thistle;
            this.gpbBuscar.Controls.Add(this.txtFiltroAvanzado);
            this.gpbBuscar.Controls.Add(this.cboCriterio);
            this.gpbBuscar.Controls.Add(this.cboCampo);
            this.gpbBuscar.Controls.Add(this.btnFiltro);
            this.gpbBuscar.Controls.Add(this.lblCategoria);
            this.gpbBuscar.Controls.Add(this.lblMarca);
            this.gpbBuscar.Controls.Add(this.lbCampo);
            this.gpbBuscar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.gpbBuscar.Location = new System.Drawing.Point(23, 21);
            this.gpbBuscar.Name = "gpbBuscar";
            this.gpbBuscar.Size = new System.Drawing.Size(690, 151);
            this.gpbBuscar.TabIndex = 0;
            this.gpbBuscar.TabStop = false;
            this.gpbBuscar.Text = "Buscar";
            this.gpbBuscar.Enter += new System.EventHandler(this.gpbBuscar_Enter);
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(156, 98);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(340, 20);
            this.txtFiltroAvanzado.TabIndex = 15;
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(155, 58);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(342, 21);
            this.cboCriterio.TabIndex = 14;
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(155, 19);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(342, 21);
            this.cboCampo.TabIndex = 12;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cmbBuscarMarca_SelectedIndexChanged);
            // 
            // btnFiltro
            // 
            this.btnFiltro.BackColor = System.Drawing.Color.White;
            this.btnFiltro.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnFiltro.Location = new System.Drawing.Point(519, 93);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnFiltro.TabIndex = 11;
            this.btnFiltro.Text = "Buscar";
            this.btnFiltro.UseVisualStyleBackColor = false;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblCategoria.Location = new System.Drawing.Point(22, 102);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(128, 13);
            this.lblCategoria.TabIndex = 9;
            this.lblCategoria.Text = "Filtro avanzado:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblMarca.Location = new System.Drawing.Point(78, 61);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(67, 13);
            this.lblMarca.TabIndex = 6;
            this.lblMarca.Text = "Criterio:";
            // 
            // lbCampo
            // 
            this.lbCampo.AutoSize = true;
            this.lbCampo.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCampo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbCampo.Location = new System.Drawing.Point(87, 19);
            this.lbCampo.Name = "lbCampo";
            this.lbCampo.Size = new System.Drawing.Size(54, 13);
            this.lbCampo.TabIndex = 0;
            this.lbCampo.Text = "Campo:";
            // 
            // lblArticulosBuscados
            // 
            this.lblArticulosBuscados.AutoSize = true;
            this.lblArticulosBuscados.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulosBuscados.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.lblArticulosBuscados.Location = new System.Drawing.Point(33, 179);
            this.lblArticulosBuscados.Name = "lblArticulosBuscados";
            this.lblArticulosBuscados.Size = new System.Drawing.Size(166, 16);
            this.lblArticulosBuscados.TabIndex = 2;
            this.lblArticulosBuscados.Text = "Articulos Buscados";
            // 
            // dgvListarBusqueda
            // 
            this.dgvListarBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListarBusqueda.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListarBusqueda.Location = new System.Drawing.Point(33, 198);
            this.dgvListarBusqueda.Name = "dgvListarBusqueda";
            this.dgvListarBusqueda.RowTemplate.ReadOnly = true;
            this.dgvListarBusqueda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListarBusqueda.Size = new System.Drawing.Size(538, 126);
            this.dgvListarBusqueda.TabIndex = 1;
            this.dgvListarBusqueda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListarBusqueda_CellContentClick_1);
            // 
            // frmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(732, 401);
            this.Controls.Add(this.lblArticulosBuscados);
            this.Controls.Add(this.dgvListarBusqueda);
            this.Controls.Add(this.gpbBuscar);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "frmBuscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Articulos";
            this.Load += new System.EventHandler(this.frmBuscar_Load);
            this.gpbBuscar.ResumeLayout(false);
            this.gpbBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarBusqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbBuscar;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lbCampo;
        private System.Windows.Forms.Label lblArticulosBuscados;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.TextBox txtFiltroAvanzado;
        private System.Windows.Forms.DataGridView dgvListarBusqueda;
    }
}
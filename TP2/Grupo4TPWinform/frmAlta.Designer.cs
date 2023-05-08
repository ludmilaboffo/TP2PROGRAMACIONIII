namespace Grupo4TPWinform
{
    partial class frmAlta
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
            this.lbCodigoAlta = new System.Windows.Forms.Label();
            this.lbNombreAlta = new System.Windows.Forms.Label();
            this.lbMarcaAlta = new System.Windows.Forms.Label();
            this.lbDescripcionAlta = new System.Windows.Forms.Label();
            this.lbPrecioAlta = new System.Windows.Forms.Label();
            this.lbCategoriaAlta = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.lbImagen = new System.Windows.Forms.Label();
            this.pbArt = new System.Windows.Forms.PictureBox();
            this.btnAgregarImg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbArt)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCodigoAlta
            // 
            this.lbCodigoAlta.AutoSize = true;
            this.lbCodigoAlta.Location = new System.Drawing.Point(41, 68);
            this.lbCodigoAlta.Name = "lbCodigoAlta";
            this.lbCodigoAlta.Size = new System.Drawing.Size(40, 13);
            this.lbCodigoAlta.TabIndex = 0;
            this.lbCodigoAlta.Text = "Codigo";
            // 
            // lbNombreAlta
            // 
            this.lbNombreAlta.AutoSize = true;
            this.lbNombreAlta.Location = new System.Drawing.Point(38, 105);
            this.lbNombreAlta.Name = "lbNombreAlta";
            this.lbNombreAlta.Size = new System.Drawing.Size(44, 13);
            this.lbNombreAlta.TabIndex = 0;
            this.lbNombreAlta.Text = "Nombre";
            // 
            // lbMarcaAlta
            // 
            this.lbMarcaAlta.AutoSize = true;
            this.lbMarcaAlta.Location = new System.Drawing.Point(39, 251);
            this.lbMarcaAlta.Name = "lbMarcaAlta";
            this.lbMarcaAlta.Size = new System.Drawing.Size(37, 13);
            this.lbMarcaAlta.TabIndex = 0;
            this.lbMarcaAlta.Text = "Marca";
            // 
            // lbDescripcionAlta
            // 
            this.lbDescripcionAlta.AutoSize = true;
            this.lbDescripcionAlta.Location = new System.Drawing.Point(38, 142);
            this.lbDescripcionAlta.Name = "lbDescripcionAlta";
            this.lbDescripcionAlta.Size = new System.Drawing.Size(63, 13);
            this.lbDescripcionAlta.TabIndex = 1;
            this.lbDescripcionAlta.Text = "Descripcion";
            // 
            // lbPrecioAlta
            // 
            this.lbPrecioAlta.AutoSize = true;
            this.lbPrecioAlta.Location = new System.Drawing.Point(41, 180);
            this.lbPrecioAlta.Name = "lbPrecioAlta";
            this.lbPrecioAlta.Size = new System.Drawing.Size(37, 13);
            this.lbPrecioAlta.TabIndex = 0;
            this.lbPrecioAlta.Text = "Precio";
            // 
            // lbCategoriaAlta
            // 
            this.lbCategoriaAlta.AutoSize = true;
            this.lbCategoriaAlta.Location = new System.Drawing.Point(38, 287);
            this.lbCategoriaAlta.Name = "lbCategoriaAlta";
            this.lbCategoriaAlta.Size = new System.Drawing.Size(52, 13);
            this.lbCategoriaAlta.TabIndex = 0;
            this.lbCategoriaAlta.Text = "Categoria";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(112, 68);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(272, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(112, 105);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(272, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(112, 140);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(272, 20);
            this.txtDescripcion.TabIndex = 3;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(112, 174);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(272, 20);
            this.txtPrecio.TabIndex = 4;
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(112, 248);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(272, 21);
            this.cboMarca.TabIndex = 7;
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(112, 284);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(272, 21);
            this.cboCategoria.TabIndex = 8;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(98, 328);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 30);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(300, 328);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 30);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(112, 209);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(272, 20);
            this.txtURL.TabIndex = 5;
            this.txtURL.Leave += new System.EventHandler(this.txtURL_Leave);
            // 
            // lbImagen
            // 
            this.lbImagen.AutoSize = true;
            this.lbImagen.Location = new System.Drawing.Point(41, 215);
            this.lbImagen.Name = "lbImagen";
            this.lbImagen.Size = new System.Drawing.Size(67, 13);
            this.lbImagen.TabIndex = 0;
            this.lbImagen.Text = "Imagen URL";
            // 
            // pbArt
            // 
            this.pbArt.Location = new System.Drawing.Point(452, 74);
            this.pbArt.Name = "pbArt";
            this.pbArt.Size = new System.Drawing.Size(227, 195);
            this.pbArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArt.TabIndex = 19;
            this.pbArt.TabStop = false;
            // 
            // btnAgregarImg
            // 
            this.btnAgregarImg.Location = new System.Drawing.Point(390, 205);
            this.btnAgregarImg.Name = "btnAgregarImg";
            this.btnAgregarImg.Size = new System.Drawing.Size(34, 26);
            this.btnAgregarImg.TabIndex = 6;
            this.btnAgregarImg.Text = "→";
            this.btnAgregarImg.UseVisualStyleBackColor = true;
            this.btnAgregarImg.Click += new System.EventHandler(this.btnAgregarImg_Click);
            // 
            // frmAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 381);
            this.Controls.Add(this.btnAgregarImg);
            this.Controls.Add(this.pbArt);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.lbImagen);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lbPrecioAlta);
            this.Controls.Add(this.lbCategoriaAlta);
            this.Controls.Add(this.lbDescripcionAlta);
            this.Controls.Add(this.lbMarcaAlta);
            this.Controls.Add(this.lbNombreAlta);
            this.Controls.Add(this.lbCodigoAlta);
            this.Name = "frmAlta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "0";
            this.Load += new System.EventHandler(this.frmAlta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCodigoAlta;
        private System.Windows.Forms.Label lbNombreAlta;
        private System.Windows.Forms.Label lbMarcaAlta;
        private System.Windows.Forms.Label lbDescripcionAlta;
        private System.Windows.Forms.Label lbPrecioAlta;
        private System.Windows.Forms.Label lbCategoriaAlta;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label lbImagen;
        private System.Windows.Forms.PictureBox pbArt;
        private System.Windows.Forms.Button btnAgregarImg;
    }
}
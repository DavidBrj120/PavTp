
namespace PavTpGrupo11.Formularios
{
    partial class ABM_materialescs
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
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.MaskedTextBox();
            this.txtCodigo = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUnidadMedida = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grillaMateriales = new System.Windows.Forms.DataGridView();
            this.txtCodProv = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDataTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaMateriales)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(618, 193);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(157, 20);
            this.txtPrecio.TabIndex = 66;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(782, 510);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 35);
            this.btnSalir.TabIndex = 65;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(657, 265);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(118, 32);
            this.btnLimpiarCampos.TabIndex = 64;
            this.btnLimpiarCampos.Text = "Limpiar campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(618, 105);
            this.txtCantidad.Mask = "999999";
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(157, 20);
            this.txtCantidad.TabIndex = 57;
            this.txtCantidad.ValidatingType = typeof(int);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(618, 76);
            this.txtCodigo.Mask = "999999";
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(157, 20);
            this.txtCodigo.TabIndex = 56;
            this.txtCodigo.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(549, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 55;
            this.label6.Text = "Precio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(447, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 18);
            this.label5.TabIndex = 54;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(447, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 18);
            this.label4.TabIndex = 53;
            this.label4.Text = "Código de Provedor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(532, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 52;
            this.label3.Text = "Cantidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(405, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 18);
            this.label2.TabIndex = 51;
            this.label2.Text = "Código Unidad de Medida:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(544, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 50;
            this.label1.Text = "Código:";
            // 
            // txtUnidadMedida
            // 
            this.txtUnidadMedida.Location = new System.Drawing.Point(618, 137);
            this.txtUnidadMedida.Margin = new System.Windows.Forms.Padding(2);
            this.txtUnidadMedida.Name = "txtUnidadMedida";
            this.txtUnidadMedida.Size = new System.Drawing.Size(158, 20);
            this.txtUnidadMedida.TabIndex = 68;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PavTpGrupo11.Properties.Resources.proveedor_hotelero;
            this.pictureBox1.Location = new System.Drawing.Point(130, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = global::PavTpGrupo11.Properties.Resources.boton_eliminar;
            this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrar.Location = new System.Drawing.Point(386, 504);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(108, 29);
            this.btnBorrar.TabIndex = 79;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = global::PavTpGrupo11.Properties.Resources.editar;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(239, 504);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(108, 29);
            this.btnModificar.TabIndex = 78;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Image = global::PavTpGrupo11.Properties.Resources.agregar_usuario;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(82, 504);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(108, 29);
            this.btnAgregar.TabIndex = 77;
            this.btnAgregar.Text = "Agregar ";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // grillaMateriales
            // 
            this.grillaMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaMateriales.Location = new System.Drawing.Point(70, 302);
            this.grillaMateriales.Margin = new System.Windows.Forms.Padding(2);
            this.grillaMateriales.Name = "grillaMateriales";
            this.grillaMateriales.RowHeadersWidth = 51;
            this.grillaMateriales.RowTemplate.Height = 24;
            this.grillaMateriales.Size = new System.Drawing.Size(686, 196);
            this.grillaMateriales.TabIndex = 80;
            // 
            // txtCodProv
            // 
            this.txtCodProv.Location = new System.Drawing.Point(619, 165);
            this.txtCodProv.Name = "txtCodProv";
            this.txtCodProv.Size = new System.Drawing.Size(157, 20);
            this.txtCodProv.TabIndex = 81;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(469, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 18);
            this.label7.TabIndex = 82;
            this.label7.Text = "Fecha de Ingreso:";
            // 
            // txtDataTime
            // 
            this.txtDataTime.AllowDrop = true;
            this.txtDataTime.CustomFormat = "dd-MM-yyyy HH:mm";
            this.txtDataTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDataTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtDataTime.Location = new System.Drawing.Point(618, 221);
            this.txtDataTime.Name = "txtDataTime";
            this.txtDataTime.Size = new System.Drawing.Size(210, 20);
            this.txtDataTime.TabIndex = 84;
            this.txtDataTime.Value = new System.DateTime(2022, 10, 1, 0, 0, 0, 0);
            this.txtDataTime.ValueChanged += new System.EventHandler(this.txtDataTime_ValueChanged);
            // 
            // ABM_materialescs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(904, 556);
            this.Controls.Add(this.txtDataTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCodProv);
            this.Controls.Add(this.grillaMateriales);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtUnidadMedida);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ABM_materialescs";
            this.Text = "ABM_materialescs";
            this.Load += new System.EventHandler(this.ABM_materialescs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaMateriales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.MaskedTextBox txtCantidad;
        private System.Windows.Forms.MaskedTextBox txtCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUnidadMedida;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView grillaMateriales;
        private System.Windows.Forms.TextBox txtCodProv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker txtDataTime;
    }
}
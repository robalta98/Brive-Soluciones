namespace MVCBrivéSolutions
{
    partial class AgregarNuevosProductoaInventario
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
            this.box_agregarInventario = new System.Windows.Forms.GroupBox();
            this.txt_precioUnitario = new System.Windows.Forms.TextBox();
            this.txt_codigoBarras = new System.Windows.Forms.TextBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.txt_nombreProducto = new System.Windows.Forms.TextBox();
            this.combo_empresa = new System.Windows.Forms.ComboBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.box_agregarInventario.SuspendLayout();
            this.SuspendLayout();
            // 
            // box_agregarInventario
            // 
            this.box_agregarInventario.Controls.Add(this.txt_precioUnitario);
            this.box_agregarInventario.Controls.Add(this.txt_codigoBarras);
            this.box_agregarInventario.Controls.Add(this.txt_cantidad);
            this.box_agregarInventario.Controls.Add(this.txt_nombreProducto);
            this.box_agregarInventario.Controls.Add(this.combo_empresa);
            this.box_agregarInventario.Controls.Add(this.btn_cancelar);
            this.box_agregarInventario.Controls.Add(this.btn_agregar);
            this.box_agregarInventario.Controls.Add(this.label5);
            this.box_agregarInventario.Controls.Add(this.label4);
            this.box_agregarInventario.Controls.Add(this.label3);
            this.box_agregarInventario.Controls.Add(this.label2);
            this.box_agregarInventario.Controls.Add(this.label1);
            this.box_agregarInventario.Location = new System.Drawing.Point(12, 12);
            this.box_agregarInventario.Name = "box_agregarInventario";
            this.box_agregarInventario.Size = new System.Drawing.Size(358, 309);
            this.box_agregarInventario.TabIndex = 0;
            this.box_agregarInventario.TabStop = false;
            this.box_agregarInventario.Text = "Seleccióna la sucursal para ingresar nuevos productos al inventario";
            // 
            // txt_precioUnitario
            // 
            this.txt_precioUnitario.Location = new System.Drawing.Point(132, 188);
            this.txt_precioUnitario.Name = "txt_precioUnitario";
            this.txt_precioUnitario.Size = new System.Drawing.Size(208, 20);
            this.txt_precioUnitario.TabIndex = 11;
            // 
            // txt_codigoBarras
            // 
            this.txt_codigoBarras.Location = new System.Drawing.Point(132, 103);
            this.txt_codigoBarras.Name = "txt_codigoBarras";
            this.txt_codigoBarras.Size = new System.Drawing.Size(208, 20);
            this.txt_codigoBarras.TabIndex = 10;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(132, 141);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(208, 20);
            this.txt_cantidad.TabIndex = 9;
            this.txt_cantidad.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_nombreProducto
            // 
            this.txt_nombreProducto.Location = new System.Drawing.Point(132, 64);
            this.txt_nombreProducto.Name = "txt_nombreProducto";
            this.txt_nombreProducto.Size = new System.Drawing.Size(208, 20);
            this.txt_nombreProducto.TabIndex = 8;
            // 
            // combo_empresa
            // 
            this.combo_empresa.FormattingEnabled = true;
            this.combo_empresa.Location = new System.Drawing.Point(132, 30);
            this.combo_empresa.Name = "combo_empresa";
            this.combo_empresa.Size = new System.Drawing.Size(208, 21);
            this.combo_empresa.TabIndex = 7;
            this.combo_empresa.TextChanged += new System.EventHandler(this.combo_empresa_TextChanged);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(265, 241);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(79, 241);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 5;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio Unitario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Codigo de Barras:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Producto:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sucursal:";
            // 
            // AgregarNuevosProductoaInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(389, 345);
            this.Controls.Add(this.box_agregarInventario);
            this.Name = "AgregarNuevosProductoaInventario";
            this.Text = "AgregarNuevosProductoaInventario";
            this.Load += new System.EventHandler(this.AgregarInventario_Load);
            this.box_agregarInventario.ResumeLayout(false);
            this.box_agregarInventario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox box_agregarInventario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.TextBox txt_precioUnitario;
        private System.Windows.Forms.TextBox txt_codigoBarras;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.TextBox txt_nombreProducto;
        private System.Windows.Forms.ComboBox combo_empresa;
    }
}
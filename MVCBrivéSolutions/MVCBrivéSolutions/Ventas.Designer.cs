namespace MVCBrivéSolutions
{
    partial class Ventas
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
            this.box_ventas = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_nombreProducto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_empresa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.numeric_cantidadProduc = new System.Windows.Forms.NumericUpDown();
            this.box_ventas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_cantidadProduc)).BeginInit();
            this.SuspendLayout();
            // 
            // box_ventas
            // 
            this.box_ventas.Controls.Add(this.numeric_cantidadProduc);
            this.box_ventas.Controls.Add(this.label3);
            this.box_ventas.Controls.Add(this.combo_nombreProducto);
            this.box_ventas.Controls.Add(this.label2);
            this.box_ventas.Controls.Add(this.combo_empresa);
            this.box_ventas.Controls.Add(this.label1);
            this.box_ventas.Controls.Add(this.btn_cancelar);
            this.box_ventas.Controls.Add(this.btn_agregar);
            this.box_ventas.Location = new System.Drawing.Point(12, 12);
            this.box_ventas.Name = "box_ventas";
            this.box_ventas.Size = new System.Drawing.Size(234, 288);
            this.box_ventas.TabIndex = 0;
            this.box_ventas.TabStop = false;
            this.box_ventas.Text = "Seleccióna la empresa para hacer ventas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cantidad:";
            // 
            // combo_nombreProducto
            // 
            this.combo_nombreProducto.FormattingEnabled = true;
            this.combo_nombreProducto.Location = new System.Drawing.Point(9, 131);
            this.combo_nombreProducto.Name = "combo_nombreProducto";
            this.combo_nombreProducto.Size = new System.Drawing.Size(199, 21);
            this.combo_nombreProducto.TabIndex = 9;
            this.combo_nombreProducto.TextChanged += new System.EventHandler(this.combo_nombreProducto_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre del Producto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // combo_empresa
            // 
            this.combo_empresa.FormattingEnabled = true;
            this.combo_empresa.Location = new System.Drawing.Point(9, 63);
            this.combo_empresa.Name = "combo_empresa";
            this.combo_empresa.Size = new System.Drawing.Size(199, 21);
            this.combo_empresa.TabIndex = 7;
            this.combo_empresa.TextChanged += new System.EventHandler(this.combo_empresa_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Empresa:";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(133, 259);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(27, 259);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 4;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // numeric_cantidadProduc
            // 
            this.numeric_cantidadProduc.Location = new System.Drawing.Point(9, 206);
            this.numeric_cantidadProduc.Name = "numeric_cantidadProduc";
            this.numeric_cantidadProduc.Size = new System.Drawing.Size(199, 20);
            this.numeric_cantidadProduc.TabIndex = 11;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(283, 333);
            this.Controls.Add(this.box_ventas);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.box_ventas.ResumeLayout(false);
            this.box_ventas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_cantidadProduc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox box_ventas;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_nombreProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_empresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numeric_cantidadProduc;
    }
}
namespace MVCBrivéSolutions
{
    partial class MVCBrive
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
            this.btn_altaSucursales = new System.Windows.Forms.Button();
            this.btn_agregarInventario = new System.Windows.Forms.Button();
            this.btn_Ventas = new System.Windows.Forms.Button();
            this.btn_inventario = new System.Windows.Forms.Button();
            this.box_menu = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_altas = new System.Windows.Forms.Button();
            this.box_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_altaSucursales
            // 
            this.btn_altaSucursales.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_altaSucursales.Location = new System.Drawing.Point(22, 28);
            this.btn_altaSucursales.Name = "btn_altaSucursales";
            this.btn_altaSucursales.Size = new System.Drawing.Size(243, 74);
            this.btn_altaSucursales.TabIndex = 0;
            this.btn_altaSucursales.Text = "Alta Sucursales";
            this.btn_altaSucursales.UseVisualStyleBackColor = false;
            this.btn_altaSucursales.Click += new System.EventHandler(this.btn_altaSucursales_Click);
            // 
            // btn_agregarInventario
            // 
            this.btn_agregarInventario.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_agregarInventario.Location = new System.Drawing.Point(23, 128);
            this.btn_agregarInventario.Name = "btn_agregarInventario";
            this.btn_agregarInventario.Size = new System.Drawing.Size(243, 78);
            this.btn_agregarInventario.TabIndex = 1;
            this.btn_agregarInventario.Text = "Agregar Nuevos Productos a Inventario";
            this.btn_agregarInventario.UseVisualStyleBackColor = false;
            this.btn_agregarInventario.Click += new System.EventHandler(this.btn_agregarInventario_Click);
            // 
            // btn_Ventas
            // 
            this.btn_Ventas.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_Ventas.Location = new System.Drawing.Point(22, 340);
            this.btn_Ventas.Name = "btn_Ventas";
            this.btn_Ventas.Size = new System.Drawing.Size(243, 82);
            this.btn_Ventas.TabIndex = 2;
            this.btn_Ventas.Text = "Ventas";
            this.btn_Ventas.UseVisualStyleBackColor = false;
            this.btn_Ventas.Click += new System.EventHandler(this.btn_Ventas_Click);
            // 
            // btn_inventario
            // 
            this.btn_inventario.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_inventario.Location = new System.Drawing.Point(23, 453);
            this.btn_inventario.Name = "btn_inventario";
            this.btn_inventario.Size = new System.Drawing.Size(243, 75);
            this.btn_inventario.TabIndex = 3;
            this.btn_inventario.Text = "Inventario";
            this.btn_inventario.UseVisualStyleBackColor = false;
            this.btn_inventario.Click += new System.EventHandler(this.button4_Click);
            // 
            // box_menu
            // 
            this.box_menu.Controls.Add(this.btn_altas);
            this.box_menu.Controls.Add(this.btn_altaSucursales);
            this.box_menu.Controls.Add(this.btn_inventario);
            this.box_menu.Controls.Add(this.btn_agregarInventario);
            this.box_menu.Controls.Add(this.btn_Ventas);
            this.box_menu.Location = new System.Drawing.Point(12, 51);
            this.box_menu.Name = "box_menu";
            this.box_menu.Size = new System.Drawing.Size(286, 560);
            this.box_menu.TabIndex = 4;
            this.box_menu.TabStop = false;
            this.box_menu.Text = "Seleccióna una opción del ménu";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(35, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btn_altas
            // 
            this.btn_altas.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_altas.Location = new System.Drawing.Point(22, 227);
            this.btn_altas.Name = "btn_altas";
            this.btn_altas.Size = new System.Drawing.Size(243, 82);
            this.btn_altas.TabIndex = 4;
            this.btn_altas.Text = "Altas de Inventario";
            this.btn_altas.UseVisualStyleBackColor = false;
            this.btn_altas.Click += new System.EventHandler(this.btn_altas_Click);
            // 
            // MVCBrive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(326, 649);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.box_menu);
            this.Name = "MVCBrive";
            this.Text = "MVCBrivé";
            this.box_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_altaSucursales;
        private System.Windows.Forms.Button btn_agregarInventario;
        private System.Windows.Forms.Button btn_Ventas;
        private System.Windows.Forms.Button btn_inventario;
        private System.Windows.Forms.GroupBox box_menu;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_altas;
    }
}


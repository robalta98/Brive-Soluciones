namespace MVCBrivéSolutions
{
    partial class AltaSucursales
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
            this.label1 = new System.Windows.Forms.Label();
            this.box_altaSucursales = new System.Windows.Forms.GroupBox();
            this.txt_sucursal = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.box_altaSucursales.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Sucursal:";
            // 
            // box_altaSucursales
            // 
            this.box_altaSucursales.Controls.Add(this.btn_cancelar);
            this.box_altaSucursales.Controls.Add(this.btn_agregar);
            this.box_altaSucursales.Controls.Add(this.txt_sucursal);
            this.box_altaSucursales.Controls.Add(this.label1);
            this.box_altaSucursales.Location = new System.Drawing.Point(12, 12);
            this.box_altaSucursales.Name = "box_altaSucursales";
            this.box_altaSucursales.Size = new System.Drawing.Size(200, 283);
            this.box_altaSucursales.TabIndex = 1;
            this.box_altaSucursales.TabStop = false;
            this.box_altaSucursales.Text = "Alta de Sucursales";
            // 
            // txt_sucursal
            // 
            this.txt_sucursal.Location = new System.Drawing.Point(17, 74);
            this.txt_sucursal.Name = "txt_sucursal";
            this.txt_sucursal.Size = new System.Drawing.Size(155, 20);
            this.txt_sucursal.TabIndex = 1;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(17, 144);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 2;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(98, 144);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 3;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // AltaSucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(229, 312);
            this.Controls.Add(this.box_altaSucursales);
            this.Name = "AltaSucursales";
            this.Text = "AltaSucursales";
            this.Load += new System.EventHandler(this.AltaSucursales_Load);
            this.box_altaSucursales.ResumeLayout(false);
            this.box_altaSucursales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox box_altaSucursales;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.TextBox txt_sucursal;
    }
}
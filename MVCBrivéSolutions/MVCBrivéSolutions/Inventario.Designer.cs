namespace MVCBrivéSolutions
{
    partial class Inventario
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
            this.box_inventario = new System.Windows.Forms.GroupBox();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.dataGridView_Inventario = new System.Windows.Forms.DataGridView();
            this.combo_empresa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.box_inventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Inventario)).BeginInit();
            this.SuspendLayout();
            // 
            // box_inventario
            // 
            this.box_inventario.Controls.Add(this.btn_consultar);
            this.box_inventario.Controls.Add(this.dataGridView_Inventario);
            this.box_inventario.Controls.Add(this.combo_empresa);
            this.box_inventario.Controls.Add(this.label1);
            this.box_inventario.Location = new System.Drawing.Point(11, 12);
            this.box_inventario.Name = "box_inventario";
            this.box_inventario.Size = new System.Drawing.Size(415, 361);
            this.box_inventario.TabIndex = 0;
            this.box_inventario.TabStop = false;
            this.box_inventario.Text = "Selecióna la sucursal para ver su inventario";
            this.box_inventario.Enter += new System.EventHandler(this.box_inventario_Enter);
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(56, 321);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(310, 23);
            this.btn_consultar.TabIndex = 3;
            this.btn_consultar.Text = "Consultar Inventario";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // dataGridView_Inventario
            // 
            this.dataGridView_Inventario.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView_Inventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Inventario.Location = new System.Drawing.Point(19, 84);
            this.dataGridView_Inventario.Name = "dataGridView_Inventario";
            this.dataGridView_Inventario.Size = new System.Drawing.Size(377, 184);
            this.dataGridView_Inventario.TabIndex = 2;
            // 
            // combo_empresa
            // 
            this.combo_empresa.FormattingEnabled = true;
            this.combo_empresa.Location = new System.Drawing.Point(86, 32);
            this.combo_empresa.Name = "combo_empresa";
            this.combo_empresa.Size = new System.Drawing.Size(310, 21);
            this.combo_empresa.TabIndex = 1;
            this.combo_empresa.TextChanged += new System.EventHandler(this.combo_empresa_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sucursal:";
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(456, 427);
            this.Controls.Add(this.box_inventario);
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            this.box_inventario.ResumeLayout(false);
            this.box_inventario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Inventario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox box_inventario;
        private System.Windows.Forms.ComboBox combo_empresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.DataGridView dataGridView_Inventario;
    }
}
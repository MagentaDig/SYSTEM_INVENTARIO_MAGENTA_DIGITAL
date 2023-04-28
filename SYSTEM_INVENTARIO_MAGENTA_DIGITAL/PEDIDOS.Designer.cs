namespace SYSTEM_INVENTARIO_MAGENTA_DIGITAL
{
    partial class PEDIDOS
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
            this.lbl_detalle = new System.Windows.Forms.Label();
            this.lbl_material = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox_Detalle = new System.Windows.Forms.RichTextBox();
            this.cb_Materiales = new System.Windows.Forms.ComboBox();
            this.btn_AgrMat = new System.Windows.Forms.Button();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.btnAgrPedido = new System.Windows.Forms.Button();
            this.dataGrid_MaterialPed = new System.Windows.Forms.DataGridView();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_MaterialPed)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_detalle
            // 
            this.lbl_detalle.AutoSize = true;
            this.lbl_detalle.Location = new System.Drawing.Point(59, 85);
            this.lbl_detalle.Name = "lbl_detalle";
            this.lbl_detalle.Size = new System.Drawing.Size(92, 13);
            this.lbl_detalle.TabIndex = 0;
            this.lbl_detalle.Text = "Detalle del pedido";
            // 
            // lbl_material
            // 
            this.lbl_material.AutoSize = true;
            this.lbl_material.Location = new System.Drawing.Point(389, 85);
            this.lbl_material.Name = "lbl_material";
            this.lbl_material.Size = new System.Drawing.Size(44, 13);
            this.lbl_material.TabIndex = 1;
            this.lbl_material.Text = "Material";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cantidad";
            // 
            // richTextBox_Detalle
            // 
            this.richTextBox_Detalle.Location = new System.Drawing.Point(62, 114);
            this.richTextBox_Detalle.Name = "richTextBox_Detalle";
            this.richTextBox_Detalle.Size = new System.Drawing.Size(282, 118);
            this.richTextBox_Detalle.TabIndex = 3;
            this.richTextBox_Detalle.Text = "";
            // 
            // cb_Materiales
            // 
            this.cb_Materiales.FormattingEnabled = true;
            this.cb_Materiales.Location = new System.Drawing.Point(392, 114);
            this.cb_Materiales.Name = "cb_Materiales";
            this.cb_Materiales.Size = new System.Drawing.Size(150, 21);
            this.cb_Materiales.TabIndex = 4;
            // 
            // btn_AgrMat
            // 
            this.btn_AgrMat.Location = new System.Drawing.Point(392, 209);
            this.btn_AgrMat.Name = "btn_AgrMat";
            this.btn_AgrMat.Size = new System.Drawing.Size(150, 23);
            this.btn_AgrMat.TabIndex = 5;
            this.btn_AgrMat.Text = "Agregar";
            this.btn_AgrMat.UseVisualStyleBackColor = true;
            this.btn_AgrMat.Click += new System.EventHandler(this.btn_AgrMat_Click);
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(392, 173);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(150, 20);
            this.txt_Cantidad.TabIndex = 7;
            this.txt_Cantidad.TextChanged += new System.EventHandler(this.txt_Cantidad_TextChanged);
            // 
            // btnAgrPedido
            // 
            this.btnAgrPedido.Location = new System.Drawing.Point(834, 250);
            this.btnAgrPedido.Name = "btnAgrPedido";
            this.btnAgrPedido.Size = new System.Drawing.Size(163, 27);
            this.btnAgrPedido.TabIndex = 8;
            this.btnAgrPedido.Text = "Agregar Pedido";
            this.btnAgrPedido.UseVisualStyleBackColor = true;
            // 
            // dataGrid_MaterialPed
            // 
            this.dataGrid_MaterialPed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_MaterialPed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Material,
            this.cantidad});
            this.dataGrid_MaterialPed.Location = new System.Drawing.Point(601, 114);
            this.dataGrid_MaterialPed.Name = "dataGrid_MaterialPed";
            this.dataGrid_MaterialPed.Size = new System.Drawing.Size(396, 118);
            this.dataGrid_MaterialPed.TabIndex = 9;
            // 
            // Material
            // 
            this.Material.HeaderText = "Material";
            this.Material.Name = "Material";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // btnReegresar
            // 
            this.btnReegresar.Location = new System.Drawing.Point(62, 32);
            this.btnReegresar.Name = "btnReegresar";
            this.btnReegresar.Size = new System.Drawing.Size(75, 23);
            this.btnReegresar.TabIndex = 10;
            this.btnReegresar.Text = "Regresar";
            this.btnReegresar.UseVisualStyleBackColor = true;
            this.btnReegresar.Click += new System.EventHandler(this.btnReegresar_Click);
            // 
            // PEDIDOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 472);
            this.Controls.Add(this.btnReegresar);
            this.Controls.Add(this.dataGrid_MaterialPed);
            this.Controls.Add(this.btnAgrPedido);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.btn_AgrMat);
            this.Controls.Add(this.cb_Materiales);
            this.Controls.Add(this.richTextBox_Detalle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_material);
            this.Controls.Add(this.lbl_detalle);
            this.Name = "PEDIDOS";
            this.Text = "PEDIDOS";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_MaterialPed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_detalle;
        private System.Windows.Forms.Label lbl_material;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox_Detalle;
        private System.Windows.Forms.ComboBox cb_Materiales;
        private System.Windows.Forms.Button btn_AgrMat;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.Button btnAgrPedido;
        private System.Windows.Forms.DataGridView dataGrid_MaterialPed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.Button btnReegresar;
    }
}
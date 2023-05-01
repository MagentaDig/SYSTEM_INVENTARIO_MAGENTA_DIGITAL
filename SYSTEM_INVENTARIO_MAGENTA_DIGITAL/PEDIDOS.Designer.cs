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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NomPedido = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalle_Ped = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fec_Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_MaterialPed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_detalle
            // 
            this.lbl_detalle.AutoSize = true;
            this.lbl_detalle.Location = new System.Drawing.Point(59, 140);
            this.lbl_detalle.Name = "lbl_detalle";
            this.lbl_detalle.Size = new System.Drawing.Size(92, 13);
            this.lbl_detalle.TabIndex = 0;
            this.lbl_detalle.Text = "Detalle del pedido";
            // 
            // lbl_material
            // 
            this.lbl_material.AutoSize = true;
            this.lbl_material.Location = new System.Drawing.Point(389, 78);
            this.lbl_material.Name = "lbl_material";
            this.lbl_material.Size = new System.Drawing.Size(44, 13);
            this.lbl_material.TabIndex = 1;
            this.lbl_material.Text = "Material";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cantidad";
            // 
            // richTextBox_Detalle
            // 
            this.richTextBox_Detalle.Location = new System.Drawing.Point(62, 166);
            this.richTextBox_Detalle.Name = "richTextBox_Detalle";
            this.richTextBox_Detalle.Size = new System.Drawing.Size(282, 59);
            this.richTextBox_Detalle.TabIndex = 3;
            this.richTextBox_Detalle.Text = "";
            // 
            // cb_Materiales
            // 
            this.cb_Materiales.FormattingEnabled = true;
            this.cb_Materiales.Location = new System.Drawing.Point(392, 107);
            this.cb_Materiales.Name = "cb_Materiales";
            this.cb_Materiales.Size = new System.Drawing.Size(150, 21);
            this.cb_Materiales.TabIndex = 4;
            // 
            // btn_AgrMat
            // 
            this.btn_AgrMat.Location = new System.Drawing.Point(392, 202);
            this.btn_AgrMat.Name = "btn_AgrMat";
            this.btn_AgrMat.Size = new System.Drawing.Size(150, 23);
            this.btn_AgrMat.TabIndex = 5;
            this.btn_AgrMat.Text = "Agregar";
            this.btn_AgrMat.UseVisualStyleBackColor = true;
            this.btn_AgrMat.Click += new System.EventHandler(this.btn_AgrMat_Click);
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(392, 166);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(150, 20);
            this.txt_Cantidad.TabIndex = 7;
            this.txt_Cantidad.TextChanged += new System.EventHandler(this.txt_Cantidad_TextChanged);
            // 
            // btnAgrPedido
            // 
            this.btnAgrPedido.Location = new System.Drawing.Point(834, 231);
            this.btnAgrPedido.Name = "btnAgrPedido";
            this.btnAgrPedido.Size = new System.Drawing.Size(163, 27);
            this.btnAgrPedido.TabIndex = 8;
            this.btnAgrPedido.Text = "Agregar Pedido";
            this.btnAgrPedido.UseVisualStyleBackColor = true;
            this.btnAgrPedido.Click += new System.EventHandler(this.btnAgrPedido_Click);
            // 
            // dataGrid_MaterialPed
            // 
            this.dataGrid_MaterialPed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_MaterialPed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Material,
            this.cantidad});
            this.dataGrid_MaterialPed.Location = new System.Drawing.Point(601, 107);
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
            this.btnReegresar.Location = new System.Drawing.Point(62, 25);
            this.btnReegresar.Name = "btnReegresar";
            this.btnReegresar.Size = new System.Drawing.Size(75, 23);
            this.btnReegresar.TabIndex = 10;
            this.btnReegresar.Text = "Regresar";
            this.btnReegresar.UseVisualStyleBackColor = true;
            this.btnReegresar.Click += new System.EventHandler(this.btnReegresar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "A nombre de:";
            // 
            // txt_NomPedido
            // 
            this.txt_NomPedido.Location = new System.Drawing.Point(62, 107);
            this.txt_NomPedido.Name = "txt_NomPedido";
            this.txt_NomPedido.Size = new System.Drawing.Size(282, 20);
            this.txt_NomPedido.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_pedido,
            this.nomPedido,
            this.detalle_Ped,
            this.fec_Pedido});
            this.dataGridView1.Location = new System.Drawing.Point(62, 285);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(935, 243);
            this.dataGridView1.TabIndex = 14;
            // 
            // id_pedido
            // 
            this.id_pedido.HeaderText = "NO. PEDIDO";
            this.id_pedido.Name = "id_pedido";
            // 
            // nomPedido
            // 
            this.nomPedido.HeaderText = "A NOMBRE DE:";
            this.nomPedido.Name = "nomPedido";
            this.nomPedido.Width = 250;
            // 
            // detalle_Ped
            // 
            this.detalle_Ped.HeaderText = "DETALLE";
            this.detalle_Ped.Name = "detalle_Ped";
            this.detalle_Ped.Width = 400;
            // 
            // fec_Pedido
            // 
            this.fec_Pedido.HeaderText = "FECHA DE PEDIDO";
            this.fec_Pedido.Name = "fec_Pedido";
            this.fec_Pedido.Width = 200;
            // 
            // PEDIDOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 546);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_NomPedido);
            this.Controls.Add(this.label2);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NomPedido;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalle_Ped;
        private System.Windows.Forms.DataGridViewTextBoxColumn fec_Pedido;
    }
}
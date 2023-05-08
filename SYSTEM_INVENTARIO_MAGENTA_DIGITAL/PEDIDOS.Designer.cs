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
            this.dataGrid_Pedidos = new System.Windows.Forms.DataGridView();
            this.lbl_titleStock = new System.Windows.Forms.Label();
            this.lbl_cantidadDisp = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_noSerie = new System.Windows.Forms.Label();
            this.link_AgrStock = new System.Windows.Forms.LinkLabel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.id_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalle_Ped = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fec_Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entregado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.verPedido = new System.Windows.Forms.DataGridViewImageColumn();
            this.eliminarPed = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_MaterialPed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Pedidos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_detalle
            // 
            this.lbl_detalle.AutoSize = true;
            this.lbl_detalle.Location = new System.Drawing.Point(17, 115);
            this.lbl_detalle.Name = "lbl_detalle";
            this.lbl_detalle.Size = new System.Drawing.Size(92, 13);
            this.lbl_detalle.TabIndex = 0;
            this.lbl_detalle.Text = "Detalle del pedido";
            // 
            // lbl_material
            // 
            this.lbl_material.AutoSize = true;
            this.lbl_material.Location = new System.Drawing.Point(327, 32);
            this.lbl_material.Name = "lbl_material";
            this.lbl_material.Size = new System.Drawing.Size(44, 13);
            this.lbl_material.TabIndex = 1;
            this.lbl_material.Text = "Material";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cantidad";
            // 
            // richTextBox_Detalle
            // 
            this.richTextBox_Detalle.Location = new System.Drawing.Point(20, 141);
            this.richTextBox_Detalle.Name = "richTextBox_Detalle";
            this.richTextBox_Detalle.Size = new System.Drawing.Size(282, 59);
            this.richTextBox_Detalle.TabIndex = 3;
            this.richTextBox_Detalle.Text = "";
            // 
            // cb_Materiales
            // 
            this.cb_Materiales.FormattingEnabled = true;
            this.cb_Materiales.Location = new System.Drawing.Point(330, 52);
            this.cb_Materiales.Name = "cb_Materiales";
            this.cb_Materiales.Size = new System.Drawing.Size(229, 21);
            this.cb_Materiales.TabIndex = 4;
            this.cb_Materiales.SelectedIndexChanged += new System.EventHandler(this.cb_Materiales_SelectedIndexChanged);
            this.cb_Materiales.SelectedValueChanged += new System.EventHandler(this.cb_Materiales_SelectedValueChanged);
            // 
            // btn_AgrMat
            // 
            this.btn_AgrMat.Location = new System.Drawing.Point(330, 177);
            this.btn_AgrMat.Name = "btn_AgrMat";
            this.btn_AgrMat.Size = new System.Drawing.Size(229, 23);
            this.btn_AgrMat.TabIndex = 5;
            this.btn_AgrMat.Text = "Agregar";
            this.btn_AgrMat.UseVisualStyleBackColor = true;
            this.btn_AgrMat.Click += new System.EventHandler(this.btn_AgrMat_Click);
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(330, 141);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(229, 20);
            this.txt_Cantidad.TabIndex = 7;
            this.txt_Cantidad.TextChanged += new System.EventHandler(this.txt_Cantidad_TextChanged);
            // 
            // btnAgrPedido
            // 
            this.btnAgrPedido.Location = new System.Drawing.Point(714, 260);
            this.btnAgrPedido.Name = "btnAgrPedido";
            this.btnAgrPedido.Size = new System.Drawing.Size(376, 47);
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
            this.dataGrid_MaterialPed.Location = new System.Drawing.Point(714, 69);
            this.dataGrid_MaterialPed.Name = "dataGrid_MaterialPed";
            this.dataGrid_MaterialPed.Size = new System.Drawing.Size(376, 185);
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
            this.label2.Location = new System.Drawing.Point(17, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "A nombre de:";
            // 
            // txt_NomPedido
            // 
            this.txt_NomPedido.Location = new System.Drawing.Point(20, 53);
            this.txt_NomPedido.Name = "txt_NomPedido";
            this.txt_NomPedido.Size = new System.Drawing.Size(282, 20);
            this.txt_NomPedido.TabIndex = 12;
            // 
            // dataGrid_Pedidos
            // 
            this.dataGrid_Pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Pedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_pedido,
            this.nomPedido,
            this.detalle_Ped,
            this.fec_Pedido,
            this.entregado,
            this.verPedido,
            this.eliminarPed});
            this.dataGrid_Pedidos.Location = new System.Drawing.Point(62, 335);
            this.dataGrid_Pedidos.Name = "dataGrid_Pedidos";
            this.dataGrid_Pedidos.Size = new System.Drawing.Size(1040, 243);
            this.dataGrid_Pedidos.TabIndex = 14;
            this.dataGrid_Pedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Pedidos_CellClick);
            // 
            // lbl_titleStock
            // 
            this.lbl_titleStock.AutoSize = true;
            this.lbl_titleStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titleStock.Location = new System.Drawing.Point(394, 32);
            this.lbl_titleStock.Name = "lbl_titleStock";
            this.lbl_titleStock.Size = new System.Drawing.Size(107, 13);
            this.lbl_titleStock.TabIndex = 15;
            this.lbl_titleStock.Text = "Stock Disponible:";
            // 
            // lbl_cantidadDisp
            // 
            this.lbl_cantidadDisp.AutoSize = true;
            this.lbl_cantidadDisp.Location = new System.Drawing.Point(504, 32);
            this.lbl_cantidadDisp.Name = "lbl_cantidadDisp";
            this.lbl_cantidadDisp.Size = new System.Drawing.Size(55, 13);
            this.lbl_cantidadDisp.TabIndex = 16;
            this.lbl_cantidadDisp.Text = "(Cantidad)";
            this.lbl_cantidadDisp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_noSerie);
            this.groupBox1.Controls.Add(this.link_AgrStock);
            this.groupBox1.Controls.Add(this.lbl_cantidadDisp);
            this.groupBox1.Controls.Add(this.richTextBox_Detalle);
            this.groupBox1.Controls.Add(this.lbl_titleStock);
            this.groupBox1.Controls.Add(this.lbl_detalle);
            this.groupBox1.Controls.Add(this.txt_NomPedido);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_AgrMat);
            this.groupBox1.Controls.Add(this.txt_Cantidad);
            this.groupBox1.Controls.Add(this.lbl_material);
            this.groupBox1.Controls.Add(this.cb_Materiales);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(62, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 238);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del pedido";
            // 
            // lbl_noSerie
            // 
            this.lbl_noSerie.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.lbl_noSerie.AutoSize = true;
            this.lbl_noSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noSerie.Location = new System.Drawing.Point(327, 85);
            this.lbl_noSerie.Name = "lbl_noSerie";
            this.lbl_noSerie.Size = new System.Drawing.Size(74, 13);
            this.lbl_noSerie.TabIndex = 18;
            this.lbl_noSerie.Text = "(NO SERIE)";
            this.lbl_noSerie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // link_AgrStock
            // 
            this.link_AgrStock.AutoSize = true;
            this.link_AgrStock.Location = new System.Drawing.Point(484, 85);
            this.link_AgrStock.Name = "link_AgrStock";
            this.link_AgrStock.Size = new System.Drawing.Size(75, 13);
            this.link_AgrStock.TabIndex = 17;
            this.link_AgrStock.TabStop = true;
            this.link_AgrStock.Text = "Agregar Stock";
            this.link_AgrStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.link_AgrStock.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_AgrStock_LinkClicked);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.Frozen = true;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::SYSTEM_INVENTARIO_MAGENTA_DIGITAL.Properties.Resources.mas;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "ELIMINAR";
            this.dataGridViewImageColumn2.Image = global::SYSTEM_INVENTARIO_MAGENTA_DIGITAL.Properties.Resources.icon_5f41a9b90a6fd03b7d17b63704ef6f97;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // id_pedido
            // 
            this.id_pedido.Frozen = true;
            this.id_pedido.HeaderText = "NO. PEDIDO";
            this.id_pedido.Name = "id_pedido";
            // 
            // nomPedido
            // 
            this.nomPedido.Frozen = true;
            this.nomPedido.HeaderText = "A NOMBRE DE:";
            this.nomPedido.Name = "nomPedido";
            this.nomPedido.Width = 200;
            // 
            // detalle_Ped
            // 
            this.detalle_Ped.Frozen = true;
            this.detalle_Ped.HeaderText = "DETALLE";
            this.detalle_Ped.Name = "detalle_Ped";
            this.detalle_Ped.Width = 250;
            // 
            // fec_Pedido
            // 
            this.fec_Pedido.Frozen = true;
            this.fec_Pedido.HeaderText = "FECHA DE PEDIDO";
            this.fec_Pedido.Name = "fec_Pedido";
            this.fec_Pedido.Width = 150;
            // 
            // entregado
            // 
            this.entregado.Frozen = true;
            this.entregado.HeaderText = "ENTREGADO";
            this.entregado.Name = "entregado";
            // 
            // verPedido
            // 
            this.verPedido.Frozen = true;
            this.verPedido.HeaderText = "VER DETALLE";
            this.verPedido.Image = global::SYSTEM_INVENTARIO_MAGENTA_DIGITAL.Properties.Resources.icon_4bd3092cfdf353a4b19434341ccb7d5d1;
            this.verPedido.Name = "verPedido";
            this.verPedido.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // eliminarPed
            // 
            this.eliminarPed.HeaderText = "ELIMINAR";
            this.eliminarPed.Image = global::SYSTEM_INVENTARIO_MAGENTA_DIGITAL.Properties.Resources.icon_5f41a9b90a6fd03b7d17b63704ef6f97;
            this.eliminarPed.Name = "eliminarPed";
            // 
            // PEDIDOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 601);
            this.Controls.Add(this.dataGrid_Pedidos);
            this.Controls.Add(this.btnReegresar);
            this.Controls.Add(this.btnAgrPedido);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGrid_MaterialPed);
            this.Name = "PEDIDOS";
            this.Text = "PEDIDOS";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_MaterialPed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Pedidos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridView dataGrid_Pedidos;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label lbl_titleStock;
        private System.Windows.Forms.Label lbl_cantidadDisp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_noSerie;
        private System.Windows.Forms.LinkLabel link_AgrStock;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalle_Ped;
        private System.Windows.Forms.DataGridViewTextBoxColumn fec_Pedido;
        private System.Windows.Forms.DataGridViewCheckBoxColumn entregado;
        private System.Windows.Forms.DataGridViewImageColumn verPedido;
        private System.Windows.Forms.DataGridViewImageColumn eliminarPed;
    }
}
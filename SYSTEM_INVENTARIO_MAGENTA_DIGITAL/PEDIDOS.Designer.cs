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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_detalle = new System.Windows.Forms.Label();
            this.lbl_material = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox_Detalle = new System.Windows.Forms.RichTextBox();
            this.cb_Materiales = new System.Windows.Forms.ComboBox();
            this.btn_AgrMat = new System.Windows.Forms.Button();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.btnAgrPedido = new System.Windows.Forms.Button();
            this.dataGrid_MaterialPed = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NomPedido = new System.Windows.Forms.TextBox();
            this.dataGrid_Pedidos = new System.Windows.Forms.DataGridView();
            this.lbl_titleStock = new System.Windows.Forms.Label();
            this.lbl_cantidadDisp = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_noSerie = new System.Windows.Forms.Label();
            this.link_AgrStock = new System.Windows.Forms.LinkLabel();
            this.id_pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalle_Ped = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fec_Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.entregado = new System.Windows.Forms.DataGridViewImageColumn();
            this.verPedido = new System.Windows.Forms.DataGridViewImageColumn();
            this.eliminarPed = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_MaterialPed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Pedidos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_detalle
            // 
            this.lbl_detalle.AutoSize = true;
            this.lbl_detalle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_detalle.Location = new System.Drawing.Point(17, 115);
            this.lbl_detalle.Name = "lbl_detalle";
            this.lbl_detalle.Size = new System.Drawing.Size(129, 16);
            this.lbl_detalle.TabIndex = 0;
            this.lbl_detalle.Text = "Detalle del pedido";
            // 
            // lbl_material
            // 
            this.lbl_material.AutoSize = true;
            this.lbl_material.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_material.Location = new System.Drawing.Point(340, 32);
            this.lbl_material.Name = "lbl_material";
            this.lbl_material.Size = new System.Drawing.Size(62, 16);
            this.lbl_material.TabIndex = 1;
            this.lbl_material.Text = "Material";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cantidad";
            // 
            // richTextBox_Detalle
            // 
            this.richTextBox_Detalle.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox_Detalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_Detalle.Location = new System.Drawing.Point(20, 141);
            this.richTextBox_Detalle.Name = "richTextBox_Detalle";
            this.richTextBox_Detalle.Size = new System.Drawing.Size(292, 59);
            this.richTextBox_Detalle.TabIndex = 3;
            this.richTextBox_Detalle.Text = "";
            // 
            // cb_Materiales
            // 
            this.cb_Materiales.BackColor = System.Drawing.SystemColors.Window;
            this.cb_Materiales.FormattingEnabled = true;
            this.cb_Materiales.Location = new System.Drawing.Point(343, 52);
            this.cb_Materiales.Name = "cb_Materiales";
            this.cb_Materiales.Size = new System.Drawing.Size(255, 24);
            this.cb_Materiales.TabIndex = 4;
            this.cb_Materiales.SelectedIndexChanged += new System.EventHandler(this.cb_Materiales_SelectedIndexChanged);
            this.cb_Materiales.SelectedValueChanged += new System.EventHandler(this.cb_Materiales_SelectedValueChanged);
            // 
            // btn_AgrMat
            // 
            this.btn_AgrMat.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_AgrMat.FlatAppearance.BorderSize = 0;
            this.btn_AgrMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgrMat.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgrMat.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_AgrMat.Location = new System.Drawing.Point(343, 177);
            this.btn_AgrMat.Name = "btn_AgrMat";
            this.btn_AgrMat.Size = new System.Drawing.Size(255, 23);
            this.btn_AgrMat.TabIndex = 5;
            this.btn_AgrMat.Text = "Agregar";
            this.btn_AgrMat.UseVisualStyleBackColor = false;
            this.btn_AgrMat.Click += new System.EventHandler(this.btn_AgrMat_Click);
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.BackColor = System.Drawing.SystemColors.Window;
            this.txt_Cantidad.Location = new System.Drawing.Point(343, 141);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(255, 23);
            this.txt_Cantidad.TabIndex = 7;
            this.txt_Cantidad.TextChanged += new System.EventHandler(this.txt_Cantidad_TextChanged);
            this.txt_Cantidad.Validated += new System.EventHandler(this.txt_Cantidad_Validated);
            // 
            // btnAgrPedido
            // 
            this.btnAgrPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(126)))), ((int)(((byte)(182)))));
            this.btnAgrPedido.FlatAppearance.BorderSize = 0;
            this.btnAgrPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgrPedido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgrPedido.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAgrPedido.Location = new System.Drawing.Point(714, 279);
            this.btnAgrPedido.Name = "btnAgrPedido";
            this.btnAgrPedido.Size = new System.Drawing.Size(376, 47);
            this.btnAgrPedido.TabIndex = 8;
            this.btnAgrPedido.Text = "Agregar Pedido";
            this.btnAgrPedido.UseVisualStyleBackColor = false;
            this.btnAgrPedido.Click += new System.EventHandler(this.btnAgrPedido_Click);
            // 
            // dataGrid_MaterialPed
            // 
            this.dataGrid_MaterialPed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid_MaterialPed.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGrid_MaterialPed.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_MaterialPed.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid_MaterialPed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_MaterialPed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Material,
            this.cantidad});
            this.dataGrid_MaterialPed.Location = new System.Drawing.Point(714, 88);
            this.dataGrid_MaterialPed.Name = "dataGrid_MaterialPed";
            this.dataGrid_MaterialPed.RowHeadersVisible = false;
            this.dataGrid_MaterialPed.Size = new System.Drawing.Size(376, 185);
            this.dataGrid_MaterialPed.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "A nombre de:";
            // 
            // txt_NomPedido
            // 
            this.txt_NomPedido.BackColor = System.Drawing.SystemColors.Window;
            this.txt_NomPedido.Location = new System.Drawing.Point(20, 53);
            this.txt_NomPedido.Name = "txt_NomPedido";
            this.txt_NomPedido.Size = new System.Drawing.Size(292, 23);
            this.txt_NomPedido.TabIndex = 12;
            // 
            // dataGrid_Pedidos
            // 
            this.dataGrid_Pedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid_Pedidos.CausesValidation = false;
            this.dataGrid_Pedidos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGrid_Pedidos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Pedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid_Pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Pedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_pedido,
            this.nomPedido,
            this.detalle_Ped,
            this.fec_Pedido,
            this.entregado,
            this.verPedido,
            this.eliminarPed});
            this.dataGrid_Pedidos.Location = new System.Drawing.Point(62, 403);
            this.dataGrid_Pedidos.Name = "dataGrid_Pedidos";
            this.dataGrid_Pedidos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGrid_Pedidos.RowHeadersVisible = false;
            this.dataGrid_Pedidos.Size = new System.Drawing.Size(1028, 243);
            this.dataGrid_Pedidos.TabIndex = 14;
            this.dataGrid_Pedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Pedidos_CellClick);
            this.dataGrid_Pedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Pedidos_CellContentClick);
            this.dataGrid_Pedidos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Pedidos_CellEndEdit);
            // 
            // lbl_titleStock
            // 
            this.lbl_titleStock.AutoSize = true;
            this.lbl_titleStock.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titleStock.Location = new System.Drawing.Point(429, 33);
            this.lbl_titleStock.Name = "lbl_titleStock";
            this.lbl_titleStock.Size = new System.Drawing.Size(99, 15);
            this.lbl_titleStock.TabIndex = 15;
            this.lbl_titleStock.Text = "Stock Disponible:";
            // 
            // lbl_cantidadDisp
            // 
            this.lbl_cantidadDisp.AutoSize = true;
            this.lbl_cantidadDisp.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidadDisp.Location = new System.Drawing.Point(534, 32);
            this.lbl_cantidadDisp.Name = "lbl_cantidadDisp";
            this.lbl_cantidadDisp.Size = new System.Drawing.Size(64, 15);
            this.lbl_cantidadDisp.TabIndex = 16;
            this.lbl_cantidadDisp.Text = "(Cantidad)";
            this.lbl_cantidadDisp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
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
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(62, 88);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 238);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del pedido";
            // 
            // lbl_noSerie
            // 
            this.lbl_noSerie.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.lbl_noSerie.AutoSize = true;
            this.lbl_noSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noSerie.Location = new System.Drawing.Point(340, 85);
            this.lbl_noSerie.Name = "lbl_noSerie";
            this.lbl_noSerie.Size = new System.Drawing.Size(74, 13);
            this.lbl_noSerie.TabIndex = 18;
            this.lbl_noSerie.Text = "(NO SERIE)";
            this.lbl_noSerie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // link_AgrStock
            // 
            this.link_AgrStock.AutoSize = true;
            this.link_AgrStock.Location = new System.Drawing.Point(497, 85);
            this.link_AgrStock.Name = "link_AgrStock";
            this.link_AgrStock.Size = new System.Drawing.Size(101, 16);
            this.link_AgrStock.TabIndex = 17;
            this.link_AgrStock.TabStop = true;
            this.link_AgrStock.Text = "Agregar Stock";
            this.link_AgrStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.link_AgrStock.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_AgrStock_LinkClicked);
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
            this.detalle_Ped.Width = 280;
            // 
            // fec_Pedido
            // 
            this.fec_Pedido.Frozen = true;
            this.fec_Pedido.HeaderText = "FECHA DE PEDIDO";
            this.fec_Pedido.Name = "fec_Pedido";
            this.fec_Pedido.Width = 150;
            // 
            // Material
            // 
            this.Material.HeaderText = "Material";
            this.Material.Name = "Material";
            this.Material.Width = 200;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.Width = 180;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(20, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 23);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(384, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(18, 23);
            this.panel2.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(343, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(18, 23);
            this.panel3.TabIndex = 22;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBox1.Location = new System.Drawing.Point(148, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 23);
            this.textBox1.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "No. de Pedido";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(226)))));
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Location = new System.Drawing.Point(62, 338);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1028, 49);
            this.panel4.TabIndex = 22;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "checkEntrefado";
            this.dataGridViewImageColumn1.Frozen = true;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::SYSTEM_INVENTARIO_MAGENTA_DIGITAL.Properties.Resources.mas;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.Frozen = true;
            this.dataGridViewImageColumn2.HeaderText = "ELIMINAR";
            this.dataGridViewImageColumn2.Image = global::SYSTEM_INVENTARIO_MAGENTA_DIGITAL.Properties.Resources.icon_5f41a9b90a6fd03b7d17b63704ef6f97;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "ELIMINAR";
            this.dataGridViewImageColumn3.Image = global::SYSTEM_INVENTARIO_MAGENTA_DIGITAL.Properties.Resources.icon_5f41a9b90a6fd03b7d17b63704ef6f97;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SYSTEM_INVENTARIO_MAGENTA_DIGITAL.Properties.Resources.anterior__1_;
            this.pictureBox3.Location = new System.Drawing.Point(62, 17);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // entregado
            // 
            this.entregado.DataPropertyName = "checkEntrefado";
            this.entregado.Frozen = true;
            this.entregado.HeaderText = "ENTREGADO";
            this.entregado.Image = global::SYSTEM_INVENTARIO_MAGENTA_DIGITAL.Properties.Resources.icon_7d72427863558d0f51e5aa0985cf8c82;
            this.entregado.Name = "entregado";
            this.entregado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::SYSTEM_INVENTARIO_MAGENTA_DIGITAL.Properties.Resources.buscar__1_;
            this.pictureBox1.Location = new System.Drawing.Point(361, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = global::SYSTEM_INVENTARIO_MAGENTA_DIGITAL.Properties.Resources.eliminar1;
            this.pictureBox2.Location = new System.Drawing.Point(402, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(134, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(476, 40);
            this.label4.TabIndex = 24;
            this.label4.Text = "REGISTRO Y CONSULTA DE PEDIDOS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.UseCompatibleTextRendering = true;
            // 
            // PEDIDOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1134, 668);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.dataGrid_Pedidos);
            this.Controls.Add(this.btnAgrPedido);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGrid_MaterialPed);
            this.Controls.Add(this.panel4);
            this.Name = "PEDIDOS";
            this.Tag = "PEDIDO";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_MaterialPed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Pedidos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Material;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalle_Ped;
        private System.Windows.Forms.DataGridViewTextBoxColumn fec_Pedido;
        private System.Windows.Forms.DataGridViewImageColumn entregado;
        private System.Windows.Forms.DataGridViewImageColumn verPedido;
        private System.Windows.Forms.DataGridViewImageColumn eliminarPed;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
    }
}
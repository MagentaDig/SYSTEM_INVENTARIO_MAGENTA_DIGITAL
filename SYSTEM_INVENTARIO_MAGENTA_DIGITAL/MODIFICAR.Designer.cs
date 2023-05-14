namespace SYSTEM_INVENTARIO_MAGENTA_DIGITAL
{
    partial class MODIFICAR
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_noSerie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_materialesBusc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGrid_Stock = new System.Windows.Forms.DataGridView();
            this.btnReg = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.link_MaterialesInac = new System.Windows.Forms.LinkLabel();
            this.Id_Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantDisp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewImageColumn();
            this.ELIMINAR = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Stock)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_noSerie
            // 
            this.txt_noSerie.Location = new System.Drawing.Point(214, 56);
            this.txt_noSerie.Name = "txt_noSerie";
            this.txt_noSerie.Size = new System.Drawing.Size(148, 20);
            this.txt_noSerie.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "No. Serie";
            // 
            // cb_materialesBusc
            // 
            this.cb_materialesBusc.FormattingEnabled = true;
            this.cb_materialesBusc.Location = new System.Drawing.Point(20, 56);
            this.cb_materialesBusc.Name = "cb_materialesBusc";
            this.cb_materialesBusc.Size = new System.Drawing.Size(167, 21);
            this.cb_materialesBusc.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seleccionar Material:";
            // 
            // dataGrid_Stock
            // 
            this.dataGrid_Stock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid_Stock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGrid_Stock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Stock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_Stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Stock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Materia,
            this.nomMaterial,
            this.noSerie,
            this.metMaterial,
            this.tamMaterial,
            this.cantDisp,
            this.stock,
            this.ELIMINAR});
            this.dataGrid_Stock.Location = new System.Drawing.Point(27, 237);
            this.dataGrid_Stock.Name = "dataGrid_Stock";
            this.dataGrid_Stock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGrid_Stock.RowTemplate.Height = 30;
            this.dataGrid_Stock.Size = new System.Drawing.Size(991, 327);
            this.dataGrid_Stock.TabIndex = 5;
            this.dataGrid_Stock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Stock_CellClick);
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(27, 22);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(167, 23);
            this.btnReg.TabIndex = 10;
            this.btnReg.Text = "Regresar";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "MODIFICAR";
            this.dataGridViewImageColumn1.Image = global::SYSTEM_INVENTARIO_MAGENTA_DIGITAL.Properties.Resources.editar__1_;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 150;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "ELIMINAR";
            this.dataGridViewImageColumn2.Image = global::SYSTEM_INVENTARIO_MAGENTA_DIGITAL.Properties.Resources.eliminar__1_;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 150;
            // 
            // link_MaterialesInac
            // 
            this.link_MaterialesInac.AutoSize = true;
            this.link_MaterialesInac.Location = new System.Drawing.Point(24, 578);
            this.link_MaterialesInac.Name = "link_MaterialesInac";
            this.link_MaterialesInac.Size = new System.Drawing.Size(101, 13);
            this.link_MaterialesInac.TabIndex = 11;
            this.link_MaterialesInac.TabStop = true;
            this.link_MaterialesInac.Text = "Materiales Inactivos";
            this.link_MaterialesInac.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_MaterialesInac_LinkClicked);
            // 
            // Id_Materia
            // 
            this.Id_Materia.HeaderText = "ID";
            this.Id_Materia.Name = "Id_Materia";
            // 
            // nomMaterial
            // 
            this.nomMaterial.HeaderText = "MATERIAL";
            this.nomMaterial.Name = "nomMaterial";
            // 
            // noSerie
            // 
            this.noSerie.HeaderText = "NO. DE SERIE";
            this.noSerie.Name = "noSerie";
            this.noSerie.Width = 150;
            // 
            // metMaterial
            // 
            this.metMaterial.HeaderText = "METROS";
            this.metMaterial.Name = "metMaterial";
            // 
            // tamMaterial
            // 
            this.tamMaterial.HeaderText = "TAMAÑO";
            this.tamMaterial.Name = "tamMaterial";
            // 
            // cantDisp
            // 
            this.cantDisp.HeaderText = "CANTIDAD DISPONIBLE";
            this.cantDisp.Name = "cantDisp";
            this.cantDisp.Width = 200;
            // 
            // stock
            // 
            this.stock.HeaderText = "STOCK";
            this.stock.Image = global::SYSTEM_INVENTARIO_MAGENTA_DIGITAL.Properties.Resources.icon_e6b85da097f15d781ed24b822e966d12;
            this.stock.Name = "stock";
            // 
            // ELIMINAR
            // 
            this.ELIMINAR.HeaderText = "ELIMINAR";
            this.ELIMINAR.Image = global::SYSTEM_INVENTARIO_MAGENTA_DIGITAL.Properties.Resources.icon_5f41a9b90a6fd03b7d17b63704ef6f971;
            this.ELIMINAR.Name = "ELIMINAR";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Reset);
            this.groupBox1.Controls.Add(this.btn_Buscar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_Cantidad);
            this.groupBox1.Controls.Add(this.cb_materialesBusc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_noSerie);
            this.groupBox1.Location = new System.Drawing.Point(27, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(725, 141);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cantidad";
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(391, 56);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(148, 20);
            this.txt_Cantidad.TabIndex = 11;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(20, 100);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(126, 20);
            this.btn_Buscar.TabIndex = 13;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(167, 100);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(126, 20);
            this.btn_Reset.TabIndex = 14;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // MODIFICAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 638);
            this.Controls.Add(this.link_MaterialesInac);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.dataGrid_Stock);
            this.Controls.Add(this.groupBox1);
            this.Name = "MODIFICAR";
            this.Text = "MODIFICAR";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Stock)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_noSerie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_materialesBusc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGrid_Stock;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.LinkLabel link_MaterialesInac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn noSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn metMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantDisp;
        private System.Windows.Forms.DataGridViewImageColumn stock;
        private System.Windows.Forms.DataGridViewImageColumn ELIMINAR;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.Button btn_Reset;
    }
}
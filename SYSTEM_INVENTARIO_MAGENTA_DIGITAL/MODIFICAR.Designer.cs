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
            this.txt_CantBusc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_materialesBusc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGrid_Stock = new System.Windows.Forms.DataGridView();
            this.btnReg = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Id_Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewImageColumn();
            this.ELIMINAR = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Stock)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_CantBusc
            // 
            this.txt_CantBusc.Location = new System.Drawing.Point(241, 98);
            this.txt_CantBusc.Name = "txt_CantBusc";
            this.txt_CantBusc.Size = new System.Drawing.Size(148, 20);
            this.txt_CantBusc.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cantidad";
            // 
            // cb_materialesBusc
            // 
            this.cb_materialesBusc.FormattingEnabled = true;
            this.cb_materialesBusc.Location = new System.Drawing.Point(27, 98);
            this.cb_materialesBusc.Name = "cb_materialesBusc";
            this.cb_materialesBusc.Size = new System.Drawing.Size(167, 21);
            this.cb_materialesBusc.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 67);
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
            this.stock,
            this.ELIMINAR});
            this.dataGrid_Stock.Location = new System.Drawing.Point(27, 143);
            this.dataGrid_Stock.Name = "dataGrid_Stock";
            this.dataGrid_Stock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGrid_Stock.RowTemplate.Height = 30;
            this.dataGrid_Stock.Size = new System.Drawing.Size(791, 327);
            this.dataGrid_Stock.TabIndex = 5;
            this.dataGrid_Stock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Stock_CellClick);
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(27, 23);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(75, 23);
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
            // stock
            // 
            this.stock.HeaderText = "STOCK";
            this.stock.Image = global::SYSTEM_INVENTARIO_MAGENTA_DIGITAL.Properties.Resources.icon_5f41a9b90a6fd03b7d17b63704ef6f97__1_;
            this.stock.Name = "stock";
            // 
            // ELIMINAR
            // 
            this.ELIMINAR.HeaderText = "ELIMINAR";
            this.ELIMINAR.Image = global::SYSTEM_INVENTARIO_MAGENTA_DIGITAL.Properties.Resources.icon_5f41a9b90a6fd03b7d17b63704ef6f971;
            this.ELIMINAR.Name = "ELIMINAR";
            // 
            // MODIFICAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 517);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.txt_CantBusc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_materialesBusc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid_Stock);
            this.Name = "MODIFICAR";
            this.Text = "MODIFICAR";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_CantBusc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_materialesBusc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGrid_Stock;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn noSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn metMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamMaterial;
        private System.Windows.Forms.DataGridViewImageColumn stock;
        private System.Windows.Forms.DataGridViewImageColumn ELIMINAR;
    }
}
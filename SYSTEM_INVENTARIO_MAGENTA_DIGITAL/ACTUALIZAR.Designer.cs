namespace SYSTEM_INVENTARIO_MAGENTA_DIGITAL
{
    partial class ACTUALIZAR
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ACTUALIZAR));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Material = new System.Windows.Forms.Label();
            this.lbl_noSerie = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NuevoStock = new System.Windows.Forms.TextBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.dataGrid_Stock = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDisp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Stock)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Material";
            // 
            // lbl_Material
            // 
            this.lbl_Material.AutoSize = true;
            this.lbl_Material.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Material.Location = new System.Drawing.Point(33, 65);
            this.lbl_Material.Name = "lbl_Material";
            this.lbl_Material.Size = new System.Drawing.Size(152, 17);
            this.lbl_Material.TabIndex = 1;
            this.lbl_Material.Text = "(Nombre del material)";
            this.lbl_Material.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_noSerie
            // 
            this.lbl_noSerie.AutoSize = true;
            this.lbl_noSerie.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_noSerie.Location = new System.Drawing.Point(497, 61);
            this.lbl_noSerie.Name = "lbl_noSerie";
            this.lbl_noSerie.Size = new System.Drawing.Size(79, 21);
            this.lbl_noSerie.TabIndex = 3;
            this.lbl_noSerie.Text = "(NO. SERIEl)";
            this.lbl_noSerie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_noSerie.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(507, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "NO. SERIE";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nuevo Stock";
            // 
            // txt_NuevoStock
            // 
            this.txt_NuevoStock.AcceptsReturn = true;
            this.txt_NuevoStock.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_NuevoStock.Location = new System.Drawing.Point(112, 25);
            this.txt_NuevoStock.Name = "txt_NuevoStock";
            this.txt_NuevoStock.Size = new System.Drawing.Size(194, 20);
            this.txt_NuevoStock.TabIndex = 5;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(126)))), ((int)(((byte)(182)))));
            this.btn_Guardar.FlatAppearance.BorderSize = 0;
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guardar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Guardar.Location = new System.Drawing.Point(325, 17);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(209, 34);
            this.btn_Guardar.TabIndex = 6;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Act_Click);
            // 
            // dataGrid_Stock
            // 
            this.dataGrid_Stock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid_Stock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGrid_Stock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Stock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid_Stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Stock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idStock,
            this.stock,
            this.stockDisp,
            this.fecEntrada});
            this.dataGrid_Stock.Location = new System.Drawing.Point(36, 189);
            this.dataGrid_Stock.Name = "dataGrid_Stock";
            this.dataGrid_Stock.RowHeadersVisible = false;
            this.dataGrid_Stock.Size = new System.Drawing.Size(540, 150);
            this.dataGrid_Stock.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_NuevoStock);
            this.groupBox1.Controls.Add(this.btn_Guardar);
            this.groupBox1.Location = new System.Drawing.Point(36, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 59);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar Stock";
            // 
            // idStock
            // 
            this.idStock.HeaderText = "ID STOCK";
            this.idStock.Name = "idStock";
            // 
            // stock
            // 
            this.stock.HeaderText = "STOCK";
            this.stock.Name = "stock";
            // 
            // stockDisp
            // 
            this.stockDisp.HeaderText = "STOCK DISPONIBLE";
            this.stockDisp.Name = "stockDisp";
            this.stockDisp.Width = 150;
            // 
            // fecEntrada
            // 
            this.fecEntrada.HeaderText = "FECHA ENTRADA";
            this.fecEntrada.Name = "fecEntrada";
            this.fecEntrada.Width = 200;
            // 
            // ACTUALIZAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(620, 374);
            this.Controls.Add(this.dataGrid_Stock);
            this.Controls.Add(this.lbl_noSerie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Material);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ACTUALIZAR";
            this.Text = "ACTUALIZAR";
            this.Load += new System.EventHandler(this.ACTUALIZAR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Stock)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Material;
        private System.Windows.Forms.Label lbl_noSerie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NuevoStock;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.DataGridView dataGrid_Stock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDisp;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecEntrada;
    }
}
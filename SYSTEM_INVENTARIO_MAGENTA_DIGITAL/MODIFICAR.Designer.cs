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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MODIFICAR));
            this.txt_noSerie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_materialesBusc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGrid_Stock = new System.Windows.Forms.DataGridView();
            this.Id_Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewImageColumn();
            this.ELIMINAR = new System.Windows.Forms.DataGridViewImageColumn();
            this.link_MaterialesInac = new System.Windows.Forms.LinkLabel();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox_Reg = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Stock)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Reg)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_noSerie
            // 
            this.txt_noSerie.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txt_noSerie.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_noSerie.Location = new System.Drawing.Point(0, 25);
            this.txt_noSerie.Multiline = true;
            this.txt_noSerie.Name = "txt_noSerie";
            this.txt_noSerie.Size = new System.Drawing.Size(250, 21);
            this.txt_noSerie.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "No. Serie";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // cb_materialesBusc
            // 
            this.cb_materialesBusc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cb_materialesBusc.Dock = System.Windows.Forms.DockStyle.Top;
            this.cb_materialesBusc.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_materialesBusc.ForeColor = System.Drawing.SystemColors.Window;
            this.cb_materialesBusc.FormattingEnabled = true;
            this.cb_materialesBusc.Location = new System.Drawing.Point(0, 25);
            this.cb_materialesBusc.Name = "cb_materialesBusc";
            this.cb_materialesBusc.Size = new System.Drawing.Size(200, 23);
            this.cb_materialesBusc.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccionar Material:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.UseCompatibleTextRendering = true;
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
            this.dataGrid_Stock.Location = new System.Drawing.Point(27, 199);
            this.dataGrid_Stock.Name = "dataGrid_Stock";
            this.dataGrid_Stock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGrid_Stock.RowHeadersVisible = false;
            this.dataGrid_Stock.RowTemplate.Height = 30;
            this.dataGrid_Stock.Size = new System.Drawing.Size(712, 327);
            this.dataGrid_Stock.TabIndex = 5;
            this.dataGrid_Stock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Stock_CellClick);
            // 
            // Id_Materia
            // 
            this.Id_Materia.HeaderText = "ID";
            this.Id_Materia.Name = "Id_Materia";
            this.Id_Materia.Width = 50;
            // 
            // nomMaterial
            // 
            this.nomMaterial.HeaderText = "MATERIAL";
            this.nomMaterial.Name = "nomMaterial";
            this.nomMaterial.Width = 120;
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
            this.stock.Image = global::SYSTEM_INVENTARIO_MAGENTA_DIGITAL.Properties.Resources.icon_e6b85da097f15d781ed24b822e966d12;
            this.stock.Name = "stock";
            // 
            // ELIMINAR
            // 
            this.ELIMINAR.HeaderText = "ELIMINAR";
            this.ELIMINAR.Image = global::SYSTEM_INVENTARIO_MAGENTA_DIGITAL.Properties.Resources.icon_5f41a9b90a6fd03b7d17b63704ef6f971;
            this.ELIMINAR.Name = "ELIMINAR";
            // 
            // link_MaterialesInac
            // 
            this.link_MaterialesInac.AutoSize = true;
            this.link_MaterialesInac.Location = new System.Drawing.Point(24, 540);
            this.link_MaterialesInac.Name = "link_MaterialesInac";
            this.link_MaterialesInac.Size = new System.Drawing.Size(101, 13);
            this.link_MaterialesInac.TabIndex = 11;
            this.link_MaterialesInac.TabStop = true;
            this.link_MaterialesInac.Text = "Materiales Inactivos";
            this.link_MaterialesInac.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_MaterialesInac_LinkClicked);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(76)))), ((int)(((byte)(37)))));
            this.btn_Reset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Reset.FlatAppearance.BorderSize = 0;
            this.btn_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reset.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Reset.Location = new System.Drawing.Point(0, 0);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(190, 30);
            this.btn_Reset.TabIndex = 14;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(126)))), ((int)(((byte)(182)))));
            this.btn_Buscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Buscar.FlatAppearance.BorderSize = 0;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Buscar.Location = new System.Drawing.Point(0, 0);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(172, 30);
            this.btn_Buscar.TabIndex = 13;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(27, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 84);
            this.panel1.TabIndex = 15;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 54);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(374, 30);
            this.panel6.TabIndex = 15;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btn_Reset);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(182, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(190, 30);
            this.panel9.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(172, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 30);
            this.panel8.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btn_Buscar);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(172, 30);
            this.panel7.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(612, 54);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txt_noSerie);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(212, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 54);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(200, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(12, 54);
            this.panel5.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cb_materialesBusc);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 54);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox_Reg
            // 
            this.pictureBox_Reg.Image = global::SYSTEM_INVENTARIO_MAGENTA_DIGITAL.Properties.Resources.anterior__1_;
            this.pictureBox_Reg.Location = new System.Drawing.Point(27, 21);
            this.pictureBox_Reg.Name = "pictureBox_Reg";
            this.pictureBox_Reg.Size = new System.Drawing.Size(40, 40);
            this.pictureBox_Reg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Reg.TabIndex = 24;
            this.pictureBox_Reg.TabStop = false;
            this.pictureBox_Reg.Click += new System.EventHandler(this.pictureBox_Reg_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 40);
            this.label3.TabIndex = 25;
            this.label3.Text = "INVENTARIO";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // MODIFICAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(769, 573);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox_Reg);
            this.Controls.Add(this.link_MaterialesInac);
            this.Controls.Add(this.dataGrid_Stock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MODIFICAR";
            this.Text = "INVENTARIO";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Stock)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Reg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_noSerie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_materialesBusc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGrid_Stock;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.LinkLabel link_MaterialesInac;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn noSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn metMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamMaterial;
        private System.Windows.Forms.DataGridViewImageColumn stock;
        private System.Windows.Forms.DataGridViewImageColumn ELIMINAR;
        private System.Windows.Forms.PictureBox pictureBox_Reg;
        private System.Windows.Forms.Label label3;
    }
}
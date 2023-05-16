namespace SYSTEM_INVENTARIO_MAGENTA_DIGITAL
{
    partial class DETALLE_PEDIDO
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DETALLE_PEDIDO));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_noPedido = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_NomPedido = new System.Windows.Forms.Label();
            this.dataGrid_detllePedido = new System.Windows.Forms.DataGridView();
            this.richTextBox_detalle = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.noSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_detllePedido)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "NO. DE PEDIDO:";
            // 
            // lbl_noPedido
            // 
            this.lbl_noPedido.AutoSize = true;
            this.lbl_noPedido.Location = new System.Drawing.Point(158, 31);
            this.lbl_noPedido.Name = "lbl_noPedido";
            this.lbl_noPedido.Size = new System.Drawing.Size(54, 13);
            this.lbl_noPedido.TabIndex = 1;
            this.lbl_noPedido.Text = "(PEDIDO)";
            this.lbl_noPedido.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "A NOMBRE:";
            // 
            // lbl_NomPedido
            // 
            this.lbl_NomPedido.AutoSize = true;
            this.lbl_NomPedido.Location = new System.Drawing.Point(342, 30);
            this.lbl_NomPedido.Name = "lbl_NomPedido";
            this.lbl_NomPedido.Size = new System.Drawing.Size(149, 13);
            this.lbl_NomPedido.TabIndex = 3;
            this.lbl_NomPedido.Text = "(NOMBRE DE LA PERSONA)";
            // 
            // dataGrid_detllePedido
            // 
            this.dataGrid_detllePedido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid_detllePedido.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGrid_detllePedido.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_detllePedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_detllePedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_detllePedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noSerie,
            this.material,
            this.cantidad});
            this.dataGrid_detllePedido.Location = new System.Drawing.Point(48, 76);
            this.dataGrid_detllePedido.Name = "dataGrid_detllePedido";
            this.dataGrid_detllePedido.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_detllePedido.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_detllePedido.RowHeadersVisible = false;
            this.dataGrid_detllePedido.Size = new System.Drawing.Size(443, 150);
            this.dataGrid_detllePedido.TabIndex = 4;
            this.dataGrid_detllePedido.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_detllePedido_CellClick);
            // 
            // richTextBox_detalle
            // 
            this.richTextBox_detalle.Location = new System.Drawing.Point(48, 268);
            this.richTextBox_detalle.Name = "richTextBox_detalle";
            this.richTextBox_detalle.Size = new System.Drawing.Size(443, 44);
            this.richTextBox_detalle.TabIndex = 5;
            this.richTextBox_detalle.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Detalle:";
            // 
            // noSerie
            // 
            this.noSerie.HeaderText = "NO. DE SERIE";
            this.noSerie.Name = "noSerie";
            this.noSerie.Width = 200;
            // 
            // material
            // 
            this.material.HeaderText = "MATERIAL";
            this.material.Name = "material";
            this.material.Width = 125;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "CANTIDAD";
            this.cantidad.Name = "cantidad";
            this.cantidad.Width = 125;
            // 
            // DETALLE_PEDIDO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 353);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox_detalle);
            this.Controls.Add(this.dataGrid_detllePedido);
            this.Controls.Add(this.lbl_NomPedido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_noPedido);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DETALLE_PEDIDO";
            this.Text = "DETALLE_PEDIDO";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_detllePedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_noPedido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_NomPedido;
        private System.Windows.Forms.DataGridView dataGrid_detllePedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn noSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn material;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.RichTextBox richTextBox_detalle;
        private System.Windows.Forms.Label label2;
    }
}
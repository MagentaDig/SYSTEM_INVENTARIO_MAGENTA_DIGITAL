namespace SYSTEM_INVENTARIO_MAGENTA_DIGITAL
{
    partial class MATERIALES_INACTIVOS
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
            this.dataGridView_MatInac = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noSerie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.habilitar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MatInac)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_MatInac
            // 
            this.dataGridView_MatInac.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_MatInac.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_MatInac.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_MatInac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MatInac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.noSerie,
            this.nombre,
            this.habilitar});
            this.dataGridView_MatInac.Location = new System.Drawing.Point(35, 25);
            this.dataGridView_MatInac.Name = "dataGridView_MatInac";
            this.dataGridView_MatInac.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_MatInac.RowHeadersVisible = false;
            this.dataGridView_MatInac.Size = new System.Drawing.Size(448, 241);
            this.dataGridView_MatInac.TabIndex = 0;
            this.dataGridView_MatInac.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_MatInac_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // noSerie
            // 
            this.noSerie.HeaderText = "NO.SERIE";
            this.noSerie.Name = "noSerie";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "MATERIAL";
            this.nombre.Name = "nombre";
            this.nombre.Width = 150;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "HABILITAR";
            this.dataGridViewImageColumn1.Image = global::SYSTEM_INVENTARIO_MAGENTA_DIGITAL.Properties.Resources.icon_1ccfa23b8f52656dbb6975dab8c21268_1;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // habilitar
            // 
            this.habilitar.HeaderText = "HABILITAR";
            this.habilitar.Image = global::SYSTEM_INVENTARIO_MAGENTA_DIGITAL.Properties.Resources.icon_1ccfa23b8f52656dbb6975dab8c21268_1;
            this.habilitar.Name = "habilitar";
            this.habilitar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.habilitar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // MATERIALES_INACTIVOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(520, 297);
            this.Controls.Add(this.dataGridView_MatInac);
            this.Name = "MATERIALES_INACTIVOS";
            this.Text = "MATERIALES_INACTIVOS";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MatInac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_MatInac;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn noSerie;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewImageColumn habilitar;
    }
}
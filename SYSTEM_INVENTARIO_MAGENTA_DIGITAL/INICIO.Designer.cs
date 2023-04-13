namespace SYSTEM_INVENTARIO_MAGENTA_DIGITAL
{
    partial class INICIO
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
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.lbl_categoriaSelect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categoria.Location = new System.Drawing.Point(201, 19);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(81, 16);
            this.lbl_categoria.TabIndex = 0;
            this.lbl_categoria.Text = "Categoria: ";
            // 
            // lbl_categoriaSelect
            // 
            this.lbl_categoriaSelect.AutoSize = true;
            this.lbl_categoriaSelect.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categoriaSelect.Location = new System.Drawing.Point(288, 19);
            this.lbl_categoriaSelect.Name = "lbl_categoriaSelect";
            this.lbl_categoriaSelect.Size = new System.Drawing.Size(175, 17);
            this.lbl_categoriaSelect.TabIndex = 1;
            this.lbl_categoriaSelect.Text = "(Categoria seleccionada)";
            // 
            // INICIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_categoriaSelect);
            this.Controls.Add(this.lbl_categoria);
            this.Name = "INICIO";
            this.Text = "INICIO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_categoria;
        public System.Windows.Forms.Label lbl_categoriaSelect;
    }
}
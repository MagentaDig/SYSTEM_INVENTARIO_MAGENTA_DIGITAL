namespace SYSTEM_INVENTARIO_MAGENTA_DIGITAL
{
    partial class INGRESO
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_categoria = new System.Windows.Forms.ComboBox();
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_categoria
            // 
            this.cb_categoria.FormattingEnabled = true;
            this.cb_categoria.Location = new System.Drawing.Point(308, 174);
            this.cb_categoria.Name = "cb_categoria";
            this.cb_categoria.Size = new System.Drawing.Size(232, 21);
            this.cb_categoria.TabIndex = 0;
            this.cb_categoria.SelectedIndexChanged += new System.EventHandler(this.cb_categoria_SelectedIndexChanged);
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categoria.Location = new System.Drawing.Point(302, 121);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(187, 32);
            this.lbl_categoria.TabIndex = 1;
            this.lbl_categoria.Text = "Ingresar con:";
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Location = new System.Drawing.Point(308, 242);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(122, 37);
            this.btn_ingresar.TabIndex = 2;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // INGRESO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 450);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.lbl_categoria);
            this.Controls.Add(this.cb_categoria);
            this.Name = "INGRESO";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_categoria;
        private System.Windows.Forms.Label lbl_categoria;
        private System.Windows.Forms.Button btn_ingresar;
    }
}


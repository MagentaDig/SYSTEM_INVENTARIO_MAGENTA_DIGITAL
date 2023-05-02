namespace SYSTEM_INVENTARIO_MAGENTA_DIGITAL
{
    partial class INGRESOUSUARIO
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
            System.Windows.Forms.Button btn_cerrar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INGRESOUSUARIO));
            this.lbl_categoria = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.btn_ingresa = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            btn_cerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_cerrar.Image = global::SYSTEM_INVENTARIO_MAGENTA_DIGITAL.Properties.Resources.Captura_de_pantalla_2023_04_18_143816;
            btn_cerrar.Location = new System.Drawing.Point(654, 12);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new System.Drawing.Size(48, 38);
            btn_cerrar.TabIndex = 11;
            btn_cerrar.UseVisualStyleBackColor = true;
            btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // lbl_categoria
            // 
            this.lbl_categoria.AutoSize = true;
            this.lbl_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categoria.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_categoria.Location = new System.Drawing.Point(303, 56);
            this.lbl_categoria.Name = "lbl_categoria";
            this.lbl_categoria.Size = new System.Drawing.Size(76, 25);
            this.lbl_categoria.TabIndex = 6;
            this.lbl_categoria.Text = "USER:";
            this.lbl_categoria.Click += new System.EventHandler(this.lbl_categoria_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(303, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "CLAVE DE ACCESO:";
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(170)))));
            this.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_usuario.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_usuario.Location = new System.Drawing.Point(354, 107);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(214, 13);
            this.txt_usuario.TabIndex = 12;
            this.txt_usuario.TextChanged += new System.EventHandler(this.txt_usuario_TextChanged);
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(170)))));
            this.txt_contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_contraseña.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_contraseña.Location = new System.Drawing.Point(354, 238);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.PasswordChar = '*';
            this.txt_contraseña.Size = new System.Drawing.Size(214, 13);
            this.txt_contraseña.TabIndex = 13;
            this.txt_contraseña.TextChanged += new System.EventHandler(this.txt_contraseña_TextChanged);
            // 
            // btn_ingresa
            // 
            this.btn_ingresa.FlatAppearance.BorderSize = 0;
            this.btn_ingresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ingresa.Image = global::SYSTEM_INVENTARIO_MAGENTA_DIGITAL.Properties.Resources.Captura_de_pantalla_2023_04_18_142657;
            this.btn_ingresa.Location = new System.Drawing.Point(405, 284);
            this.btn_ingresa.Name = "btn_ingresa";
            this.btn_ingresa.Size = new System.Drawing.Size(114, 47);
            this.btn_ingresa.TabIndex = 10;
            this.btn_ingresa.UseVisualStyleBackColor = true;
            this.btn_ingresa.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SYSTEM_INVENTARIO_MAGENTA_DIGITAL.Properties.Resources.Captura_de_pantalla_2023_04_18_143622;
            this.pictureBox3.Location = new System.Drawing.Point(333, 225);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(260, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SYSTEM_INVENTARIO_MAGENTA_DIGITAL.Properties.Resources.Captura_de_pantalla_2023_04_18_143622;
            this.pictureBox1.Location = new System.Drawing.Point(333, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = global::SYSTEM_INVENTARIO_MAGENTA_DIGITAL.Properties.Resources.MitadInicio;
            this.pictureBox2.Location = new System.Drawing.Point(-3, -5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(276, 359);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // INGRESOUSUARIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(714, 343);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(btn_cerrar);
            this.Controls.Add(this.btn_ingresa);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_categoria);
            this.Controls.Add(this.pictureBox2);
            this.Name = "INGRESOUSUARIO";
            this.Text = "INGRESOUSUARIO";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_categoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_ingresa;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_contraseña;
    }
}
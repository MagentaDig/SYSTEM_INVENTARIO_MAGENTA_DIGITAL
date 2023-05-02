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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Material = new System.Windows.Forms.Label();
            this.lbl_StockSAct = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NuevoStock = new System.Windows.Forms.TextBox();
            this.btn_Act = new System.Windows.Forms.Button();
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
            // lbl_StockSAct
            // 
            this.lbl_StockSAct.AutoSize = true;
            this.lbl_StockSAct.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StockSAct.Location = new System.Drawing.Point(200, 65);
            this.lbl_StockSAct.Name = "lbl_StockSAct";
            this.lbl_StockSAct.Size = new System.Drawing.Size(98, 17);
            this.lbl_StockSAct.TabIndex = 3;
            this.lbl_StockSAct.Text = "(Stock actual)";
            this.lbl_StockSAct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(200, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stock Actual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(328, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nuevo Stock";
            // 
            // txt_NuevoStock
            // 
            this.txt_NuevoStock.AcceptsReturn = true;
            this.txt_NuevoStock.Location = new System.Drawing.Point(331, 62);
            this.txt_NuevoStock.Name = "txt_NuevoStock";
            this.txt_NuevoStock.Size = new System.Drawing.Size(147, 20);
            this.txt_NuevoStock.TabIndex = 5;
            // 
            // btn_Act
            // 
            this.btn_Act.Location = new System.Drawing.Point(36, 102);
            this.btn_Act.Name = "btn_Act";
            this.btn_Act.Size = new System.Drawing.Size(442, 34);
            this.btn_Act.TabIndex = 6;
            this.btn_Act.Text = "Guardar";
            this.btn_Act.UseVisualStyleBackColor = true;
            this.btn_Act.Click += new System.EventHandler(this.btn_Act_Click);
            // 
            // ACTUALIZAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 165);
            this.Controls.Add(this.btn_Act);
            this.Controls.Add(this.txt_NuevoStock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_StockSAct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Material);
            this.Controls.Add(this.label1);
            this.Name = "ACTUALIZAR";
            this.Text = "ACTUALIZAR";
            this.Load += new System.EventHandler(this.ACTUALIZAR_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Material;
        private System.Windows.Forms.Label lbl_StockSAct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NuevoStock;
        private System.Windows.Forms.Button btn_Act;
    }
}
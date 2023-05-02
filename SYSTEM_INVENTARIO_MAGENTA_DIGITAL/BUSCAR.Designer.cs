namespace SYSTEM_INVENTARIO_MAGENTA_DIGITAL
{
    partial class BUSCAR
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
            this.dataGrid_Stock = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_materialesBusc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_CantBusc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Stock)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_Stock
            // 
            this.dataGrid_Stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Stock.Location = new System.Drawing.Point(43, 122);
            this.dataGrid_Stock.Name = "dataGrid_Stock";
            this.dataGrid_Stock.Size = new System.Drawing.Size(871, 327);
            this.dataGrid_Stock.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccionar Material:";
            // 
            // cb_materialesBusc
            // 
            this.cb_materialesBusc.FormattingEnabled = true;
            this.cb_materialesBusc.Location = new System.Drawing.Point(43, 77);
            this.cb_materialesBusc.Name = "cb_materialesBusc";
            this.cb_materialesBusc.Size = new System.Drawing.Size(167, 21);
            this.cb_materialesBusc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cantidad";
            // 
            // txt_CantBusc
            // 
            this.txt_CantBusc.Location = new System.Drawing.Point(264, 77);
            this.txt_CantBusc.Name = "txt_CantBusc";
            this.txt_CantBusc.Size = new System.Drawing.Size(148, 20);
            this.txt_CantBusc.TabIndex = 4;
            // 
            // BUSCAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 500);
            this.Controls.Add(this.txt_CantBusc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_materialesBusc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid_Stock);
            this.Name = "BUSCAR";
            this.Text = "BUSCAR";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid_Stock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_materialesBusc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_CantBusc;
    }
}
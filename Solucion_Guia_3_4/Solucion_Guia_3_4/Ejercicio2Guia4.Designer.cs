namespace Solucion_Guia_3_4
{
    partial class Ejercicio2Guia4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnfun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(350, 221);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnfun
            // 
            this.btnfun.Location = new System.Drawing.Point(104, 299);
            this.btnfun.Name = "btnfun";
            this.btnfun.Size = new System.Drawing.Size(198, 23);
            this.btnfun.TabIndex = 1;
            this.btnfun.Text = "Numeros aleatorios";
            this.btnfun.UseVisualStyleBackColor = true;
            this.btnfun.Click += new System.EventHandler(this.btnfun_Click);
            // 
            // Ejercicio2Guia4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 450);
            this.Controls.Add(this.btnfun);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Ejercicio2Guia4";
            this.Text = "Ejercicio2Guia4";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnfun;
    }
}
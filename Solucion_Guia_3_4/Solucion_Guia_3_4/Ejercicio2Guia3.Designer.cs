namespace Solucion_Guia_3_4
{
    partial class Ejercicio2Guia3
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
            this.btnintro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtclass = new System.Windows.Forms.TextBox();
            this.txtnote = new System.Windows.Forms.TextBox();
            this.btnshow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnintro
            // 
            this.btnintro.Location = new System.Drawing.Point(189, 156);
            this.btnintro.Name = "btnintro";
            this.btnintro.Size = new System.Drawing.Size(161, 23);
            this.btnintro.TabIndex = 0;
            this.btnintro.Text = "Registrar";
            this.btnintro.UseVisualStyleBackColor = true;
            this.btnintro.Click += new System.EventHandler(this.btnintro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese nombre";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(121, 72);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(308, 20);
            this.txtname.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(575, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // txtclass
            // 
            this.txtclass.Location = new System.Drawing.Point(121, 119);
            this.txtclass.Name = "txtclass";
            this.txtclass.Size = new System.Drawing.Size(172, 20);
            this.txtclass.TabIndex = 4;
            // 
            // txtnote
            // 
            this.txtnote.Location = new System.Drawing.Point(321, 119);
            this.txtnote.Name = "txtnote";
            this.txtnote.Size = new System.Drawing.Size(108, 20);
            this.txtnote.TabIndex = 5;
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(189, 197);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(161, 23);
            this.btnshow.TabIndex = 6;
            this.btnshow.Text = "Mostrar";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ingrese materia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ingrese nota";
            // 
            // Ejercicio2Guia3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.txtnote);
            this.Controls.Add(this.txtclass);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnintro);
            this.Name = "Ejercicio2Guia3";
            this.Text = "Ejercicio2Guia3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnintro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtclass;
        private System.Windows.Forms.TextBox txtnote;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
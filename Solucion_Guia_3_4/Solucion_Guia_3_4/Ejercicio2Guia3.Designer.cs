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
            this.BtnShowI = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnintro
            // 
            this.btnintro.Location = new System.Drawing.Point(252, 192);
            this.btnintro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnintro.Name = "btnintro";
            this.btnintro.Size = new System.Drawing.Size(215, 28);
            this.btnintro.TabIndex = 0;
            this.btnintro.Text = "Registrar";
            this.btnintro.UseVisualStyleBackColor = true;
            this.btnintro.Click += new System.EventHandler(this.btnintro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese nombre";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(161, 89);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(409, 22);
            this.txtname.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 297);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(767, 185);
            this.dataGridView1.TabIndex = 3;
            // 
            // txtclass
            // 
            this.txtclass.Location = new System.Drawing.Point(161, 146);
            this.txtclass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtclass.Name = "txtclass";
            this.txtclass.Size = new System.Drawing.Size(228, 22);
            this.txtclass.TabIndex = 4;
            // 
            // txtnote
            // 
            this.txtnote.Location = new System.Drawing.Point(428, 146);
            this.txtnote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnote.Name = "txtnote";
            this.txtnote.Size = new System.Drawing.Size(143, 22);
            this.txtnote.TabIndex = 5;
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(252, 242);
            this.btnshow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(215, 28);
            this.btnshow.TabIndex = 6;
            this.btnshow.Text = "Mostrar";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 127);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ingrese materia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ingrese nota";
            // 
            // BtnShowI
            // 
            this.BtnShowI.Location = new System.Drawing.Point(613, 499);
            this.BtnShowI.Name = "BtnShowI";
            this.BtnShowI.Size = new System.Drawing.Size(131, 23);
            this.BtnShowI.TabIndex = 9;
            this.BtnShowI.Text = "Terminar";
            this.BtnShowI.UseVisualStyleBackColor = true;
            this.BtnShowI.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ejercicio2Guia3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 554);
            this.Controls.Add(this.BtnShowI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.txtnote);
            this.Controls.Add(this.txtclass);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnintro);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button BtnShowI;
    }
}
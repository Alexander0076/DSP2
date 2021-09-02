namespace Solucion_Guia_3_4
{
    partial class Ejercicio3Guia4
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.List1 = new System.Windows.Forms.ListBox();
            this.List2 = new System.Windows.Forms.ListBox();
            this.List3 = new System.Windows.Forms.ListBox();
            this.TextIngresar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.BtnMosGrades = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(479, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Terminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 37);
            this.button2.TabIndex = 1;
            this.button2.Text = "Atras";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // List1
            // 
            this.List1.FormattingEnabled = true;
            this.List1.ItemHeight = 16;
            this.List1.Location = new System.Drawing.Point(108, 205);
            this.List1.Name = "List1";
            this.List1.Size = new System.Drawing.Size(120, 132);
            this.List1.TabIndex = 2;
            // 
            // List2
            // 
            this.List2.FormattingEnabled = true;
            this.List2.ItemHeight = 16;
            this.List2.Location = new System.Drawing.Point(293, 205);
            this.List2.Name = "List2";
            this.List2.Size = new System.Drawing.Size(120, 132);
            this.List2.TabIndex = 3;
            // 
            // List3
            // 
            this.List3.FormattingEnabled = true;
            this.List3.ItemHeight = 16;
            this.List3.Location = new System.Drawing.Point(479, 205);
            this.List3.Name = "List3";
            this.List3.Size = new System.Drawing.Size(120, 132);
            this.List3.TabIndex = 4;
            // 
            // TextIngresar
            // 
            this.TextIngresar.Location = new System.Drawing.Point(235, 98);
            this.TextIngresar.Name = "TextIngresar";
            this.TextIngresar.Size = new System.Drawing.Size(150, 22);
            this.TextIngresar.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ingrese las notas: ";
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Location = new System.Drawing.Point(391, 93);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(111, 33);
            this.BtnIngresar.TabIndex = 7;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = true;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // BtnMosGrades
            // 
            this.BtnMosGrades.Location = new System.Drawing.Point(262, 155);
            this.BtnMosGrades.Name = "BtnMosGrades";
            this.BtnMosGrades.Size = new System.Drawing.Size(191, 33);
            this.BtnMosGrades.TabIndex = 8;
            this.BtnMosGrades.Text = "Mostrar notas";
            this.BtnMosGrades.UseVisualStyleBackColor = true;
            // 
            // Ejercicio3Guia4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 450);
            this.Controls.Add(this.BtnMosGrades);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextIngresar);
            this.Controls.Add(this.List3);
            this.Controls.Add(this.List2);
            this.Controls.Add(this.List1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Ejercicio3Guia4";
            this.Text = "Ejercicio3Guia4";
            this.Load += new System.EventHandler(this.Ejercicio3Guia4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox List1;
        private System.Windows.Forms.ListBox List2;
        private System.Windows.Forms.ListBox List3;
        private System.Windows.Forms.TextBox TextIngresar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.Button BtnMosGrades;
    }
}
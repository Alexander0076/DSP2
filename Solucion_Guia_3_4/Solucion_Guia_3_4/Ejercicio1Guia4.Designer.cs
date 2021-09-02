namespace Solucion_Guia_3_4
{
    partial class Ejercicio1Guia4
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
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.BtnSiguiente = new System.Windows.Forms.Button();
            this.List = new System.Windows.Forms.ListBox();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.TxtInsertar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.Location = new System.Drawing.Point(23, 403);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(101, 35);
            this.BtnRegresar.TabIndex = 0;
            this.BtnRegresar.Text = "Regresar";
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnSiguiente
            // 
            this.BtnSiguiente.Location = new System.Drawing.Point(245, 403);
            this.BtnSiguiente.Name = "BtnSiguiente";
            this.BtnSiguiente.Size = new System.Drawing.Size(101, 35);
            this.BtnSiguiente.TabIndex = 1;
            this.BtnSiguiente.Text = "Siguiente";
            this.BtnSiguiente.UseVisualStyleBackColor = true;
            this.BtnSiguiente.Click += new System.EventHandler(this.BtnSiguiente_Click);
            // 
            // List
            // 
            this.List.FormattingEnabled = true;
            this.List.ItemHeight = 16;
            this.List.Location = new System.Drawing.Point(33, 114);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(163, 228);
            this.List.TabIndex = 2;
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.Location = new System.Drawing.Point(211, 74);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(135, 23);
            this.BtnInsertar.TabIndex = 3;
            this.BtnInsertar.Text = "Insertar";
            this.BtnInsertar.UseVisualStyleBackColor = true;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(211, 103);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(135, 23);
            this.BtnEliminar.TabIndex = 4;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(211, 132);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(135, 23);
            this.BtnMostrar.TabIndex = 5;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // TxtInsertar
            // 
            this.TxtInsertar.Location = new System.Drawing.Point(33, 75);
            this.TxtInsertar.Name = "TxtInsertar";
            this.TxtInsertar.Size = new System.Drawing.Size(163, 22);
            this.TxtInsertar.TabIndex = 6;
            // 
            // Ejercicio1Guia4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 450);
            this.Controls.Add(this.TxtInsertar);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnInsertar);
            this.Controls.Add(this.List);
            this.Controls.Add(this.BtnSiguiente);
            this.Controls.Add(this.BtnRegresar);
            this.Name = "Ejercicio1Guia4";
            this.Text = "Ejercicio1Guia4";
            this.Load += new System.EventHandler(this.Ejercicio1Guia4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnRegresar;
        private System.Windows.Forms.Button BtnSiguiente;
        private System.Windows.Forms.ListBox List;
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.TextBox TxtInsertar;
    }
}
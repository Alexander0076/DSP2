using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solucion_Guia_3_4
{
    public partial class Ejercicio3Guia4 : Form
    {
        float[] notas = new float[10];
        public Ejercicio3Guia4()
        {
            InitializeComponent();
        }

        private void Ejercicio3Guia4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ejercicio2Guia4 eje2guia4 = new Ejercicio2Guia4();
            eje2guia4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
           
        }
        public decimal Nota (decimal grade)
        {

        }
    }
}

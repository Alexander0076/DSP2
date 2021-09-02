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
    public partial class Ejercicio1Guia4 : Form
    {
        string dato = "";

        public Ejercicio1Guia4()
        {
            InitializeComponent();
        }

        private void Ejercicio1Guia4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            hide();
            Ejercicio2Guia4 eje2guia4 = new Ejercicio2Guia4();
            eje2guia4.Show();
        }

        public void hide()
        {
            this.Hide();
        }


        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            dato = TxtInsertar.Text;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {

            List.Items.Add(LlenarList(dato));

        }
        int x = 0;
        public String LlenarList(string dato)
        {
            string[] añadir = new string[9999];


            for (int i = 0; i <= añadir.Length; i++)
            {
                añadir[i] = dato;
                x++;
            }
            return añadir[x];
        }
        
    }
}

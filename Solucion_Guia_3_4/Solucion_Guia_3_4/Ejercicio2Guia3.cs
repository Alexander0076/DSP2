using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solucion_Guia_3_4
{
    public partial class Ejercicio2Guia3 : Form
    {
        
        ArrayList nombre, materias, notas;
        double suma = 0, promedio = 0;
        public Ejercicio2Guia3()
        {
            InitializeComponent();
            nombre = new ArrayList();
            materias = new ArrayList();
            notas = new ArrayList();

        }

        private void Ejercicio2Guia3_Load(object sender, EventArgs e)
        {

        }

        private void btnintro_Click(object sender, EventArgs e)
        {
            nombre.Add(txtname.Text);
            materias.Add(txtclass.Text);
            notas.Add(txtnote.Text);

            txtnote.Clear();
            txtclass.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {

            //dataGridView1.Columns.Clear();
            //dataGridView1.Columns.Add("Nombre", "Nombre");
            //dataGridView1.Columns.Add("Materias", "Materias");
            //dataGridView1.Columns.Add("Nota", "Nota");
            //for (int i = 0; i < 1; i++)
            //{
            //    foreach (String name in nombre)
            //    {
            //        dataGridView1.Rows.Add(name);
            //    }

            //    foreach (String clase in materias)
            //    {
            //        dataGridView1.Rows[i].Cells[1].Value = clase;
            //    }
            //    foreach (String note in notas)
            //    {
            //        dataGridView1.Rows[i].Cells[2].Value = note;
            //    }
            //}

            //creando columnas 
            dataGridView1.Columns.Clear();
            dataGridView2.Columns.Clear();
            dataGridView3.Columns.Clear();
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView2.Columns.Add("Materias", "Materias");
            dataGridView3.Columns.Add("Nota", "Nota");
            foreach (String name in nombre)
            {
                dataGridView1.Rows.Add(name);
            }
            foreach (String clase in materias)
            {
                dataGridView2.Rows.Add(clase);
            }
            for (int note = 0; note <(notas.Count); note++)
            {
                dataGridView3.Rows.Add(notas[note]);
                suma += Convert.ToInt32(note);
            }
            promedio = suma/ notas.Count;
            txtmedia.Text = promedio.ToString();


        }
    }
}

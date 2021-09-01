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
    public partial class Ejercicio1Guia3 : Form
    {
        List<string> name = new List<string>();
        public Ejercicio1Guia3()
        {
            InitializeComponent();
        }

        private void Ejercicio1Guia3_Load(object sender, EventArgs e)
        {

        }

        private void BtnName_Click(object sender, EventArgs e)
        {
            name.Add(TxtName.Text);
            TxtName.Clear();            
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            DataName.Columns.Clear();
            DataName.Rows.Clear();
            DataName.Columns.Add("Name", "Name");
            foreach (String item in name)
            {
                DataName.Rows.Add(item);
            }
            
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ejercicio2Guia3 eje2guia3 = new Ejercicio2Guia3();
            eje2guia3.Show();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            name.Remove(TxtEliminar.Text);
            DataName.Columns.Clear();
            DataName.Rows.Clear();
            DataName.Columns.Add("Name", "Name");
            foreach (String item in name)
            {
                DataName.Rows.Add(item);
            }
            TxtEliminar.Clear();

        }

        private void BtnModName_Click(object sender, EventArgs e)
        {
            var indice = name.IndexOf(TxtNameOld.Text);
            name.RemoveAt(indice);
            name.Insert(indice,TxtNameNew.Text);
            DataName.Columns.Clear();
            DataName.Rows.Clear();
            DataName.Columns.Add("Name", "Name");
            foreach (String item in name)
            {
                DataName.Rows.Add(item);
            }
            TxtNameNew.Clear();
            TxtNameOld.Clear();
        }
    }
}

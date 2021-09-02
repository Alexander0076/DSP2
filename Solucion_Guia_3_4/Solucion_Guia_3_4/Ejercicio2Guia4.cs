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
    public partial class Ejercicio2Guia4 : Form
    {
        private void crearGrilla(DataGridView grilla)
        {
            grilla.ColumnCount = 5;
            grilla.RowCount = 5;
            foreach (DataGridView y in grilla.Columns)
            {
                y.Width = 70;
                foreach (DataGridView  x in grilla.Rows)
                {
                    x.Height = 50;
                }
            }
        }
        private void llenarmatriz(int[,] vector)
        {
            Random aleatorio = new Random();
            for(int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    vector[i, j] = aleatorio.Next();
                }
            }
        }
        private void llenarTabla(DataGridView grilla, int[,] m)
        {
            int f, c;
            f = 0;
            foreach (DataGridViewRow y in grilla.Rows)
            {
                c = 0;
                foreach (DataGridViewCell x in y.Cells)
                {
                    x.Value = m[f, c];
                    c++;
                }
                f++;
            }
        }
        public Ejercicio2Guia4()
        {
            InitializeComponent();
        }

        private void btnfun_Click(object sender, EventArgs e)
        {
            int[,] matriz;
            matriz = new int[5, 5];

            llenarmatriz(matriz);
            llenarTabla(dataGridView1, matriz);
        }
    }
}

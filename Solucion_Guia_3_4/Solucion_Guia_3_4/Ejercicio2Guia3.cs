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
    public partial class Ejercicio2Guia3 : Form
    {
        public static bool IsNumeric(string valor)
        { //Determina si parametro valor puede convertirse a numero entero 
            int result;
            return int.TryParse(valor, out result); 

        }
            String[,] datos = new string[6,5];
        public int fila, colum;
        public Ejercicio2Guia3()
        {
            InitializeComponent();
        }

        private void btnintro_Click(object sender, EventArgs e)
        {
            if (fila < 6)
            { //agregamos el dato en la posicion [fila1,column1] de la matriz 
                datos[fila, colum] = txtname.Text;
                //pasamos a la siguiente fila de la matriz 
                fila += 1;
                txtname.Clear();
            }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {

        }
    }
}

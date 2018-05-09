using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ClassLibrary1;

namespace CosaForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int entero;
            string cadena;
            DateTime fecha;

            entero = int.Parse(this.txtEntero.Text);
            cadena = this.txtCadena.Text;
            fecha = DateTime.Parse(this.txtFecha.Text);

            Cosa test = new Cosa(entero, cadena, fecha);
            MessageBox.Show(test.Mostrar(),"Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}

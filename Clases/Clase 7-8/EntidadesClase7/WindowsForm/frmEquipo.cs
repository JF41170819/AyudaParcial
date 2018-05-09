using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EntidadesClase7;

namespace WindowsForm
{
    public partial class frmEquipo : Form
    {
        public frmEquipo()
        {
            InitializeComponent();
        }

        private void frmEquipo_Load(object sender, EventArgs e)
        {

        }

        private Equipo _equipo;
        private Jugador _jugador;
        bool validacion;

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = (this.txtNombre.Text);
            short CantidadJugadores = short.Parse(this.txtCantidadJugadores.Text);

            this._equipo = new Equipo(CantidadJugadores, nombre);

            this.txtNombre.Enabled = false;
            this.txtCantidadJugadores.Enabled = false;
            this.btnAceptar.Visible = false;
            this.btnCancelar.Visible = false;

            this.btnMas.Visible = true;
            this.listBox.Visible = true;
            
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            frmJugador formulario = new frmJugador();

            formulario.ShowDialog();

            if (formulario.DialogResult == System.Windows.Forms.DialogResult.OK)
            {

                this._jugador = formulario.getJugador();

                validacion = this._equipo + this._jugador;

                if (validacion)
                {
                    MessageBox.Show("Correcto!, se ha podido agregar correctamente.");
                    this.AgregarYMostrar();
                    btnMenos.Visible = true;
                    btnModificar.Visible = true;
                }
                else
                {
                    MessageBox.Show("Error, no se ha podido agregar correctamente.");
                }

            }

        }

        private void AgregarYMostrar()
        {
            List<Jugador> list = this._equipo.GetJugadores();

            this.listBox.Items.Clear();

            for (int i = 0; i < list.Count ; i++)
            {
                this.listBox.Items.Add(list[i].MostrarDatos());
            }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            int indice = this.listBox.SelectedIndex;
            bool validacion;

            if (indice > -1)
            {
                List<Jugador> list = this._equipo.GetJugadores();

                DialogResult respuesta = MessageBox.Show("Desea eliminar el siguiente jugador?: " + list[indice].MostrarDatos(), "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (respuesta == DialogResult.OK)
                {
                    validacion = this._equipo - list[indice];

                    if (validacion)
                    {
                        this.listBox.Items.Clear();
                        this.AgregarYMostrar();
                    }

                }
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indice = this.listBox.SelectedIndex;
            //bool validacion;

            if (indice > -1)
            {
                List<Jugador> list = this._equipo.GetJugadores();

                DialogResult respuesta = MessageBox.Show("Desea modificar el siguiente jugador?: " + list[indice].MostrarDatos(), "Mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (respuesta == DialogResult.OK)
                {
                    frmJugador formulario = new frmJugador(list[indice]);
                    formulario.ShowDialog();

                    if (formulario.DialogResult == System.Windows.Forms.DialogResult.OK)
                    {
                        list[indice] = formulario.getJugador();
                        AgregarYMostrar();
                    }
                }
            }

        }
    }
}

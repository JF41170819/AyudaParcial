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
    public partial class frmJugador : Form
    {
        public frmJugador()
        {
            InitializeComponent();
        }

        public frmJugador(Jugador objJugador):this()
        {
            this._jugador = objJugador;
            this.txtDni.Text = Convert.ToString(objJugador.Dni);
            this.txtNombre.Text = objJugador.Nombre;
            this.txtPartidosJugados.Text = Convert.ToString(objJugador.PartidosJugados);
            this.txtGoles.Text = Convert.ToString(objJugador.TotalGoles);
            this.txtDni.Enabled = false;
        }


        private void BTNAceptar_Click(object sender, EventArgs e)
        {
            long dni = long.Parse(this.txtDni.Text);
            string nombre = (this.txtNombre.Text);
            int goles = int.Parse(this.txtGoles.Text);
            int partidos = int.Parse(this.txtPartidosJugados.Text);

            this._jugador = new Jugador(nombre, dni, goles, partidos);

            //MessageBox.Show(_jugador.MostrarDatos());

            if ((object)this._jugador != null)
            {
                this._jugador.Nombre = this.txtNombre.Text;
                this._jugador.PartidosJugados = int.Parse(this.txtPartidosJugados.Text);
                this._jugador.TotalGoles = int.Parse(this.txtGoles.Text);
            }
            else
            {
                this._jugador = new Jugador(nombre, dni, goles, partidos);
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;

        }

        private Jugador _jugador;

        public Jugador getJugador()
        {
            return this._jugador;
        }

        private void frmJugador_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}

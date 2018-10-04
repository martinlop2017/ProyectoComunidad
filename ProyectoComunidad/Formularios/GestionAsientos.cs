using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoComunidad.Formularios
{
    public partial class GestionAsientos : Form
    {
        public GestionAsientos()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void sumar_Click(object sender, EventArgs e)
        {
            Asientos form = new Asientos();
            form.Show();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

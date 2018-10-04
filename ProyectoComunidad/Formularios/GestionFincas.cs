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
    public partial class GestionFincas : Form
    {
        public GestionFincas()
        {
            InitializeComponent();
        }

        private void GestionFincas_Load(object sender, EventArgs e)
        {

        }

        private void salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sumar_Click(object sender, EventArgs e)
        {
            Fincas form = new Fincas();
            form.Show();
        }
    }
}

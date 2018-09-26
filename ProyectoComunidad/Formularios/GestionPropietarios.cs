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
    public partial class GestionPropietarios : Form
    {
        public GestionPropietarios()
        {
            InitializeComponent();
        }

        private void GestionPropietarios_Load(object sender, EventArgs e)
        {

        }

        private void sumar_Click(object sender, EventArgs e)
        {
            Propietarios form = new Propietarios();
            form.Show();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

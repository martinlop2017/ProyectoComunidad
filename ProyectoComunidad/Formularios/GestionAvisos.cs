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
    public partial class GestionAvisos : Form
    {
        public GestionAvisos()
        {
            InitializeComponent();
        }

        private void sumar_Click(object sender, EventArgs e)
        {
            Altaavisos form = new Altaavisos();
            form.Show();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

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
    public partial class GestionLiquidaciones : Form
    {
        public GestionLiquidaciones()
        {
            InitializeComponent();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sumar_Click(object sender, EventArgs e)
        {
            Cbs19 form = new Cbs19();
            form.Show();
        }
    }
}

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
    public partial class Control_Usuarios : Form
    {
        public Control_Usuarios()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
           button1.BackgroundImage = ProyectoComunidad.Properties.Resources.Llave_seleccionado;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = ProyectoComunidad.Properties.Resources.Llave;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Abre el menu principal
           // Globales.llamadas = comboBox1.Text;
            MenuInicio form = new MenuInicio();
            form.Show();
        }
    }
}

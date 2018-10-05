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
            // TODO: esta línea de código carga datos en la tabla 'administracionComunidadDataSet.Comunidades' Puede moverla o quitarla según sea necesario.
            this.comunidadesTableAdapter.Fill(this.administracionComunidadDataSet.Comunidades);
            // TODO: esta línea de código carga datos en la tabla 'administracionComunidadDataSet.Comunidades' Puede moverla o quitarla según sea necesario.
            this.comunidadesTableAdapter.Fill(this.administracionComunidadDataSet.Comunidades);
            // TODO: esta línea de código carga datos en la tabla 'administracionComunidadDataSet.Comunidades' Puede moverla o quitarla según sea necesario.
            this.comunidadesTableAdapter.Fill(this.administracionComunidadDataSet.Comunidades);
            // TODO: esta línea de código carga datos en la tabla 'administracionComunidadDataSet.Partidas' Puede moverla o quitarla según sea necesario.
            this.partidasTableAdapter.Fill(this.administracionComunidadDataSet.Partidas);

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

        private void sumar_MouseEnter(object sender, EventArgs e)
        {
            label1.Visible = true;
        }

        private void sumar_MouseLeave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void eliminar_Enter(object sender, EventArgs e)
        {

        }

        private void eliminar_MouseEnter(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void eliminar_MouseLeave(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void modificar_MouseEnter(object sender, EventArgs e)
        {
            label3.Visible = true;
        }

        private void modificar_MouseLeave(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            label4.Visible = true;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            label4.Visible = true;
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            label6.Visible = true;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            label6.Visible = false;
        }

        private void comboBox1_MouseEnter(object sender, EventArgs e)
        {
            label6.Visible = true;
        }

        private void comboBox1_MouseLeave(object sender, EventArgs e)
        {
            label6.Visible = false;
        }

        private void salir_MouseEnter(object sender, EventArgs e)
        {
            label5.Visible = true;
        }

        private void salir_MouseLeave(object sender, EventArgs e)
        {
            label5.Visible = false;
        }
    }
}

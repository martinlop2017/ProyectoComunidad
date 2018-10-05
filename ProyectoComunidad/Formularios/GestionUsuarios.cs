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
    public partial class GestionUsuarios : Form
    {

        AdministracionComunidadEntities bd;

        public GestionUsuarios()
        {
            InitializeComponent();
            bd = new AdministracionComunidadEntities();
        }

        private void sumar_Click(object sender, EventArgs e)
        {
            Globales.llamadas = "1";
            Usuarios form = new Usuarios();
            form.Show();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GestionUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'administracionComunidadDataSet.Usantes' Puede moverla o quitarla según sea necesario.
            //   this.usantesTableAdapter.Fill(this.administracionComunidadDataSet.Usantes);
            //CARGA LOS REGISTROS EN EL GRIP AL INICIAR EL FORM

            var cargaclientes = bd.Usantes.OrderBy(x => x.numerador);
            dgvUsuario.DataSource = cargaclientes.ToList();
            dgvUsuario.Refresh();



            /*
            var resfresco = bd.Usantes.ToList();

            dgvUsuario.DataSource = resfresco.ToList();
            dgvUsuario.Refresh();

            dgvUsuario.DataSource = "";
            dgvUsuario.DataSource = resfresco.ToList();
            dgvUsuario.Refresh();
            */
        }

        private void modificar_Click(object sender, EventArgs e)
        {   
            // Inicializa la variable global llamadas
            Globales.llamadas = "2";

            // creamos una variable que va aguardar los datos de la fila seleccionada en el dbgrid
            Globales.modificar = Convert.ToInt16(dgvUsuario.CurrentRow.Cells[0].Value);

            // Abre Ususarios
            Usuarios form = new Usuarios();
            form.Show();
        }

        private void GestionUsuarios_Activated(object sender, EventArgs e)
        {

            


        }

        private void GestionUsuarios_Enter(object sender, EventArgs e)
        {
            var cargaclientes = bd.Usantes.OrderBy(x => x.numerador);
            dgvUsuario.DataSource = cargaclientes.ToList();
            dgvUsuario.Refresh();

        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            try
            {



                if (MessageBox.Show("Confirme La Eliminación del Registro.", "Eliminar Registro",
                    MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    // creamos una variable que va aguardar los datos de la fila seleccionada en el dbgrid

                    int valor1 = Convert.ToInt16(dgvUsuario.CurrentRow.Cells[0].Value);

                    //*** borrar
                    //busca en la tabla la fila con el registro suminstrado
                    //y si lo encuentra borra la linea de la base de datos

                    var borrar = bd.Usantes.SingleOrDefault(codusuario => codusuario.numerador == valor1);
                    if (borrar != null)
                    {
                        bd.Usantes.Remove(borrar);
                    }


                    //guardamos los cambios
                    bd.SaveChanges();

                    // Refrescamos el dbgrid
                    dgvUsuario.DataSource = bd.Usantes.ToList();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No ha sido posible eliminar los datos", "Error 103");
            }
        }

        private void sumar_MouseEnter(object sender, EventArgs e)
        {
            label1.Visible = true;

        }

        private void sumar_MouseLeave(object sender, EventArgs e)
        {
            label1.Visible = false;
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

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        private void salir_MouseEnter(object sender, EventArgs e)
        {
            label5.Visible = true;
        }

        private void salir_MouseLeave(object sender, EventArgs e)
        {
            label5.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var busqueda = from c in bd.Usantes select c;
            busqueda = busqueda.Where(c => c.nombre.Contains(textBox1.Text)).OrderBy(x => x.nombre);

            dgvUsuario.DataSource = busqueda.ToList();
        }
    }
}

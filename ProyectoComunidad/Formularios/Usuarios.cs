using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ProyectoComunidad.Clases;

namespace ProyectoComunidad.Formularios
{
    public partial class Usuarios : Form
    {

        AdministracionComunidadEntities bd;

        public Usuarios()
        {
            InitializeComponent();
            bd = new AdministracionComunidadEntities();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            //SI ENTRAMOS DESDE AÑADIR NUEVO REGISTRO.
            if (Globales.llamadas == "1")
            {

                try
                {
                    //**** calculamos el valor de la coluna numerador
                    //  var ultimocod = bd.Ususarios.OrderByDescending(x => x.cod).First().cod;

                    //****GRABA LOS DATOS EN LA TABLA
                    var nuevoUsuario = new Usantes();

                    nuevoUsuario.numerador = Convert.ToInt32(label1.Text);
                    nuevoUsuario.nombre = textBox1.Text;
                    // encriptamos la contaraseña con la clase encriptar
                    nuevoUsuario.password = Encriptar.codificar(maskedTextBox1.Text);
                    nuevoUsuario.nivel = comboBox1.Text;
                    if (radioButton1.Checked == true)
                    {
                        nuevoUsuario.activo = true;
                    }
                    else
                    {
                        nuevoUsuario.activo = false;
                    }
                    nuevoUsuario.pregunta = textBox2.Text;
                    nuevoUsuario.respuesta = Encriptar.codificar(textBox3.Text);


                    bd.Usantes.Add(nuevoUsuario);

                    //guardamos los cambios
                    bd.SaveChanges();



                }
                catch (Exception)
                {
                    MessageBox.Show("No ha sido posible grabar los datos", "Error 101");
                }


            }


            if (Globales.llamadas == "2")
            {


                try
                {

                    //extraemos los datos correspondientes de la tabla en el objeto
                    var usuarioAmodificar = bd.Usantes.SingleOrDefault(codusuario => codusuario.numerador == Globales.modificar);

                    //modificamos los valores

                    usuarioAmodificar.nombre = textBox1.Text;
                    usuarioAmodificar.password = Encriptar.codificar(maskedTextBox1.Text);
                    usuarioAmodificar.pregunta = textBox2.Text;
                    usuarioAmodificar.respuesta = Encriptar.codificar(textBox3.Text);
                    usuarioAmodificar.nivel = comboBox1.Text;

                    if (radioButton1.Checked == true)
                    {
                        usuarioAmodificar.activo = true;
                    }
                    else
                    {
                        usuarioAmodificar.activo = false;
                    }



                    //guardamos los cambios
                    bd.SaveChanges();


                }
                catch (Exception)
                {
                    MessageBox.Show("No ha sido posible modificar los datos", "Error 102");
                }



            }
            Close();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            maskedTextBox1.UseSystemPasswordChar = false;
            maskedTextBox2.UseSystemPasswordChar = false;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            maskedTextBox1.UseSystemPasswordChar = true;
            maskedTextBox2.UseSystemPasswordChar = true;
        }

        private void maskedTextBox2_Leave(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != maskedTextBox2.Text)
            {
                MessageBox.Show("Los valores no coinciden.");
                maskedTextBox2.Text = "";
                maskedTextBox1.Text = "";
                maskedTextBox1.Focus();
            }
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {

            //SI ENTRAMOS DESDE AÑADIR
            if ( Globales.llamadas == "1")
            {
                string cod;
                //**** calculamos el valor de la coluna numerador
                var ultimocod = bd.Usantes.OrderByDescending(x => x.numerador).ToList();// First().cod;
                if (ultimocod.Count == 0)
                {
                    cod = "1";
                }
                else
                {
                    cod = (ultimocod.First().numerador + 1).ToString();
                }
                label1.Text = cod;
            }
            
            
            //SI ENTRAMOS DESDE MODIFICAR

            if (Globales.llamadas == "2")
            {

                // muestra los datos del registro seleccionado.
                try
                {
                    //busca en la tabla la fila con el registro suminstrado
                    //y si lo carga los datos en el formulario

                    var amodificar = bd.Usantes.SingleOrDefault(codusuario => codusuario.numerador == Globales.modificar);
                    if (amodificar != null)
                    {
                        label1.Text = Convert.ToString(amodificar.numerador);
                        textBox1.Text = amodificar.nombre;
                        maskedTextBox1.Text = Encriptar.Descodificar(amodificar.password);
                        maskedTextBox2.Text = Encriptar.Descodificar(amodificar.password);
                        comboBox1.Text = amodificar.nivel;
                        textBox2.Text = amodificar.pregunta;
                        textBox3.Text = Encriptar.Descodificar(amodificar.respuesta);
                        if (amodificar.activo == true)
                        {
                            radioButton1.Checked = true;
                            radioButton2.Checked = false;
                        }
                        else
                        {
                            radioButton2.Checked = true;
                            radioButton1.Checked = false;
                        }


                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("No ha sido posible cargar los datos", "Error 202");

                }
            }
        }
    }
}

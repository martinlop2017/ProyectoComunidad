using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseDatos;








namespace ProyectoComunidad.Formularios
{
    public partial class MisDatos : Form
    {
        AdministracionComunidadEntities bd;

        public MisDatos()
        {
            InitializeComponent();
            bd = new AdministracionComunidadEntities();
        }

        private void button1_Click(object sender, EventArgs e)
        {            //extraemos los datos correspondientes de la tabla en el objeto
            

            //var propioModificar = bd.Propios.SingleOrDefault(mio => mio.numerador == 1);
/*

            //modificamos los valores
            propioModificar.minombre = textBoxMiNombre.Text;
            propioModificar.micif = textBoxMiCif.Text;
            propioModificar.midireccion = textBoxMiDiereccion.Text;
            propioModificar.mipoblacion = textBoxMiPoblacion.Text;
            propioModificar.miprovincia = textBoxMiProvincia.Text;
            propioModificar.micp = textBoxMiCP.Text;
            propioModificar.mitelefono1 = textBoxMiTLF1.Text;
            propioModificar.mitelefono2 = textBoxMiTLF2.Text;
            propioModificar.mifax = textBoxMiFax.Text;
            propioModificar.micontacto = textBoxMiPersonaContacto.Text;
            propioModificar.mimail = textBoxMiMail.Text;
            propioModificar.miiban1 = textBoxivan1.Text;
            propioModificar.miiban2 = textBoxivan2.Text;
            propioModificar.miiban3 = textBoxivan3.Text;
            propioModificar.miiban4 = textBoxivan4.Text;
            propioModificar.miiban5 = textBoxivan5.Text;
            propioModificar.miiban6 = textBoxivan6.Text;
            propioModificar.milogo = textBox23.Text;
            propioModificar.miidentificadorbancario = textboxidentificador.Text;
            propioModificar.mibic = textboxbic.Text;

            //guardamos los cambios
            bd.SaveChanges();

            Close();
  */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

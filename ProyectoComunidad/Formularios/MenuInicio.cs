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
    public partial class MenuInicio : Form
    {
        public MenuInicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void BotonSistema_MouseEnter(object sender, EventArgs e)
        {
            BotonSistema.BackgroundImage = ProyectoComunidad.Properties.Resources.SistemaAzul;
            panel2.Visible = true;
            panel3.Visible = false;
        }

        private void BotonSistema_MouseLeave(object sender, EventArgs e)
        {
            BotonSistema.BackgroundImage = ProyectoComunidad.Properties.Resources.Sistema;
        }

        private void BotonPropietarios_MouseEnter(object sender, EventArgs e)
        {
            BotonPropietarios.BackgroundImage = ProyectoComunidad.Properties.Resources.PropietariosAzul;
        }

        private void BotonPropietarios_MouseLeave(object sender, EventArgs e)
        {
            BotonPropietarios.BackgroundImage = ProyectoComunidad.Properties.Resources.Propietarios;
        }

        private void BotonPropios_MouseEnter(object sender, EventArgs e)
        {
            BotonPropios.BackgroundImage = ProyectoComunidad.Properties.Resources.MisDatosAzul;
        }

        private void BotonPropios_MouseLeave(object sender, EventArgs e)
        {
            BotonPropios.BackgroundImage = ProyectoComunidad.Properties.Resources.MisDatos;
        }

        private void botonbackup_MouseEnter(object sender, EventArgs e)
        {
            botonbackup.BackgroundImage = ProyectoComunidad.Properties.Resources.BackupAzul;
        }

        private void botonbackup_MouseLeave(object sender, EventArgs e)
        {
            botonbackup.BackgroundImage = ProyectoComunidad.Properties.Resources.Backup;
        }

        private void botonfincas_MouseEnter(object sender, EventArgs e)
        {
            botonfincas.BackgroundImage = ProyectoComunidad.Properties.Resources.FincasAzul;
        }

        private void botonfincas_MouseLeave(object sender, EventArgs e)
        {
            botonfincas.BackgroundImage = ProyectoComunidad.Properties.Resources.Fincas;
        }

        private void botoncontabilidad_MouseEnter(object sender, EventArgs e)
        {
            botoncontabilidad.BackgroundImage = ProyectoComunidad.Properties.Resources.ContabilidadAzul;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void botoncontabilidad_MouseLeave(object sender, EventArgs e)
        {
            botoncontabilidad.BackgroundImage = ProyectoComunidad.Properties.Resources.Contabilidad;
        }

        private void botonbanco_MouseEnter(object sender, EventArgs e)
        {
            botonbanco.BackgroundImage = ProyectoComunidad.Properties.Resources.Csb19Azul;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void botonbanco_MouseLeave(object sender, EventArgs e)
        {
            botonbanco.BackgroundImage = ProyectoComunidad.Properties.Resources.Csb19;
        }

        private void botoninformes_MouseEnter(object sender, EventArgs e)
        {
            botoninformes.BackgroundImage = ProyectoComunidad.Properties.Resources.InformesAzul;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void botoninformes_MouseLeave(object sender, EventArgs e)
        {
            botoninformes.BackgroundImage = ProyectoComunidad.Properties.Resources.Informes;
        }

        private void botonrecibos_MouseEnter(object sender, EventArgs e)
        {
            botonrecibos.BackgroundImage = ProyectoComunidad.Properties.Resources.RecibosAzul;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void botonrecibos_MouseLeave(object sender, EventArgs e)
        {
            botonrecibos.BackgroundImage = ProyectoComunidad.Properties.Resources.Recibos;
        }

        private void botonavisos_MouseEnter(object sender, EventArgs e)
        {
            botonavisos.BackgroundImage = ProyectoComunidad.Properties.Resources.AvisosAzul;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void botonavisos_MouseLeave(object sender, EventArgs e)
        {
            botonavisos.BackgroundImage = ProyectoComunidad.Properties.Resources.Avisos;
        }

        private void botondocumentos_MouseEnter(object sender, EventArgs e)
        {
            botondocumentos.BackgroundImage = ProyectoComunidad.Properties.Resources.DocumentosAzul;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void botondocumentos_MouseLeave(object sender, EventArgs e)
        {
            botondocumentos.BackgroundImage = ProyectoComunidad.Properties.Resources.Documentos;

        }

        private void botonGComunidades_MouseEnter(object sender, EventArgs e)
        {
            botonGComunidades.BackgroundImage = ProyectoComunidad.Properties.Resources.GestioncomunidadAzul;
            panel3.Visible = true;
            panel2.Visible = false;
        }

        private void botonGComunidades_MouseLeave(object sender, EventArgs e)
        {
            botonGComunidades.BackgroundImage = ProyectoComunidad.Properties.Resources.Gestioncomunidad;
            
        }

        private void BotonSistema_Click(object sender, EventArgs e)
        {
           
        }

        private void botonGComunidades_Click(object sender, EventArgs e)
        {
        
        }

        private void BotonPropietarios_Click(object sender, EventArgs e)
        {
            GestionPropietarios form = new GestionPropietarios();
            form.Show();
        }

        private void BotonPropios_Click(object sender, EventArgs e)
        {
            MisDatos form = new MisDatos();
            form.Show();
        }

        private void botonbackup_Click(object sender, EventArgs e)
        {
            Backup form = new Backup();
            form.Show();
        }

        private void botonfincas_Click(object sender, EventArgs e)
        {
            GestionFincas form = new GestionFincas();
            form.Show();
        }

        private void botondocumentos_Click(object sender, EventArgs e)
        {
            GestionDocumental form = new GestionDocumental();
            form.Show();
        }

        private void botonavisos_Click(object sender, EventArgs e)
        {
            GestionAvisos form = new GestionAvisos();
            form.Show();
        }

        private void botoncontabilidad_Click(object sender, EventArgs e)
        {
            GestionAsientos form = new GestionAsientos();
            form.Show();
        }

        private void botonbanco_Click(object sender, EventArgs e)
        {
            GestionLiquidaciones form = new GestionLiquidaciones();
            form.Show();
        }
    }
}

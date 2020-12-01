using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Pulsaciones
{
    public partial class PrincipalForm : Form
    {
        PersonaService personaService = new PersonaService(ConfigConnection.Connection);
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void AbrirFormulario(object Formulario)
        {
            if (this.PanelPrincipal.Controls.Count > 0)
            {
                this.PanelPrincipal.Controls.RemoveAt(0);
            }

            Form formulario = Formulario as Form;
            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            this.PanelPrincipal.Controls.Add(formulario);
            this.PanelPrincipal.Tag = formulario;
            formulario.Show();
        }

        



        public void Mostrar()
        {
            if (personaService.ConexionPrueba().CondError == false)
            {
                MessageBox.Show(personaService.ConexionPrueba().Abierto);
                MessageBox.Show(personaService.ConexionPrueba().Cerrado);
            }
        }

        private void asd_Click(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void asd_Click_1(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void BtnRegistrarPersona_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new RegistrarForms());
        }

        private void BtnConsultar_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new ConsultarForms());
        }

        private void BtnModificar_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new ModificarForms());
        }

        private void BtnEliminar_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new EliminarForms());
        }
    }
}

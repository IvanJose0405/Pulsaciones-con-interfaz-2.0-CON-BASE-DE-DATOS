using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;

namespace Pulsaciones
{
    public partial class EliminarForms : Form
    {
        Persona persona;
        PersonaService personaService = new PersonaService(ConfigConnection.Connection);
        public EliminarForms()
        {
            InitializeComponent();
            
        }

        private void EliminarForms_Load(object sender, EventArgs e)
        {

        }
        public void BuscarPersona()
        {

            if (personaService.BuscarPersona(TxtIdentificacion.Text) == null)
            {

                MessageBox.Show("No se encuentra la persona.");
            }
            else
            {
                persona = personaService.BuscarPersona(TxtIdentificacion.Text);
                LlenaCampos(persona);
                DesbloquearCampos(false);
                
            }
        }
        public void LlenaCampos(Persona persona)
        {
            TxtNombre.Text = persona.Nombre;
            TxtEdad.Text = persona.Edad + "";
            ComboSexo.SelectedItem = persona.Sexo;


        }
        public void DesbloquearCampos(bool Estado)
        {
            TxtNombre.Enabled = Estado;
            TxtEdad.Enabled = Estado;
            ComboSexo.Enabled = Estado;
            BtnModificar.Enabled = true;

        }
        public void Eliminar() {
            MessageBox.Show(personaService.Eliminar(persona));
            DesbloquearCampos(false);
            Limpiar();
        
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            BuscarPersona();
        }
        public void Limpiar() {
            TxtNombre.Text = "";
            TxtIdentificacion.Text = "";
            TxtEdad.Text = "";
            
        }
    }


}

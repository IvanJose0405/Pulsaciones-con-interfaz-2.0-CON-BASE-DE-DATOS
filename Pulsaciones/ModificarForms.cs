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
using Entity;

namespace Pulsaciones
{
    public partial class ModificarForms : Form
    {
        PersonaService personaService = new PersonaService(ConfigConnection.Connection);
        Persona persona;
        public ModificarForms()
        {
            InitializeComponent();
            
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void BuscarPersona() {

            if (personaService.BuscarPersona(TxtIdentificacion.Text) == null)
            {

                MessageBox.Show("No se encuentra la persona.");
            }
            else {
                persona = personaService.BuscarPersona(TxtIdentificacion.Text);
                LlenaCampos(persona);
                DesbloquearCampos(true);
            }
        }
        public void LlenaCampos(Persona persona) {
            TxtNombre.Text = persona.Nombre;
            TxtEdad.Text = persona.Edad+"";
            ComboSexo.SelectedItem = persona.Sexo;
                
        
        }
        public void DesbloquearCampos(bool Estado) {
            TxtNombre.Enabled = Estado;
            TxtEdad.Enabled = Estado;
            ComboSexo.Enabled = Estado;
            BtnModificar.Enabled = Estado;
        
        }
        public Persona Modificar() {
            persona.Nombre = TxtNombre.Text;
            persona.Edad = Convert.ToInt32(TxtEdad.Text);
            persona.Sexo = ComboSexo.Text;
            persona.CalcularPulsaciones();
            MessageBox.Show($"Su pulsacion es: {persona.Pulsaciones}");
            return persona;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(personaService.Modificar(Modificar()));
            DesbloquearCampos(false);

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            BuscarPersona();
        }

        private void ModificarForms_Load(object sender, EventArgs e)
        {

        }
    }
}

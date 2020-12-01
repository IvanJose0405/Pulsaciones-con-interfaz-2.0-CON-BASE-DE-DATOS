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
    public partial class RegistrarForms : Form
    {
        PersonaService personaService;
        
        public RegistrarForms()
        {
            InitializeComponent();
            personaService = new PersonaService(ConfigConnection.Connection);
            ComboSexo.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RegistrarForms_Load(object sender, EventArgs e)
        {

        }
        public void Guardar() {
            if (personaService.BuscarPersona(TxtIdentificacion.Text) != null)
            {
                MessageBox.Show("La persona ya está registrada.");
            }
            else {
                if (PedirDatos() != null)
                {  
                  MessageBox.Show(personaService.Guardar(PedirDatos()));   
                }
            }

            
        
        }
        public Persona PedirDatos() {
            Persona persona = new Persona();
            try
            {
                if (TxtIdentificacion.Text.Equals("") || TxtNombre.Text.Equals(""))
                {
                    MessageBox.Show("Hay campos vacios.");
                    return null;

                }
                else
                {
                    persona.Edad = Convert.ToInt32(TxtEdad.Text);
                    persona.Identificacion = TxtIdentificacion.Text;
                    persona.Nombre = TxtNombre.Text;
                    persona.Sexo = ComboSexo.SelectedItem.ToString();
                    persona.CalcularPulsaciones();
                    MessageBox.Show($"Su pulsacion es de: {persona.Pulsaciones} ");
                    return persona;
                }
                

            }
            catch(Exception e) {
                MessageBox.Show("Ingrese los datos correctamente.");
                return null;
            }
            
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
    }
}

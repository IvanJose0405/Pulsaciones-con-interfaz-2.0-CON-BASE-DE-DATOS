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
    public partial class ConsultarForms : Form
    {
        PersonaService personaService = new PersonaService(ConfigConnection.Connection);
        public ConsultarForms()
        {
            InitializeComponent();
        }
        public void LlenarTabla() {
            TablaPersonas.DataSource = personaService.Consultar().ToList();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            LlenarTabla();
        }
    }
}

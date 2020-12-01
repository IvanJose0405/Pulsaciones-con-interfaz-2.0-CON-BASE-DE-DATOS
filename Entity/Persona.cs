using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Persona
    {
        public String Identificacion { get; set; }
        public String Nombre { get; set; }
        public int Edad { get; set; }
        public String Sexo{ get; set; }
        public decimal Pulsaciones { get; set; }

        public void CalcularPulsaciones() {

            if (Sexo.Equals("Masculino"))
            {
                Pulsaciones = ((210 - Edad) / 10.0m);
            }
            else if (Sexo.Equals("Femenino")) {
                Pulsaciones = ((220 - Edad) / 10.0m);
            }
        
        }
    
    }

   
}

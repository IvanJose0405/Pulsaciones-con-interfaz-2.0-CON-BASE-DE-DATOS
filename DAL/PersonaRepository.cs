using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class PersonaRepository
    {
        public List<Persona> personas;

        String Ruta="Persona.txt";

        public void GuardarPersona(Persona persona) {
            FileStream file = new FileStream(Ruta,FileMode.Append);
            StreamWriter Escritor = new StreamWriter(file);
            Escritor.WriteLine($"{persona.Identificacion};{persona.Nombre};{persona.Edad};{persona.Sexo};{persona.Pulsaciones}");
            Escritor.Close();
            file.Close();
        }

        public List<Persona> Consultar() {
            personas = new List<Persona>();
            string Linea = string.Empty;
            FileStream source = new FileStream(Ruta,FileMode.OpenOrCreate);
            StreamReader reader = new StreamReader(source);
            while((Linea=reader.ReadLine())!=null) {
                Persona persona = new Persona();
                string[] ArrayPersona = Linea.Split(';');
                persona.Identificacion = ArrayPersona[0];
                persona.Nombre = ArrayPersona[1];
                persona.Edad = Convert.ToInt32(ArrayPersona[2]);
                persona.Sexo = ArrayPersona[3];
                persona.Pulsaciones = Convert.ToDecimal(ArrayPersona[4]);
                personas.Add(persona);
            }
            reader.Close();
            source.Close();
            return personas;
        }
        public Persona BuscarPersona(String Identificacion)
        {
            personas = Consultar();

            return personas.Find(p=>p.Identificacion.Equals(Identificacion));
        }

        public void Modificar(Persona persona) {
            personas = Consultar();
            FileStream file = new FileStream(Ruta, FileMode.Create);
            file.Close();

            foreach (var p in personas) {
                if (p.Identificacion != persona.Identificacion)
                {
                    GuardarPersona(p);
                }
                else {
                    GuardarPersona(persona);
                }
            
            }
        
        }

        public void Eliminar(Persona persona) {
            personas = Consultar();
            FileStream file = new FileStream(Ruta, FileMode.Create);
            file.Close();
            foreach (var p in personas) {
                if (p.Identificacion != persona.Identificacion) {
                    GuardarPersona(p);
                }
            }




        }


    }
}

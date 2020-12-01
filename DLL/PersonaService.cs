using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace BLL
{
    public class PersonaService
    {
        PersonaRepository personaRepository = new PersonaRepository();
        public ConnectionManager Conection;
        public PersonaService(string conection)
        {
            Conection = new ConnectionManager(conection);
        }

        public PruebaResponse ConexionPrueba()
        {
            PruebaResponse pruebaResponse = new PruebaResponse();
            try
            {
                Conection.Open();
                pruebaResponse.Abierto = Conection.Estado();
                Conection.Close();
                pruebaResponse.Cerrado = Conection.Estado();
                pruebaResponse.Error = "No hubo errores";
                pruebaResponse.CondError = false;
            } catch(Exception e)
            {
                pruebaResponse.Abierto = "ERROR";
                pruebaResponse.Cerrado = "ERROR";
                pruebaResponse.Error = e.Message;
                pruebaResponse.CondError = true;
            }
                return pruebaResponse;
        }

        public class PruebaResponse
        {
            public bool CondError { get; set; }
            public string Error { get; set; }
            public string Abierto { get; set; }
            public string Cerrado { get; set; }
        }
        public String Guardar(Persona persona) {
            try
            {
                personaRepository.GuardarPersona(persona);
                return "Guardado correctamente";

            }
            catch (Exception e) {

                return $"{e.Message}" ;
            }
        
        }
        public List<Persona> Consultar() {

            return personaRepository.Consultar();
        }
        public Persona BuscarPersona(String Identificacion) {


            return personaRepository.BuscarPersona(Identificacion);
        }

        public String Modificar(Persona persona) {
            try {
                personaRepository.Modificar(persona);
                return "Persona modificada correctamente.";
            }
            catch(Exception e) {

                return $"{e.Message}";

            
            }
        
        }
        public String Eliminar(Persona persona) {
            try
            {
                personaRepository.Eliminar(persona);
                return "Persona Eliminada correctamente.";
            }
            catch (Exception e)
            {

                return $"{e.Message}";


            }


        }
    }
}

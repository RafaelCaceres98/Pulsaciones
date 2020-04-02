using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ENTITY;

namespace BLL
{
    public class PersonaService
    {
        private PersonaRepository personaRepository;

        public PersonaService()
        {
            personaRepository = new PersonaRepository();
        }
        public void CalcularPulsacion(Persona persona)
        {

            if (persona.sexo.ToUpper().Equals("M"))
            {
                persona.pulsacion = ((210 - persona.edad)) / 10;
            }
            else
            {
                if (persona.sexo.ToUpper().Equals("F"))
                {
                    persona.pulsacion = ((220 - persona.edad)) / 10;
                }
            }
        }

        public void Guardar(Persona persona)
        {

            personaRepository.Guardar(persona);

        }

        public List<Persona> Consultar() {

            return personaRepository.Consultar();
        }

        public string  Eliminar(string id) {

             personaRepository.Eliminar(id);

            return $"La persona con la identificacion{id}, ha sido eliminada correctamente.";
        
        }
        
    }
}













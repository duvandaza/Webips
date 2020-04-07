using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPulsaciones.Models
{
    public class PersonaInputModel
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public int ValorServicio { get; set; }
        public int Salario { get; set; }
    }

    public class PersonaViewModel : PersonaInputModel
    {
        public PersonaViewModel()
        {

        }
        public PersonaViewModel(Persona persona)
        {
            Identificacion = persona.Identificacion;
            Nombre = persona.Nombre;
            ValorServicio = persona.ValorServicio;
            Salario = persona.Salario;
            Copago = persona.Copago;
        }
        public int Copago { get; set; }
    }
}
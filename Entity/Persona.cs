using System;

namespace Entity
{
    public class Persona
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public int ValorServicio { get; set; }
        public int Salario { get; set; }
        public int Copago { get; set; }
        public void CalcularCopago() 
        {
            if(Salario > 2500000){   
               Copago = ((20*Salario)/100)*ValorServicio;
            }else{
               Copago = ((10*Salario)/100)*ValorServicio;             
            }
        }
    }
}

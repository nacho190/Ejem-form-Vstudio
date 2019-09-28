using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
   public class Persona
    {
       public int peso, altura;
       public String dni,nombre, apellidos, fecha;

        public Persona(String nombre, String apellidos, String dni, String fecha, int peso, int altura)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dni = dni;
            this.fecha = fecha;
            this.peso = peso;
            this.altura = altura;
        }
    }
}

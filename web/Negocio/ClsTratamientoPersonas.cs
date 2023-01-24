using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web.Models;
namespace web.Negocio
{
    public class ClsTratamientoPersonas
    {
       
    
        public String MayorDedad(Persona per){

            int edad = per.edad;

            if (edad>=18){

                return $"{per.nombre} es mayor de edad" ;

            }

            return "Es menor de edad";
        }
        public String ObtenerNombre(Persona per){

            return $"Su nombre es {per.nombre} su edad es {per.edad}";
        }

    }
}
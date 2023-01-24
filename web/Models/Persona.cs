using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web.Models
{
    public class Persona
    {
        //Describir los objetos 
        //Las descriciones se realizan con propiedades
        //Propiedad get se utiliza para obtener informacion
        //Propiedad set se utilizar par modificar informacion
        public String? nombre {get;set;}
        public String? apellido {get;set;}
        public int edad {get;set;}
    }
}
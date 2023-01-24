// See https://aka.ms/new-console-template for more information
using web.Negocio;
using web.Models;

Persona persona = new Persona();
ClsTratamientoPersonas NPersona = new ClsTratamientoPersonas();
Console.WriteLine ("Digite su nombre");
String? Nombre = Console.ReadLine();
persona.nombre = Nombre;
Console.WriteLine ("Digite su edad");
String? Stredad = Console.ReadLine();
int edad = Convert.ToInt32(Stredad);
persona.edad = edad;

String NombreYEdad = NPersona.ObtenerNombre(persona);
Console.WriteLine(NombreYEdad);

String MayorDedad = NPersona.MayorDedad(persona);

Console.WriteLine(MayorDedad);

using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using BLL;

namespace Ejercicio2
{
    class Program
    {
        

        static void Main(string[] args)
        {
            PersonaService personaService = new PersonaService();
            List<Persona> personas = new List<Persona>();
            Persona persona = new Persona();
            int opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine(" 1. Registrar ");
                Console.WriteLine(" 2. Consultar ");
                Console.WriteLine(" 3. Buscar ");
                Console.WriteLine(" 4. Eliminar ");
                Console.WriteLine(" 5. Modificar ");
                Console.WriteLine(" 6. Salir ");
                Console.WriteLine(" DIGITE UNA OPCION: ");
                opcion = Int32.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:

                        Console.WriteLine(" DIGITE SU IDENTIFICACION: ");
                        persona.id = Console.ReadLine();
                        Console.WriteLine(" DIGITE SU NOMBRE: ");
                        persona.nombre = Console.ReadLine();
                        Console.WriteLine(" DIGITE SU EDAD: ");
                        persona.edad = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" SEXO: ");
                        Console.WriteLine(" FEMENINO --> F: ");
                        Console.WriteLine(" MASCULINO --> M: ");
                        persona.sexo = (Console.ReadLine());

                        personaService.CalcularPulsacion(persona);
                        personaService.Guardar(persona);

                        Console.WriteLine("IDENTIFICACION: " + persona.id + " NOMBRE: " + persona.nombre + " EDAD: " + persona.edad + " SEXO: " + persona.sexo + " PULSACIONES: " + persona.pulsacion);
                        Console.ReadKey();

                        break;
                    case 2:


                        //personas = personaService.Consultar();
                        personas = personaService.Consultar();
                        foreach (var item in personas)
                        {
                            Console.WriteLine($"IDENTIDAD: {item.id}");
                            Console.WriteLine($"NOMBRE: {item.nombre}");
                            Console.WriteLine($"EDAD: { item.edad}");
                            Console.WriteLine($"SEXO: {item.sexo}");
                            Console.WriteLine($"PULSACIONES: {item.pulsacion}");
                            Console.WriteLine("-----------------------------------");
                        }
                        Console.ReadKey();

                        break;
                    case 3:

                        break;
                    case 4:

                        string id;
                        string respuesta;
                        Console.WriteLine(" DIGITE LA IDENTIFICACION PARA ELIMINAR LOS DATOS ");
                        id = Console.ReadLine();
                        respuesta = personaService.Eliminar(id);
                        Console.WriteLine(respuesta);

                        Console.ReadKey();
                        
                        break;
                    case 5:

                        break;
                    case 6:
                        Environment.Exit(0);
                        break;

                    default:
                        break;
                }
            } while (opcion  != 6);
        }
    }
}

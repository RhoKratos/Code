using System;

namespace Cinco
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int edad = inicio();    
            evaluar(edad);
                    
            
        }


        static int inicio()
        {

            Console.WriteLine("Escribe tu nombre.");

            string nombre = Console.ReadLine();

            Console.WriteLine("Bienvenido "+nombre+", permiteme saber tu edad.");
            
            int edad = Int32.Parse(Console.ReadLine());

            return edad;
        
        }

        static void evaluar(int int1)
        {

            if (int1 <= 18) Console.WriteLine("No puedes conducir aquí.");

            else
            {
                
                Console.WriteLine("¿Tienes licencia?");
            
                string licencia = Console.ReadLine(); 

                int compara = String.Compare(licencia, "si", true);
                
                if (compara == 0) Console.WriteLine("Puedes conducir con nosotros.");
                
                else Console.WriteLine("Lo sentimos, no puede conducir con nosotros.");
            
            }
            
        }

    }

}

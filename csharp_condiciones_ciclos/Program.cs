using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_condiciones_ciclos
{
    class Program
    {
        static void Main(string[] args)
        {
            condicionalIf();
            Console.WriteLine("----------");
            condicionalSwitch();
            Console.WriteLine("----------");
            cicloWhile();
            Console.WriteLine("----------");
            cicloDoWhile();
            Console.WriteLine("----------");
            cicloFor();
            Console.WriteLine("----------");
            Console.ReadKey();
        }
        public static void condicionalIf()
        {
            Console.WriteLine("Condicional If");
            // Condicional if else if else
            int age = 1000;
            // La condición o comparación debe ser
            // establecida en los paréntesis del if o else if
            if (age < 0)
            {
                Console.WriteLine("Antes de cristo");
            }
            else if (age == 0)
            {
                Console.WriteLine("Año 0");
            }
            else
            {
                Console.WriteLine("Despues de cristo");
            }
        }

        public static void condicionalSwitch()
        {
            Console.WriteLine("Condicional Switch");
            // Condicional Switch
            int numero = 2;
            // La variable a evaluar en la condicional se establece
            // en el paréntesis del switch
            switch (numero)
            {
                // cada caso debe ser establecido con un valor
                // para comparar si el valor de la variable
                // evaluada es igual al valor que se establece
                // en cada caso
                case 1:
                    // Si es igual las líneas de código dentro
                    // del case serán ejecutadas

                    Console.WriteLine("Número uno");
                    // cada case debe terminar con un break
                    break;
                case 2:
                    Console.WriteLine("Número dos");
                    break;
                case 3:
                    Console.WriteLine("Número tres");
                    break;
                default:
                    // para los valores que no se consideren
                    // se puede utilizar default
                    Console.WriteLine("No es ninguno de los números admitivos");
                    break;
            }
        }

        public static void cicloWhile()
        {
            Console.WriteLine("Ciclo While");
            int numero = 1;
            // ciclo while
            // el ciclo while tiene un funcionamiento
            // muy sencillo, debemos establecer una 
            // condición, si esta se cumple las líneas
            // de código establecidas dentro del ciclo
            // se ejecutaran repetidas veces hasta que
            // la condición no se cumpla
            while (numero <1)
            {
                Console.WriteLine("Valor de la variable : "+numero++);
            }
            Console.WriteLine("La condición ya no se cumple");
        }

        public static void cicloDoWhile()
        {
            Console.WriteLine("Ciclo Do While");
            // el ciclo do while
            // su funcionamiento es muy similar al ciclo
            // while, sin embargo este ciclo permite
            // ejecutar las líneas de código establecido
            // entre las llaves do al menos una vez,
            // si la condición del ciclo sigue cumpliéndose
            // estas líneas de código serán ejecutas repetidas
            // veces hasta que la condición no se cumpla
            int numero = 1;
            do
            {
                Console.WriteLine("El valor de la variable número es : "+numero);
                numero++;
            } while (numero < 1);
            Console.WriteLine("La condición ya no se cumple");
        }

        public static void cicloFor()
        {
            Console.WriteLine("Ciclo For");            
            // El ciclo for es un ciclo repetitivo
            // en donde se debe definir una variable
            // con un valor inicial, luego se debe
            // establecer la condición de finalización
            // para el ciclo y por ultimo establecemos
            // el aumento de la variable al finalizar
            // cada repetición del ciclo
            for (int numero=0;numero<10;numero++)
            {
                Console.WriteLine("Valor del número : "+numero);
            }
        }
    }
}

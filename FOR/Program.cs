// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        // VARIABLE PARA ACUMULAR LA SUMA 
        int sumaPares = 0;

        Console.WriteLine("  Suma de Números Pares del 1 al 100  ");

        // UTILIZAMOS EL FOR
        for (int i = 1; i <= 100; i++)
        {
            // VERIFICAR SI ES PAR
            
            if (i % 2 == 0)
            {
                // SUMA SU VALOR A LA VARIABLE
                sumaPares = sumaPares + i; // O también: sumaPares += i;
            }
        }

        // SUMA TOTAL
       
        Console.WriteLine($"La suma total de los números pares entre 1 y 100 es: {sumaPares}");
 
    }
}

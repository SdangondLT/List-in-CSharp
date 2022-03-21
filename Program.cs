using System;
using System.Collections.Generic;
using System.Linq;

namespace newList
{
    class Program
    {
        static List<string> listSteps = new List<string>()
        {
            "a. Paso 1",
            "c. Paso 1",
            "b. Paso 2",
            "b. Paso 2",
            "b. Paso 2",
            "b. Paso 2",
            "c. Paso 3",
            "d. Paso 3",
            "d. Paso 2",
            "a. Paso 2",
            "d. Paso 1",
            "b. Paso 3",
            "a. Paso 3",
            "b. Paso 1",
            "c. Paso 2",
        };
        static void Main(string[] args)
        {
            OrderList();
        }


        static void OrderList()
        {
            List<string> stepsA = listSteps.Where(x => x.Contains("a.")).ToList();
            List<string> stepsB = listSteps.Where(x => x.Contains("b")).ToList();
            List<string> stepsC = listSteps.Where(x => x.Contains("c")).ToList();
            List<string> stepsD = listSteps.Where(x => x.Contains("d")).ToList();

            Console.WriteLine($"Esta es la lista de letras A: ");
            for (int i = 0; i < stepsA.Count(); i++)
                Console.WriteLine(stepsA[i]);
            Console.ReadKey();

            Console.WriteLine($"Esta es la lista de letras B: ");
            for (int i = 0; i < stepsB.Count(); i++)
                Console.WriteLine(stepsB[i]);
            Console.ReadKey();

            Console.WriteLine($"Esta es la lista de letras C: ");
            for (int i = 0; i < stepsC.Count(); i++)
                Console.WriteLine(stepsC[i]);
            Console.ReadKey();

            Console.WriteLine($"Esta es la lista de letras D: ");
            for (int i = 0; i < stepsD.Count(); i++)
                Console.WriteLine(stepsD[i]);
            Console.ReadKey();

            Console.WriteLine($"Numero de letras A: {stepsA.Count()}");
            Console.WriteLine($"Numero de letras B: {stepsB.Count()}");
            Console.WriteLine($"Numero de letras C: {stepsC.Count()}");
            Console.WriteLine($"Numero de letras D: {stepsD.Count()}");
        }
    }
}

using System;
using System.Linq;


namespace ExerciciLinq_FaseII
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numFaseI = {2, 6, 8, 4, 5, 5, 9, 2, 1, 8, 7, 5, 9, 6, 4};
           
            double average = numFaseI.Average(); //Calcula la Media 
            int max = numFaseI.Max(); //Calcula el Maximo
            int min = numFaseI.Min(); // Calcula el Minimo 

           
            Console.WriteLine($"Nota media : {average}  Nota maxima: {max}  Nota Minima: {min}");
           

        }
    }
}

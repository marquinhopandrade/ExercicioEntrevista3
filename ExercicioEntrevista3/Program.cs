using System;

namespace ExercicioEntrevista3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a string a ser invertida: ");
            string input = Console.ReadLine();
            char[] charArray = input.ToCharArray();
            int indexInicio = 0;
            int indexFim = charArray.Length - 1;
            while (indexInicio < indexFim)
            {
                char sup = charArray[indexInicio];
                charArray[indexInicio] = charArray[indexFim];
                charArray[indexFim] = sup;

                indexInicio++;
                indexFim--;
            }
            string stringInvertida = new string(charArray);
            Console.WriteLine(stringInvertida);
        }
    }
}

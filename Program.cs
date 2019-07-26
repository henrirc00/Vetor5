using System;

namespace Vetor5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = {12,2,5,89,36,58,21};
            int j = 89;
            int k;
            for(k = 0; k < 6; k++)

            {

            if (numeros[k] ==j)

            {
                Console.WriteLine(j);
            }
        
            }

            int numeros = {12,25,89,36,47,98,25};
            int k = 7;
            int i,p;
            i = 0;

            for (p = 0; p < k;++)
            {
                if(numeros[p] != 36)
                {
                    numeros[i++] = numeros[p];
                }
            }
            n = n -1;
            for(int x = 0; x < numeros.Length-1; x++){
            Console.WriteLine(numeros[x]);
            }
        }
    }
}

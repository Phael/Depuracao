using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Depuracao
{
    class Program
    {
        static int MUDARNUMERO(int N)
        {
            N = N + 1;
            return N;
        }

        static float DIVIDIR(int N, int D)
        {
            return N / D;
        }
        static void Main(string[] args)
        {
            int NUMERO = 0;

            NUMERO = int.Parse(Console.ReadLine());
            Console.WriteLine("O Numero Escolhido eh : {0}", NUMERO);
            NUMERO = MUDARNUMERO(NUMERO);
            Console.WriteLine("O Numero Modificado : {0} ", NUMERO);
            
            int DENOMINADOR = 0;

            DENOMINADOR = int.Parse(Console.ReadLine());
            if (DENOMINADOR == 0)
                Console.WriteLine("Nao eh Possivel dividir por zero");
            else
                Console.WriteLine("O quociente entre {0} e {1} eh : {2}", NUMERO, DENOMINADOR, DIVIDIR(NUMERO, DENOMINADOR));

            Console.Read();
            
        }
    }
}

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
        static void Main(string[] args)
        {
            int NUMERO = 0;

            NUMERO = int.Parse(Console.ReadLine());
            Console.WriteLine("O Numero Escolhido eh : {0}", NUMERO);
            NUMERO = MUDARNUMERO(NUMERO);
            Console.WriteLine("O Numero Modificado : {0} ", NUMERO);
            Console.Read();
        }
    }
}

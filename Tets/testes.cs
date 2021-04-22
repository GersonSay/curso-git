using System;
using System.Collections.Generic;
using System.Text;

namespace Tets
{
    class testes
    {
        public int Soma;

        public static int Teste(int x, int y)
        {
             int sum = x + y;
            return sum;
        }

        public static void Triple(ref int x)
        {
            x *= 3; 
        }

        public int Somatoria(int soma)
        {
            Soma += soma;
            return Soma;
        }
    }
}

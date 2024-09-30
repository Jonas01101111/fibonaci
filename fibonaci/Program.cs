using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonaci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 0, 1, 1};
            Console.WriteLine(numeros[0]+", ");
            while (true) {
                
                numeros[2] = numeros[0]+numeros[1];
                
                numeros[0]=numeros[1];
                numeros[1]=numeros[2];
                Console.Write(numeros[0]+", ");
                
            }

        }
    }
}

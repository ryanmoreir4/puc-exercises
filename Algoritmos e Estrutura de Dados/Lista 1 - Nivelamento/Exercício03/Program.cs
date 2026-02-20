using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] vetor = new int[10];

            for(int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.Next(1,100);

            }

            foreach(int n in vetor)
            {
                if ()
                {

                }
            }
        }
    }
}

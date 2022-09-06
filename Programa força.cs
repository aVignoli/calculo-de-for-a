using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegradorMatemática
{
    class Program
    {
        static void Main(string[] args)
        {
            double força;
            double massa;
            double aceleracao;

            Console.WriteLine("INSIRA A MASSA");
            massa = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("INSIRA A ACELERACAO");
            aceleracao = Convert.ToDouble(Console.ReadLine());


            força = (massa * aceleracao);
            Console.WriteLine(força);

            Console.ReadKey();
        }
    }
}

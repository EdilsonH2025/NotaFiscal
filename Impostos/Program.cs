using System;
using System.Numerics;

namespace Impostos
{
    class Impostos
    {
        /* public double Pis;
         public double Cofins;
         public double Csll;
         public double Irrf;*/

        public static void Main(string[] args)
        {
            Calculo calc = new Calculo();

            Console.WriteLine("Informe o valor do material:");
            double material = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Digite o valor da mão-de-obra:");
            double maodeobra = double.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Digite o valor do BDI:");
            double bdi = double.Parse(Console.ReadLine());
            Console.Clear();

            double total = Calculo.Total(material, maodeobra, bdi);

            Console.WriteLine($"O total informado foi {total:C}");

            var Impostos = Calculo.Impostos(total, maodeobra, bdi);

            Console.WriteLine($"O valor do PIS é {Impostos.Pis:C}");
            Console.WriteLine($"O valor do COFINS é {Impostos.Cofins:C}");
            Console.WriteLine($"O valor do IRRF é {Impostos.Irrf:C}");
            Console.WriteLine($"O valor do CSLL é {Impostos.Csll:C}");
            Console.WriteLine($"O valor do INSS é {Impostos.Inss:C}");
            Console.WriteLine($"O total de impostos e {Impostos.Pis + Impostos.Cofins + Impostos.Irrf + Impostos.Csll:C}");
            Console.WriteLine($"O Valor liquido será {total - (Impostos.Pis + Impostos.Cofins + Impostos.Irrf + Impostos.Csll + Impostos.Inss):C}");
            Console.ReadKey();
        }
    }
}
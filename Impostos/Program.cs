using System;
using System.Numerics;
using System.IO;

namespace Impostos
{
    class Impostos
    {
       
        public static void Main(string[] args)
        {
            
            string caminho = "dados.txt";
            string cabecalho = "Data;Total;PIS;COFINS;IRRF; CSLL;INSS;Total_Impostos;Valor_Líquido;\n";


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
            Console.WriteLine($"O total de impostos é {Impostos.Pis + Impostos.Cofins + Impostos.Irrf + Impostos.Csll + Impostos.Inss:C}");
            Console.WriteLine($"O Valor liquido será {total - (Impostos.Pis + Impostos.Cofins + Impostos.Irrf + Impostos.Csll + Impostos.Inss):C}\n\n");

            string conteudo =
     $"{DateTime.Now};" +
     $"{total:C};" +
     $"{Impostos.Pis:C};" +
     $"{Impostos.Cofins:C};" +
     $"{Impostos.Irrf:C};" +
     $"{Impostos.Csll:C};" +
     $"" +
     $"" +
     $"{Impostos.Inss:C};" +
     $"{Impostos.Pis + Impostos.Cofins + Impostos.Irrf + Impostos.Csll+ Impostos.Inss:C};" +
     $"{total - (Impostos.Pis + Impostos.Cofins + Impostos.Irrf + Impostos.Csll + Impostos.Inss):C}\n"; //+
     //$"----------------------------------------\n";
            
            if (!File.Exists(caminho))
            {
                File.WriteAllText(caminho, cabecalho);
            }
            File.AppendAllText(caminho, conteudo);
            string historico = File.ReadAllText(caminho);

            Console.WriteLine("Digite 1 para sair");
            Console.WriteLine("Digite 2 para ver o historico");
            string decisao = Console.ReadLine();

            if (decisao != "1")
            {
                Console.Clear();
                Console.WriteLine(historico);
            }
            else
            {
                Environment.Exit(0);
            }
            
            
            
            Console.ReadKey();

        }
    }
}
namespace Impostos
{
    public class ValoresImpostos
    {
        public double Pis { get; set; }
        public double Cofins { get; set; }
        public double Csll { get; set; }
        public double Irrf { get; set; }
        public double Inss { get; set; }
    }

    public class Calculo
    {
        public double Material { get; set; }
        public double MaoDeObra { get; set; }
        public double Bdi { get; set; }

        public static double Total(double material, double maodeobra, double bdi)
        {
            return material + maodeobra + bdi;
        }

        public static ValoresImpostos Impostos(double total, double maodeobra, double bdi)
        {
            return new ValoresImpostos
            {
                Pis = total * 0.0065,
                Cofins = total * 0.03,
                Csll = total * 0.01,
                Irrf = total * 0.012,
                Inss = (maodeobra + bdi) * 0.11
            };
        }
    }
}
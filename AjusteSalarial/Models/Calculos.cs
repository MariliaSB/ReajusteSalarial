namespace AjusteSalarial.Models
{
    internal class Calculos
    {
        public Double Reajuste()
        {
            Double salario;

            Console.WriteLine("Digite seu salário atual");
            salario = Convert.ToDouble(Console.ReadLine());

            var novoSalario = salario + (salario * 0.10);
            return novoSalario;

        }

        public double Reajuste1()
        {
            Double salario1;
            Double valorAumento1;
            Double porcentagemReajusteDigitada;

            Console.WriteLine("Digite seu salário atual");
            salario1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a porcentagem de reajuste desejado");
            porcentagemReajusteDigitada = Convert.ToDouble(Console.ReadLine());
            porcentagemReajusteDigitada = porcentagemReajusteDigitada / 100;

            valorAumento1 = salario1 * porcentagemReajusteDigitada;

            var novosalario1 = salario1+ valorAumento1;
            return novosalario1;

        }
    }
}

namespace ReajusteSalarial.Models

{
    public class Calculos
    {
        static public double Reajuste(Double salario)
        {
            Double valorAumento1, porcentagemReajusteDigitada, novoSalario;

            if (salario <= 7000)
            {

                Console.WriteLine("Digite a porcentagem de reajuste desejado");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Obs: Digite apenas números: ");
                Console.ForegroundColor = ConsoleColor.White;
                porcentagemReajusteDigitada = Convert.ToDouble(Console.ReadLine());
                porcentagemReajusteDigitada = porcentagemReajusteDigitada / 100;

                valorAumento1 = salario * porcentagemReajusteDigitada;

                novoSalario = salario + valorAumento1;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"O salário reajustado é de: {novoSalario.ToString("C")}");
                Console.ForegroundColor = ConsoleColor.White;
                return novoSalario;

            } else
            {
                novoSalario = salario + (salario * 0.10);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"O salário reajustado é de: {novoSalario.ToString("C")}");
                Console.ForegroundColor = ConsoleColor.White;
                return novoSalario;
            }

        }
    }
}

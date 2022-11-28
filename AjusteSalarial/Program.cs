using AjusteSalarial.Models;

Calculos contas = new Calculos();
var reajuste = contas.Reajuste();

Console.WriteLine($"\nO salário reajustado é: {reajuste.ToString("C")}\n");

Double reajuste1 = contas.Reajuste1();
Console.WriteLine($"\nO salário reajustado é: {reajuste1.ToString("C")}");

Console.Read();
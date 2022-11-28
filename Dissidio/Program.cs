using ReajusteSalarial.Models;


internal class Program
{
    static void Main(string[] args)
    {
        List<Employees> employees = new List<Employees>();
        OldEmployees oldEmployees = new OldEmployees();
        NewEmployees newEmployees = new NewEmployees();

        while (true)
        {
            string option;
            string op;

            Console.WriteLine("===============Reajuste Salárial===============");
            Console.WriteLine("Digite uma opção");
            Console.WriteLine("1 - Cadastrar Funcionário");
            Console.WriteLine("2 - Consultar Funcionário");
            Console.WriteLine("3 - Sair");

            option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Employees NovoFuncionario = new Employees();

                    Console.Write("Digite o nome do funcionário: ");
                    NovoFuncionario.nameEmployees = Console.ReadLine();
                    Console.Write("Digite o cargo do funcionário: ");
                    NovoFuncionario.positionEmployees = Console.ReadLine();
                    Console.Write("Digite o salário do funcionário: ");
                    NovoFuncionario.salaryEmployees = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Digite o ano de contratação do funcionário: ");
                    NovoFuncionario.HiringYear = Convert.ToInt32(Console.ReadLine());

                    if (NovoFuncionario.HiringYear > 2000 && NovoFuncionario.HiringYear < 2022)
                    {

                        employees.Add(NovoFuncionario);

                        NovoFuncionario.salaryEmployees = Calculos.Reajuste(NovoFuncionario.salaryEmployees);

                        oldEmployees.lista.Add(new OldEmployees()
                        {
                            nameEmployees = NovoFuncionario.nameEmployees,
                            positionEmployees = NovoFuncionario.positionEmployees,
                            salaryEmployees = NovoFuncionario.salaryEmployees,
                            HiringYear = NovoFuncionario.HiringYear

                        });

                        oldEmployees.salaryEmployees = NovoFuncionario.salaryEmployees;

                        Console.WriteLine("\n Funcionário cadastrado com sucesso!! \n");
                    }
                    else if (NovoFuncionario.HiringYear >= 2022)
                    {
                        employees.Add(NovoFuncionario);

                        newEmployees.lista.Add(new NewEmployees()
                        {
                            nameEmployees = NovoFuncionario.nameEmployees,
                            positionEmployees = NovoFuncionario.positionEmployees,
                            salaryEmployees = NovoFuncionario.salaryEmployees,
                            HiringYear = NovoFuncionario.HiringYear

                        });

                        newEmployees.salaryEmployees = NovoFuncionario.salaryEmployees;

                        Console.WriteLine("\n Funcionário cadastrado com sucesso!! \n");
                    }
                    else 
                    {
                        Console.WriteLine("Ano Inválido \n");
                    }

                    break;

                case "2":

                    Console.WriteLine("1 - Todos os funcionários");
                    Console.WriteLine("2 - Funcionários antigos");
                    Console.WriteLine("3 - Novos funcionários");

                    op = Console.ReadLine();

                    switch (op)
                    {
                        case "1":
                            foreach (var item in employees)
                            {
                                Console.WriteLine("Nome: " + item.nameEmployees.ToUpper());
                                Console.WriteLine("Cargo: " + item.positionEmployees.ToUpper());
                                Console.WriteLine("Ano de Contratação: " + item.HiringYear);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Salário: " + item.salaryEmployees.ToString("C"));
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("----------------------------");
                            }
                            break;
                        case "2":

                            foreach (var item in oldEmployees.lista)
                            {
                                Console.WriteLine("Nome: " + item.nameEmployees.ToUpper());
                                Console.WriteLine("Cargo: " + item.positionEmployees.ToUpper());
                                Console.WriteLine("Ano de Contratação: " + item.HiringYear);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Salário: " + item.salaryEmployees.ToString("C"));
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("----------------------------");
                            }
                            break;
                        case "3":

                            foreach (var item in newEmployees.lista)
                            {
                                Console.WriteLine("Nome: " + item.nameEmployees.ToUpper());
                                Console.WriteLine("Cargo: " + item.positionEmployees.ToUpper());
                                Console.WriteLine("Ano de Contratação: " + item.HiringYear);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Salário: " + item.salaryEmployees.ToString("C"));
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("----------------------------");
                            }
                            break;
                    }

                    break;

                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

        }
    }

}
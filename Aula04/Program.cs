namespace Aula04;

public class Program
{
    public static void Main(string[] args)
    {
        // input e output de dados no console
        Console.WriteLine("------ Aula 04 ------");
        Console.WriteLine("------ Cadastro de cliente ------");

        Console.WriteLine("entrada de dados no console");

        Console.Write("Digite seu nome: ");
        string name = Console.ReadLine() ?? "<nome não informado>";

        Console.Write("Digite sua idade: ");
        int age = Convert.ToInt32(Console.ReadLine() ?? "0");

        Console.Write("Digite sua altura: ");
        double height = Convert.ToDouble(Console.ReadLine() ?? "0");

        Console.Write("Digite seu sexo (M/F): ");
        string gender = Console.ReadLine() ?? "<sexo não informado>";

        Console.WriteLine("Digite seu email: ");
        string email = Console.ReadLine() ?? "<email não informado>";


        Console.WriteLine("--- saida de dados no console ---");

        Console.WriteLine("Olá, " + name + "!");

        Console.WriteLine("Relatorio do cliente cadastrado: " + name + ", " + age + " anos, " + height + "m, " + gender + ", " + email);

    }
}
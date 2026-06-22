namespace Aula04;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("------ Aula 04 ------");
        Console.WriteLine("------ Cadastro de cliente ------");
        Console.WriteLine("Entrada de dados no console");

        Console.Write("Digite seu nome: ");
        string? nameInput = Console.ReadLine();

        string name = string.IsNullOrWhiteSpace(nameInput)
            ? "<nome não informado>"
            : nameInput.Trim();

        Console.Write("Digite sua idade: ");

        int age;

        while (!int.TryParse(Console.ReadLine(), out age))
        {
            Console.WriteLine("Idade inválida. Digite um número inteiro.");
            Console.Write("Digite sua idade novamente: ");
        }

        Console.Write("Digite sua altura: ");

        double height;

        while (!double.TryParse(Console.ReadLine(), out height))
        {
            Console.WriteLine("Altura inválida. Digite um número válido.");
            Console.Write("Digite sua altura novamente: ");
        }

        Console.Write("Digite seu sexo (M/F): ");
        string? genderInput = Console.ReadLine();

        string gender = string.IsNullOrWhiteSpace(genderInput)
            ? "<sexo não informado>"
            : genderInput.Trim();

        Console.Write("Digite seu email: ");
        string? emailInput = Console.ReadLine();

        string email = string.IsNullOrWhiteSpace(emailInput)
            ? "<email não informado>"
            : emailInput.Trim();

        Console.WriteLine();
        Console.WriteLine("--- Saída de dados no console ---");

        Console.WriteLine($"Olá, {name}!");

        Console.WriteLine(
            $"Relatório do cliente cadastrado: " +
            $"{name}, {age} anos, {height}m, {gender}, {email}"
        );
    }
}
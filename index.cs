using System;

class Program
{
    static void Main(string[] args)
    {
        string emailCadastro, nomeUsuario, senha;
        
        // Utilize Console.ReadLine() para receber informações do usuário

        emailCadastro = Console.ReadLine();
        nomeUsuario = Console.ReadLine();
        senha = Console.ReadLine();

        // Constrói e imprime a mensagem formatada
        string str = nomeUsuario + ", verifique o email: " + emailCadastro + " para ativar.";
        Console.WriteLine(str);
    }
}

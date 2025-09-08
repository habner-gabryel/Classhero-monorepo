class Program
{
    static void Main()
    {
        Console.WriteLine("Insira uma senha: ");
        string senha = Console.ReadLine() ?? "";

        PoliticaSenha politica = new PoliticaSenha(senha);

        if (politica.senha != null)
        {
            Console.WriteLine("Senha inserida com Sucesso!");
        }
        else
        {
            Console.WriteLine("Ocorreu algum erro na criação da senha");
        }
    }
}
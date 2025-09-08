class Program
{
    static void Main()
    {
        double media = 0D;

        for (int i = 1; i <= 4; i++)
        {
            Console.WriteLine("Informe a " + i + "ª nota: ");
            double nota = double.Parse(Console.ReadLine());

            media += nota;
        }

        media /= 4;

        if (media >= 6)
        {
            Console.WriteLine("Aluno aprovado!");
        }
        else
        {
            Console.WriteLine("Aluno Reprovado.");
        }
        Console.WriteLine("Média: " + media);
    }
}
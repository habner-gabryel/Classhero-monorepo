class Program {
    static void Main()
    {
        Console.WriteLine("Digite um número de 1 à 7: ");
        string input = Console.ReadLine();
        int numero = int.Parse(input);
        string diaSemana = "";

        switch (numero)
        {
            case 1:
                diaSemana = "Domingo";
                break;
            case 2:
                diaSemana = "Segunda-Feira";
                break;
            case 3:
                diaSemana = "Terça-Feira";
                break;
            case 4:
                diaSemana = "Quarta-Feira";
                break;
            case 5:
                diaSemana = "Quinta-Feira";
                break;
            case 6:
                diaSemana = "Sexta-Feira";
                break;
            case 7:
                diaSemana = "Sábado";
                break;
            default:
                diaSemana = "Dia não encontrado";
                break;
        }

        Console.WriteLine("Dia da semana selecionado: " + diaSemana);

    }
}

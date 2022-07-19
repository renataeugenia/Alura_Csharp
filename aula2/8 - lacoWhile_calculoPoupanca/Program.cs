using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine(" Projeto 8 - LaçoDeRepetiçãoWhile - calculo poupança");

        double investimento = 1000;
        double taxa = 0.005;

        int mes = 1;

        while (mes <= 12)
        {
            investimento = investimento + (investimento * taxa);
            Console.WriteLine(" No mês " + mes + " voce tem R$ " + investimento);
            mes += 1;
        }

        Console.WriteLine(" tecle enter 2x para fechar janela...");
        Console.ReadLine();


    }
}

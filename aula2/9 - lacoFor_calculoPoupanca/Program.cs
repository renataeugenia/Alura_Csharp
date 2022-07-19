using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine(" Projeto 9 - LaçoDeRepetiçãoFor - calculo poupança");

        double investimento = 1000;
        double taxa = 0.005;

        for(int mes = 1; mes <= 12; mes++)
        {
            investimento = investimento + (investimento * taxa);
            Console.WriteLine(" No mês  " + mes + " voce tem R$  " + investimento);
        }
              

        Console.WriteLine(" tecle enter 2x para fechar janela...");
        Console.ReadLine();


    }
}

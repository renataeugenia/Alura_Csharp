using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine(" Projeto 10  - LaçoForEncadeado - investimentoLongoPrazo");
       
        
        double investimento = 1000;
        double taxa = 1.005;

        for (int anos = 1; anos <= 5; anos++)
        {
            for (int mes = 1; mes <= 12; mes++)
            {
                investimento *= taxa;
                
            }
            taxa += 0.001;


        }
        Console.WriteLine(" Depois de 5 anos voce terá R$  " + investimento);



        Console.WriteLine(" tecle enter 2x para fechar janela...");
        Console.ReadLine();


    }
}

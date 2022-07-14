using System;

class Programa
{

    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 7 - condicionais com booleanos");

        int idade = 16;
        int idadeAcompanhante = 19;

        bool acompanhante = idadeAcompanhante >= 18;

        if (idade >= 18 || acompanhante)
        {
            Console.WriteLine("Entrada liberada!");
        }
        else
        {
           
            Console.WriteLine("Entrada Proibida!!! Voce é menor de idade e esta sem um acompanhante maior de idade!");
           
        }


        Console.WriteLine("tecle enter 2x para sair...");
        Console.ReadLine();

    }
}

using System;

class Programa
{

    static void Main (string[] args)
    {
        Console.WriteLine("Projeto 6 - condicionais IF / ELSE");

        int idade = 16;
        int idadeAcompanhante = 19;

        if(idade >= 18)
        {
            Console.WriteLine("Entrada liberada!");
        }
        else
        {
            if(idadeAcompanhante >=18)
            {
                Console.WriteLine("Entrada liberada com acompanhante maior de idade");
            }
            else
            {
                Console.WriteLine("Entrada Proibida!!! Voce é menor de idade e esta sem um acompanhante maior de idade!");
            }
            
        }


        Console.WriteLine("tecle enter 2x para sair...");
        Console.ReadLine();

    }
}

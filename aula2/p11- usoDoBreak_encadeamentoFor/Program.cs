using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine(" usando o Break no encadeamento de Laço For");

        for(int linhas = 0; linhas < 10; linhas++)
        {
            Console.WriteLine();
            for(int colunas = 0; colunas < 10; colunas++)
            {
                Console.Write("*");
                if (colunas >= linhas)
                    break;
            }
        }
        // abaixo outra maneira de fazer, sem o uso do if/break


        for (int linhas = 0; linhas < 10; linhas++)
        {
            Console.WriteLine();
            for (int colunas = 0; colunas <= linhas; colunas++)
            {
                Console.Write("*");
                
            }
        }
        Console.WriteLine();
        Console.WriteLine("tecle enter 2x para fechar a janela...");
        Console.ReadLine();

    }
}

using System;

class Programa
{

    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 5 - strings e caracteres");
        char letra = 'a'; // armazena "a" dentro da variavel chamada letra
        Console.WriteLine(letra);

        letra = (char)65; // tb é representada por numeros (decimal) ver ASCII TABLE, aqui utilizado com conversão casting
        Console.WriteLine(letra);

        letra = (char)(85 + 1);
        Console.WriteLine(letra);

        
        string primeiraFrase = "Curso de Tecnologia - Alura ";
        Console.WriteLine(primeiraFrase);
        Console.WriteLine(primeiraFrase + 2022);

        string vazia = ""; // é possivel criar uma string vazia, em char Não somente se tiver um espaço
        Console.WriteLine(vazia);

        string cursos = @"Cursos disponiveis: 
- C# 
- Go 
- Java 
- Python"; // o @ na frente da string permite a quebra de linhas

        Console.WriteLine(cursos);


        Console.WriteLine("tecle enter 2x para fechar...");
        Console.ReadLine();

    }
}


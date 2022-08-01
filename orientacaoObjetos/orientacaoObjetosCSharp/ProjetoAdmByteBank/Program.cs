using ProjetoAdmByteBank.Funcionarios;
using ProjetoAdmByteBank.Utilitarios;

GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

Console.WriteLine("Seja bem vindo!, ao ByteBank Administração.");

Funcionario joao = new Funcionario();
joao.Nome = "João das Neves";
joao.Cpf = "123456789";
joao.Salario = 2500.50;
Console.WriteLine();

Console.WriteLine($"Nome : {joao.Nome} ");
Console.WriteLine($"Cpf : {joao.Cpf}");
Console.WriteLine($"Salário R$ {joao.Salario}");
Console.WriteLine($"Bonificação: {joao.getBonificacao()}");

Console.WriteLine();

Diretor ana = new Diretor();
ana.Nome = "Ana Beatriz Linhares";
ana.Cpf = "456321786";
ana.Salario = 12750.50;
Console.WriteLine($"Nome : {ana.Nome} ");
Console.WriteLine($"Cpf : {ana.Cpf}");
Console.WriteLine($"Salário R$ {ana.Salario}");
Console.WriteLine($"Bonificação: {ana.getBonificacao()}");

Console.WriteLine();
gerenciador.Registrar(joao);
gerenciador.Registrar(ana);

Console.WriteLine($"Total de Bonificação : {gerenciador.getBonificacao()}");

Console.WriteLine();
Console.WriteLine("Tecle Enter 2x para sair");
Console.ReadLine();

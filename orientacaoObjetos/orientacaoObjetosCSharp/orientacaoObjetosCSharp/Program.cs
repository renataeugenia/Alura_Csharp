using bytebank;
using ProjetoByteBank;

Console.WriteLine("INICIANDO O PROJETO BYTEBANK");

Console.WriteLine();

//ContaCorrente conta1 = new ContaCorrente();

//conta1.titular = "Renata Eugênia";
//conta1.conta = "25879 - X";
//conta1.numero_agencia = 27;
//conta1.nome_agencia = "Paulista";
//conta1.saldo = 100.69;
//conta1.ativa = false ;

//ContaCorrente conta2 = new ContaCorrente();

//conta2.titular = "Ana Paula Eugênia";
//conta2.conta = "36957 - F";
//conta2.numero_agencia = 40;
//conta2.nome_agencia = "Higienópolis";
//conta2.saldo = 200.87;
//conta2.ativa = true;




//Console.WriteLine("Titular: " + conta1.titular);
//Console.WriteLine("Conta: " + conta1.conta);
//Console.WriteLine("Numero_Agencia: " + conta1.numero_agencia);
//Console.WriteLine("Nome_Agencia: " + conta1.nome_agencia);
//Console.WriteLine($"Saldo: R$ {String.Format("{0:0.00}", conta1.saldo)}");
//Console.WriteLine($"conta ativa: {conta1.ativa}");

//Console.WriteLine();

//Console.WriteLine("Titular: " + conta2.titular);
//Console.WriteLine("Conta: " + conta2.conta);
//Console.WriteLine("Numero_Agencia: " + conta2.numero_agencia);
//Console.WriteLine("Nome_Agencia: " + conta2.nome_agencia);
//Console.WriteLine($"Saldo: R$ {String.Format("{0:0.00}", conta2.saldo)}");
//Console.WriteLine($"conta ativa: {conta2.ativa}");

//Console.WriteLine();



//Console.WriteLine($"Saldo da Ana Paula pré-saque : R$ {String.Format("{0:0.00}", conta2.saldo)}");
//conta2.Sacar(50);
//Console.WriteLine($"Saldo da Ana Paula pós-saque : R$ {String.Format("{0:0.00}", conta2.saldo)}");
//conta2.Depositar(60);
//Console.WriteLine($"Saldo da Ana Paula pós-deposito : R$ {String.Format("{0:0.00}", conta2.saldo)}");

//Console.WriteLine($"Saldo da Ana Paula pré-transferencia : R$ {String.Format("{0:0.00}", conta2.saldo)}");
//Console.WriteLine($"Saldo da Renata pré-transferencia : R$ {String.Format("{0:0.00}", conta1.saldo)}");

//bool transferencia = conta1.Transferir(50, conta2);
//Console.WriteLine("transferencia realizada com sucesso? : " +transferencia);

//Console.WriteLine($"Saldo da Ana Paula pós-transferencia : R$ {String.Format("{0:0.00}", conta2.saldo)}");
//Console.WriteLine($"Saldo da Renata pós-transferencia : R$ {String.Format("{0:0.00}", conta1.saldo)}");


//Cliente cliente = new Cliente();
//cliente.Nome = "Renata Eugênia";
//cliente.Cpf = "16173461870";
//cliente.Profissao = "Programadora";

//ContaCorrente conta3 = new ContaCorrente(7590, "2256-X");

//conta3.Titular = cliente;
//conta3.Nome_agencia = "Angelica";
//conta3.Saldo = 500; 
//conta3.ativa = true;

//Console.WriteLine(" Nome: " + cliente.Nome);
//Console.WriteLine(" Cpf: " + cliente.Cpf);
//Console.WriteLine(" Profissão: " + cliente.Profissao);
//Console.WriteLine(" numero agencia: " + conta3.Numero_agencia);
//Console.WriteLine(" numero conta: " + conta3.Conta);
//Console.WriteLine(" Saldo: R$ " + conta3.Saldo);

ContaCorrente conta4 = new ContaCorrente( "Pacaembu",297, "25798-X");

ContaCorrente conta5 = new ContaCorrente("Jabaquara",358, "45968-X");

Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

Cliente elis = new Cliente();
elis.Nome = "Elis Angela";
elis.Profissao = "Mergulhadora";
elis.Cpf = "12345678";

Cliente maria = new Cliente();
maria.Nome = "Maria Helena";
maria.Profissao = "Atriz";
maria.Cpf = "98745612";

Console.WriteLine(Cliente.TotalDeClientesCadastrados);


Console.ReadKey();
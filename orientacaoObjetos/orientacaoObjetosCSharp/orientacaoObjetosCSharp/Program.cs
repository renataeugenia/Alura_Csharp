using bytebank;

Console.WriteLine("INICIANDO O PROJETO BYTEBANK");

Console.WriteLine();

ContaCorrente conta1 = new ContaCorrente();

conta1.titular = "Renata Eugênia";
conta1.conta = "25879 - X";
conta1.numero_agencia = 27;
conta1.nome_agencia = "Paulista";
conta1.saldo = 100.69;
conta1.ativa = false ;

ContaCorrente conta2 = new ContaCorrente();

conta2.titular = "Ana Paula Eugênia";
conta2.conta = "36957 - F";
conta2.numero_agencia = 40;
conta2.nome_agencia = "Higienópolis";
conta2.saldo = 200.87;
conta2.ativa = true;

ContaCorrente conta3 = new ContaCorrente();


Console.WriteLine("Titular: " + conta1.titular);
Console.WriteLine("Conta: " + conta1.conta);
Console.WriteLine("Numero_Agencia: " + conta1.numero_agencia);
Console.WriteLine("Nome_Agencia: " + conta1.nome_agencia);
Console.WriteLine($"Saldo: R$ {String.Format("{0:0.00}", conta1.saldo)}");
Console.WriteLine($"conta ativa: {conta1.ativa}");

Console.WriteLine();

Console.WriteLine("Titular: " + conta2.titular);
Console.WriteLine("Conta: " + conta2.conta);
Console.WriteLine("Numero_Agencia: " + conta2.numero_agencia);
Console.WriteLine("Nome_Agencia: " + conta2.nome_agencia);
Console.WriteLine($"Saldo: R$ {String.Format("{0:0.00}", conta2.saldo)}");
Console.WriteLine($"conta ativa: {conta2.ativa}");

Console.WriteLine();

Console.WriteLine("Titular: " + conta3.titular);
Console.WriteLine("Conta: " + conta3.conta);
Console.WriteLine("Numero_Agencia: " + conta3.numero_agencia);
Console.WriteLine("Nome_Agencia: " + conta3.nome_agencia);
Console.WriteLine($"Saldo: R$ {String.Format("{0:0.00}", conta3.saldo)}");
Console.WriteLine($"conta ativa: {conta3.ativa}");

Console.WriteLine($"Saldo da Ana Paula pré-saque : R$ {String.Format("{0:0.00}", conta2.saldo)}");
conta2.Sacar(50);
Console.WriteLine($"Saldo da Ana Paula pós-saque : R$ {String.Format("{0:0.00}", conta2.saldo)}");
conta2.Depositar(60);
Console.WriteLine($"Saldo da Ana Paula pós-deposito : R$ {String.Format("{0:0.00}", conta2.saldo)}");

Console.WriteLine($"Saldo da Ana Paula pré-transferencia : R$ {String.Format("{0:0.00}", conta2.saldo)}");
Console.WriteLine($"Saldo da Renata pré-transferencia : R$ {String.Format("{0:0.00}", conta1.saldo)}");

bool transferencia = conta1.Transferir(50, conta2);
Console.WriteLine("transferencia realizada com sucesso? : " +transferencia);

Console.WriteLine($"Saldo da Ana Paula pós-transferencia : R$ {String.Format("{0:0.00}", conta2.saldo)}");
Console.WriteLine($"Saldo da Renata pós-transferencia : R$ {String.Format("{0:0.00}", conta1.saldo)}");

Console.ReadKey();
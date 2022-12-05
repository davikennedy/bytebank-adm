using bytebankAdm.Funcionarios;
using bytebankAdm.Utilitarios;

Console.WriteLine("Boas vindas ao Bytebank Administração!\n");

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

Funcionario f1 = new Funcionario();
f1.Nome = "João";
f1.Cpf = "039.745.842-63";
f1.Salario = 2000;

/*Console.WriteLine($"Nome: {f1.Nome}");
Console.WriteLine($"CPF: {f1.Cpf}");
Console.WriteLine($"Salário: {f1.Salario:C}");
Console.WriteLine($"Bonificação: {f1.getBonificacao():C}\n");*/

Diretor d1 = new Diretor();
d1.Nome = "Paula";
d1.Cpf = "012.345.678-90";
d1.Salario = 5000;

/*Console.WriteLine($"Nome: {d1.Nome}");
Console.WriteLine($"CPF: {d1.Cpf}");
Console.WriteLine($"Salário: {d1.Salario:C}");
Console.WriteLine($"Bonificação: {d1.getBonificacao():C}\n");*/

gerenciador.Registrar(f1);
gerenciador.Registrar(d1);
Console.WriteLine($"Total de bonificação: {gerenciador.getBonificacao():C}");


Console.ReadKey();
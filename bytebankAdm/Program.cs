using bytebankAdm.Funcionarios;
using bytebankAdm.Utilitarios;

Console.WriteLine("Boas vindas ao Bytebank Administração!\n");

CalcularBonificacao();
void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer pedro = new Designer("039.745.842-63");
    pedro.Nome = "Pedro";

    Desenvolvedor manuela = new Desenvolvedor("483.025.191-90");
    manuela.Nome = "Manuela";

    Diretor paula = new Diretor("012.345.678-90");
    paula.Nome = "Paula";

    Auxiliar igor = new Auxiliar("987.654.321-01");
    igor.Nome = "Igor";

    GerenteDeContas camila = new GerenteDeContas("326.985.628.89");
    camila.Nome = "Camila";

    gerenciador.Registrar(pedro);
    gerenciador.Registrar(manuela);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(camila);

    Console.WriteLine($"Total de bonificação: {gerenciador.GetBonificacao():C}");
}

/*GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

Funcionario f1 = new Funcionario("039.745.842-63", 2000);
f1.Nome = "João";

Funcionario f2 = new Diretor("987.654.321-01", 10000);
f2.Nome = "Maria";

Diretor d1 = new Diretor("012.345.678-90", 5000);
d1.Nome = "Paula";

Console.WriteLine($"Nome: {f1.Nome}");
Console.WriteLine($"Salário: {f1.Salario:C}");
Console.WriteLine($"Bonificação: {f1.getBonificacao():C}\n");

Console.WriteLine($"Nome: {f2.Nome}");
Console.WriteLine($"Salário: {f2.Salario:C}");
Console.WriteLine($"Bonificação: {f2.getBonificacao():C}\n");

Console.WriteLine($"Nome: {d1.Nome}");
Console.WriteLine($"Salário: {d1.Salario:C}");
Console.WriteLine($"Bonificação: {d1.getBonificacao():C}\n");

gerenciador.Registrar(f1);
gerenciador.Registrar(f2);
gerenciador.Registrar(d1);

Console.WriteLine($"Total de bonificação: {gerenciador.getBonificacao():C}");
Console.WriteLine($"Total de funcionarios: {Funcionario.TotalFuncionarios}");

f1.aumentarSalario();
Console.WriteLine($"Novo salário do {f1.Nome}: {f1.Salario:C}");

f2.aumentarSalario();
Console.WriteLine($"Novo salário do {f2.Nome}: {f2.Salario:C}");

d1.aumentarSalario();
Console.WriteLine($"Novo salário do {d1.Nome}: {d1.Salario:C}");*/

Console.ReadKey();
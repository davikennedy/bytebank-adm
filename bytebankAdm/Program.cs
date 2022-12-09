using bytebankAdm.Funcionarios;
using bytebankAdm.SistemaInterno;
using bytebankAdm.Utilitarios;

Console.WriteLine("Boas vindas ao Bytebank Administração!\n");

CalcularBonificacao();
UsarSistema();
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

void UsarSistema()
{
    SistemaInterno sistemaInterno = new SistemaInterno();

    Diretor roberta = new Diretor("159.753.398-04");
    roberta.Nome = "Roberta";
    roberta.Login = roberta.Cpf;
    roberta.Senha = "123";

    GerenteDeContas marcelo = new GerenteDeContas("326.985.628-89");
    marcelo.Nome = "Marcelo";
    marcelo.Login = marcelo.Cpf;
    marcelo.Senha = "321";

    sistemaInterno.Logar(roberta, roberta.Login, roberta.Senha);
    sistemaInterno.Logar(marcelo, marcelo.Login, "543");
}

Console.ReadKey();

void telaInicial(){
    Console.WriteLine("---- Seja Bem-vindo ao Atlas ----");

    Console.WriteLine("1 - Cadastrar colaborador");
    Console.WriteLine("2 - Cadastrar notebook");
    Console.WriteLine("3 - Cadastrar celular");
    Console.WriteLine("4 - Cadastrar impressora");
    Console.WriteLine("5 - Exibir lista de colaboradores.");
    Console.WriteLine("6 - Exibir lista de notebooks");
    Console.WriteLine("7 - Sair");

}

telaInicial();

bool executando = true;

DadosAtlas dadosAtlas = new DadosAtlas();

CadastroCelular cadastroCelular = new CadastroCelular();
CadastroImpressora cadastroImpressora = new CadastroImpressora();
CadastroColaboradores cadastroDeColaboradores = new CadastroColaboradores(dadosAtlas);
CadastroNotebook notebooks = new CadastroNotebook(dadosAtlas);

while (executando)
{
    switch (Console.ReadLine())
    {
        case "1":
            cadastroDeColaboradores.CadastroDeColaboradores();
            break;

        case "2":
            notebooks.CadastrarNotebook();
            break;

        case "3":
            cadastroCelular.CadastrarCelular();
            break;

        case "4":
            cadastroImpressora.CadastroDeImpressoras();
            break;

        case "5":
            cadastroDeColaboradores.ExibirColaborador();
            break;

        case "6":
            notebooks.ExibindoNotebooks();
            break;

        case "7":
            Console.WriteLine("Saindo!");
            executando = false;
            break;

        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;

    }
    if (executando)
    {
        Console.WriteLine("\nPressiona qualquer tecla para poder voltar ao manu");
        Console.ReadKey();
        Console.Clear();
        telaInicial();
    }



}
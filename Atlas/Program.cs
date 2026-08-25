
void telaInicial(){
    Console.WriteLine("---- Seja Bem-vindo ao Atlas ----");

    Console.WriteLine("1 - Cadastrar Notebook");
    Console.WriteLine("2 - Cadastrar Celular");
    Console.WriteLine("3 - Cadastrar Impressora");
    Console.WriteLine("4 - Cadastrar Colaborador");
    Console.WriteLine("5 - Para exibir notebooks cadastrados.");
    Console.WriteLine("6 - Sair");

}

telaInicial();

bool executando = true;

CadastroNotebook notebooks = new CadastroNotebook();
CadastroCelular cadastroCelular = new CadastroCelular();
CadastroImpressora cadastroImpressora = new CadastroImpressora();
CadastroColaboradores cadastroDeColaboradores = new CadastroColaboradores();

while (executando)
{
    switch (Console.ReadLine())
    {
        case "1":
            notebooks.CadastrarNotebook();
            break;

        case "2":
            cadastroCelular.CadastrarCelular();
            break;

        case "3":
            cadastroImpressora.CadastroDeImpressoras();
            break;

        case "4":
            cadastroDeColaboradores.CadastroDeColaboradores();
            break;

        case "5":
            notebooks.ExibindoNotebooks();
            break;

        case "6":
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
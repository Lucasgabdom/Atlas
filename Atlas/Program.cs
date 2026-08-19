
void telaInicial(){
    Console.WriteLine("---- Seja Bem-vindo ao Atlas ----");

    Console.WriteLine("1 - Cadastrar Notebook");
    Console.WriteLine("2 - Cadastrar Celular");
    Console.WriteLine("3 - Cadastrar Impressora");
    Console.WriteLine("4 - Cadastrar Colaborador");
    Console.WriteLine("5 - Sair");

}

telaInicial();

bool executando = true;



while (executando)
{
    switch (Console.ReadLine())
    {
        case "1":
            CadastroNotebook notebooks = new CadastroNotebook();
            notebooks.CadastrarNotebook();
            break;

        case "2":
            CadastroCelular cadastroCelular = new CadastroCelular();
            cadastroCelular.CadastrarCelular();
            break;

        case "3":
            CadastroImpressora cadastroImpressora = new CadastroImpressora();
            cadastroImpressora.CadastroDeImpressoras();

            break;

        case "4":
            CadastroColaboradores cadastroDeColaboradores = new CadastroColaboradores();
            cadastroDeColaboradores.CadastroDeColaboradores();
            break;

        case "5":
            Console.WriteLine("Saindo!");
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;

    }
    Console.Clear();
    telaInicial();



}
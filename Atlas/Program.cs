
void telaInicial(){
    Console.WriteLine("---- Seja Bem-vindo ao Atlas ----");

    Console.WriteLine("1 - Cadastrar Notebook");
    Console.WriteLine("2 - Cadastrar Celular");
    Console.WriteLine("3 - Cadastrar Impressora");
    Console.WriteLine("4 - Cadastrar Colaborador");
    Console.WriteLine("5 - Sair");

}

telaInicial();




switch(Console.ReadLine())
{
    case "1":
        Console.WriteLine("Digite o modelo do notebook:");
        string modeloNotebook = Console.ReadLine()!;

        Console.WriteLine("Digite o processador do notebook:");
        string processadorNotebook = Console.ReadLine()!;

        Console.WriteLine("Digite a memória RAM do notebook:");
        string memoriaRamNotebook = Console.ReadLine()!;

        Console.WriteLine("Digite o armazenamento do notebook:");
        string armazenamentoNotebook = Console.ReadLine()!;

        Notebooks notebook1 = new Notebooks(modeloNotebook, processadorNotebook, memoriaRamNotebook, armazenamentoNotebook);

        notebook1.ExibirInformacoes();
        telaInicial();
        break;

    case "2":
        Console.WriteLine("Digite o modelo do celular:");
        string modeloCelular = Console.ReadLine()!;

        Console.WriteLine("Digite a memória RAM do celular:");
        string memoriaRamCelular = Console.ReadLine()!;

        Console.WriteLine("Digite o armazenamento do celular:");
        string armazenamentoCelular = Console.ReadLine()!;

        Celulares celular1 = new Celulares(modeloCelular, memoriaRamCelular, armazenamentoCelular);
        celular1.CadastrarAtivo();
        break;

    case "3":
        Console.WriteLine("Digite o modelo da impressora:");
        string impressoraModelo = Console.ReadLine()!;

        Console.WriteLine("Digite a memória RAM do celular:");
        string tipoImpressora = Console.ReadLine()!;

        Console.WriteLine("Digite o armazenamento do celular:");
        string conectividadeImpressora = Console.ReadLine()!;

        Impressoras impressora1 = new Impressoras(impressoraModelo, tipoImpressora, conectividadeImpressora);
        impressora1.ExibirInformacoes();
        break;

    case "4":
        Console.WriteLine("Digite o id do colaborador:");
        string idColaborador = Console.ReadLine()!;

        Console.WriteLine("Nome do colaborador:");
        string nomeColaborador = Console.ReadLine()!;

        Console.WriteLine("E-mail do Colaborador:");
        string emailColaborador = Console.ReadLine()!;

        Console.WriteLine("Telefone do colaborador:");
        string telefoneColaborador = Console.ReadLine()!;

        Console.WriteLine("Cardo do colaborador:");
        string cargoColaborador = Console.ReadLine()!;

        Colaborador p1 = new Colaborador(idColaborador, nomeColaborador, emailColaborador, telefoneColaborador, cargoColaborador);
        p1.ExibirInformacoes();
        break;

    case "5":
        Console.WriteLine("Saindo!");
        break;



}
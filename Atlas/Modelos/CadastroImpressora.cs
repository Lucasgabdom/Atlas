public class CadastroImpressora
{
    List<Impressoras> listaImpressoras = new List<Impressoras>();

    public void CadastroDeImpressoras()
    {
        Console.WriteLine("Digite o modelo da impressora:");
        string impressoraModelo = Console.ReadLine()!;

        Console.WriteLine("Digite a memória RAM do celular:");
        string tipoImpressora = Console.ReadLine()!;

        Console.WriteLine("Digite o armazenamento do celular:");
        string conectividadeImpressora = Console.ReadLine()!;

        Impressoras impressora = new Impressoras (impressoraModelo, tipoImpressora, conectividadeImpressora);

        listaImpressoras.Add (impressora);
        Console.WriteLine("Impressora ");
    }
}
public class Celulares
{
    public string Modelo { get; set; }
    public string MemoriaRam { get; set; }
    public string Armazenamento { get; set; }

    public Celulares(string modelo, string memoriaRam, string armazenamento)
    {
        Modelo = modelo;
        MemoriaRam = memoriaRam;
        Armazenamento = armazenamento;
    }

    public void CadastrarAtivo()
    {
        Console.WriteLine($"\n---- Cadastrando Ativo de TI ----");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Memória RAM: {MemoriaRam}");
        Console.WriteLine($"Armazenamento: {Armazenamento}");
    }
}
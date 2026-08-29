public class Celulares : Ativo
{

    public string MemoriaRam { get; set; }
    public string Armazenamento { get; set; }

    public Celulares(int idAtivo, string patrimonio, string fabricante, string modelo, string situacao, string memoriaRam, string armazenamento) : base(idAtivo, patrimonio, fabricante, modelo, situacao)
    {
        MemoriaRam = memoriaRam; 
        Armazenamento = armazenamento;
    }
}
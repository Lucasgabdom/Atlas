using System.Reflection;
using System.Security.Cryptography.X509Certificates;

public class Notebooks : Ativo
{
    public string Processador { get; set; }
    public string Memoria { get; set; }
    public string Armazenamento { get; set; }

    public Notebooks (int idAtivo,string patrimonio, string fabricante, string modelo, string situacao, string processador, string memoria, string armazenamento) : base(idAtivo, patrimonio, fabricante, modelo, situacao)
    {
        Processador = processador;
        Memoria = memoria;
        Armazenamento = armazenamento;
    }
}
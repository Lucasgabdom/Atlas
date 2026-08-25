using System.Security.Cryptography.X509Certificates;

public class Ativo
{
    public int IdAtivo {  get; set; }
    public string Patrimonio { get; set; }
    public string Fabricante { get; set; }
    public string Modelo { get; set; }
    public string Situacao { get; set; }

    public Ativo(int idAtivo, string patrimonio, string fabricante, string modelo, string situacao)
    {
        IdAtivo = idAtivo;
        Patrimonio = patrimonio;
        Fabricante = fabricante;
        Modelo = modelo;
        Situacao = situacao;

    }
}
using System;

public class PessoaJuridica : Cliente
{
    public string CNPJ { get; set; }
    public string RazaoSocial { get; set; }

    public override void ExibirDocumento()
    {
        Console.WriteLine("CNPJ: " + CNPJ);
    }
}
using System;

public class PessoaFisica : Cliente
{
    public string CPF { get; set; }

    public override void ExibirDocumento()
    {
        Console.WriteLine("CPF: " + CPF);
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        PessoaFisica cliente = new PessoaFisica();
        cliente.Nome = "João";
        cliente.CPF = "123.456.789-00";

        ContaCorrente conta = new ContaCorrente();
        conta.NumeroConta = "0001";
        conta.Titular = cliente;

        cliente.ExibirDocumento();

        Console.WriteLine("Titular da conta: " + conta.Titular.Nome);
    }
}
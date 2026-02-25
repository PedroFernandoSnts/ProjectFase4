public abstract class ContaBancaria
{
    public string NumeroConta { get; set; }

    // A conta recebe um cliente
    public Cliente Titular { get; set; }

    public decimal Saldo { get; protected set; }

    public abstract void CalcularTarifa();
}
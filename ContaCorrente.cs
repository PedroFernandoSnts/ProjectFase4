public class ContaCorrente : ContaBancaria
{
    public override void CalcularTarifa()
    {
        Saldo -= 15;
    }
}
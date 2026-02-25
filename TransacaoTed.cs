public class TransacaoTed : Transacao
{
    public override bool Validar()
    {
        return base.Validar() && valor > 500;
    }
}
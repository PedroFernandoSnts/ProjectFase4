public class TransacaoPix : Transacao
{
    public string ChavePix { get; set; }

    public override bool Validar()
    {
        return base.Validar() && valor <= 10000;
    }
}
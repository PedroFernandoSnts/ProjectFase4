using System;

public abstract class Transacao
{
    protected decimal valor;

    public decimal Valor
    {
        get { return valor; }
        set
        {
            if (value > 0)
                valor = value;
        }
    }

    public DateTime Data { get; set; } = DateTime.Now;

    public ContaBancaria Origem { get; set; }
    public ContaBancaria Destino { get; set; }

    public virtual bool Validar()
    {
        return valor > 0 && Origem != null && Destino != null;
    }
}
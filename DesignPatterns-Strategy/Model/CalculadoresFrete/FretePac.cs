using DesignPatterns_Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns_Strategy.Model.CalculadoresFrete;

internal class FretePac : IStrategyFrete
{
    public double Calcular(Produto produto, double distancia)
    {
        ArgumentNullException.ThrowIfNull(produto);
        if (produto.Valor == 0)
            return 0;

        return (produto.Valor * 0.1) + (distancia * 0.5);
    }
}


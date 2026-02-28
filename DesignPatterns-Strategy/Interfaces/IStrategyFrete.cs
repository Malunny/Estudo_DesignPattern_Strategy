using DesignPatterns_Strategy.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns_Strategy.Interfaces
{
    internal interface IStrategyFrete
    {
        double Calcular(Produto produto, double distancia);
    }
}

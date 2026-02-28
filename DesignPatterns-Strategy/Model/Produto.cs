using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns_Strategy.Model
{
    internal class Produto(string nome, double valor)
    {
        public string Nome { get; set; } = nome;
        public double Valor { get; set; } = (valor < 0) ? 
            throw new ArgumentException("O valor do produto não pode ser menor que zero")
            : valor;
    }
}

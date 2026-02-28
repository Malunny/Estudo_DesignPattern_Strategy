// See https://aka.ms/new-console-template for more information

using DesignPatterns_Strategy.Interfaces;
using DesignPatterns_Strategy.Model;
using DesignPatterns_Strategy.Model.CalculadoresFrete;

Action<IEnumerable<Produto>,double, IStrategyFrete> MostrarProdutoCFrete
    = (IEnumerable<Produto> produtos, double distanciaKm, IStrategyFrete calculadorDeFrete) =>
    {
        for (int i = 0; i < Console.WindowWidth; i++)
            Console.Write("-");

        string tipoDeFrete = nameof(calculadorDeFrete);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Tipo de frete: {tipoDeFrete}" + Environment.NewLine);
        Console.ForegroundColor = ConsoleColor.White;
        foreach (var produto in produtos)
        {
            double frete = calculadorDeFrete.Calcular(produto, distanciaKm);

            string freteArredondado = String.Format("{0:C}", Math.Round(frete, 2));
            string valorParaReal = String.Format("{0:C}", produto.Valor);

            Console.WriteLine
                (
                $"{produto.Nome} de valor: {valorParaReal}" + Environment.NewLine +
                $"{freteArredondado} de frete." + Environment.NewLine
                );
        }

        for (int i = 0; i < Console.WindowWidth; i++)
            Console.Write("-");
    };

IStrategyFrete transportadora = new FretePac();
double distanciaKm = 12;

Produto[] produtos =
    [
        new Produto("Cadeira de madeira", 99.99),
        new Produto("Mesa de madeira", 199.99),
        new Produto("Estante de madeira", 359.99)
    ];

MostrarProdutoCFrete.Invoke(produtos, distanciaKm, transportadora);

transportadora = new FreteTransportadora();

MostrarProdutoCFrete.Invoke(produtos, distanciaKm, transportadora);

using System;

namespace DevFitness.ConsoleApp
{
    public class Bebida : Refeicao
    {
        public Bebida(string descricao, int calorias, bool contemLactose) : base(descricao, calorias)
        {
            ContemLactose = contemLactose;
        }

        public bool ContemLactose { get; private set; }
        public override void ImprimirMensagem()
        {
            Console.WriteLine($"{Descricao}, com {Calorias} calorias, e contem Lactose: {ContemLactose}");
        }
    }
}

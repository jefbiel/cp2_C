using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP
{
    
    internal class Moto : Veiculo
    {
        string modelo;

        public Moto(string placa, string modelo, string cor, string motor)
        {
            capacidadePessoa = 2;
            this.placa = placa;
            this.modelo = modelo;
            this.cor = cor;
            this.motor = motor;
            Random random = new Random();
            chassi = random.Next().ToString("00000000000000000");
        }

        
        public override void Acelerar()
        {
            Console.WriteLine("Moto acelerando e dando grau...");
        }
    }
}
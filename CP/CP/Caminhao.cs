using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP
{

    internal class Caminhao : Veiculo
    {
        string modelo;
        public Caminhao(string placa, string modelo, string cor, string motor)
        {
            capacidadePessoa = 3;
            this.placa = placa;
            this.modelo = modelo;
            this.cor = cor;
            this.motor = motor;
            Random random = new Random();
            chassi = random.Next().ToString("00000000000000000");
        }

       
        public override void Acelerar()
        {
            Console.WriteLine("Caminhão acelerando lentamente com carga pesada...");
        }
    }
}
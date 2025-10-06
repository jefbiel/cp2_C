using System;
using System.Collections.Generic; // Habilita o uso de List<T>
using CP;

namespace CP
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
            List<Veiculo> veiculos = new List<Veiculo>();


            veiculos.Add(new Carro("XYZ4321", "Hyundai Elantra", "Preto", "2.0"));
            veiculos.Add(new Caminhao("LMN8765", "Kia K3000", "Branco", "3.0L"));
            veiculos.Add(new Moto("JKL6543", "KTM 390 Duke", "Laranja", "390cc"));

            foreach (Veiculo v in veiculos)
            {
                v.Acelerar();
            }
        }
    }
}
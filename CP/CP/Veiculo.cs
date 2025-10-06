using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP
{
    
    abstract class Veiculo
    {
        protected string placa;
        protected string chassi;
        protected string cor;
        protected string motor;
        protected int pessoas;
        protected int capacidadePessoa;

        
        public virtual void Acelerar()
        {
            Console.WriteLine("Veículo acelerando...");
        }
    }
}

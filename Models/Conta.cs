using System;
using System.Threading.Tasks;

namespace DotNet_Classes_Abstratas_Interfaces.Models
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Conta
    {
        protected decimal saldo;

        public abstract void Creditar(decimal valor);

        public void ExibirSaldo(){
            Console.WriteLine("O seu saldo é:" + saldo);
        }
    }
}

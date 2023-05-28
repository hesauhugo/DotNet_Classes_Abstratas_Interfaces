using System;
using System.Threading.Tasks;

namespace DotNet_Classes_Abstratas_Interfaces.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Corrente: Conta
    {
        public override void Creditar(decimal valor){
            saldo+=valor;
        }
    }
}

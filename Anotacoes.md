# Classe abstrata

*  Uma classe abstrata tem como objetivo ser exclusivamente um modelo para ser herdado, portanto não poode ser instanciada

* Você pode implementar métodos ou deixalos a cargo de quem herdar

* protected: só pode ser alterado apenas pelas suas classes filhas
* ` public abstract void Creditar(decimal valor);` quem implementar a classe tem que implementar  o creditar, ele não tem corpo


```csharp
    public abstract class Conta
    {
        protected decimal saldo;

        public abstract void Creditar(decimal valor);

        public void ExibirSaldo(){
            Console.WriteLine("O seu saldo é:" + saldo);
        }
    }
```

## Classe Object
* A classe System.Object é a mãe de todas as classes na hierarquia do .NET
* Todas as classes derivam, direta ou indiretamente da classe Object, e ela tem como objetivo prover serviços de baixo nível para suas classes filhas.

* No exemplo a seguir , sobrescreve-se o metodo tostring  que é da classe `Object`
* `Object` colocado didaticamente, pois se apaga-lo ainda assim teremos acesso ao object, pois como dito antes ele é a mãe da hierarquia do .NET
```csharp
    public class Computador : Object
    {
        public override string ToString(){
            return "Método ToString() sobrescrito";
        }

    }
```

# Interfaces
* Uma interface é um contrato que pode ser implementado por uma classe.
* É como se fosse uma classe abstrata, podendo definir métodos abstratos para serem implementados,
* Assim como uma classe abstrata, uma interface não pode ser instanciada.
* Uma classe pode implementar mais de uma interface

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

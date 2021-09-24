using System;

namespace aula02_itau
{
    class Program
    {
        static void Main(string[] args)
        {
            //iniciando classes e variaveis
            Conta_Corrente CC = new Conta_Corrente(10,11111,2222);
            Conta_Poupanca CP = new Conta_Poupanca();

            Console.WriteLine(CC.ToString());
            Console.WriteLine(CP.ToString());
            CC.sacar_dinheiro(10);
            CC.sacar_dinheiro(10);
        }
    }

    class Conta_Corrente{

        public int valor;
        public int agencia;
        public int conta;

        public Conta_Corrente(){}
        public Conta_Corrente(int valor, int agencia, int conta){
        this.valor = valor;
        this.agencia = agencia;
        this.conta = conta;

        }

        public void depositar_dinheiro(int dinheiro){}
        public void mostrar_extrato(){}

        public void sacar_dinheiro(int dinheiro){
            this.valor -= dinheiro;
            if(valor < 0){
                Console.WriteLine("Você está no cheque especial. Com o saldo de: " + Convert.ToString(valor) + " e o saque de: " + Convert.ToString(dinheiro));
            }else
            {
                Console.WriteLine("Com o saldo de: " + Convert.ToString(valor) + " e o saque de: " + Convert.ToString(dinheiro));
            }
        }

    }

    class Conta_Poupanca : Conta_Corrente{

        public int taxa;
        public int redimento_acumulado;
        public int imposto;
  
        public Conta_Poupanca(){
            this.taxa = 0;
            this.redimento_acumulado = 0;
            this.imposto = 0;
        }

        public void mostar_rendimento(){}
        public void mostar_imposto(){}
    }
}

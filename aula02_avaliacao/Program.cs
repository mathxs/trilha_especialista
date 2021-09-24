using System;

namespace aula02_avaliacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario comum = new Funcionario("Matheus Santos", 160, 50.00);
            Funcionario terceiro = new FuncionarioTerceiro("Gabriela Aparecida",140,50,"Casa e Compania",1.1);

            Console.WriteLine("Digite 'SIM' se deseja consultar informações do Terceiro, ou 'NAO' se for do funcionario Comum:");
            String entrada = Console.ReadLine();

            if(entrada == "SIM"){

                terceiro.ImprimeDados();

            }else if(entrada == "NAO"){

                comum.ImprimeDados();

            }else{
                Console.WriteLine("Entrada Invalida, tente novamente mais tarde.");
            }



        }
    
    }

    class Funcionario{
        private String _nome;
        public String GetNome(){return _nome;}
        public void SetNome(String nome){ _nome = nome;}

        public int CargaHoraria{get; set;}
        public double ValorHora{ get; set;}
        

        public Funcionario(){}

        public Funcionario(String nome, int CargaHoraria, double ValorHora){
            this.CargaHoraria = CargaHoraria;
            this.ValorHora = ValorHora;
            this._nome = nome;
        }

        public virtual double CalculoSalario(){
            return this.CargaHoraria * this.ValorHora;
        }
        public virtual void ImprimeDados(){
            Console.WriteLine($"Nome: {this.GetNome()}, Salario: {this.CalculoSalario():F2}.");
        }


    }

    class FuncionarioTerceiro : Funcionario{
        private String _empresaOrigem;
        public String GetEmpresaOrigem(){ return _empresaOrigem; }
        public void SetEmpresaOrigem(String empresaOrigem){ _empresaOrigem = empresaOrigem; }
        public double taxaServico{ get; set; }

        public FuncionarioTerceiro(){}
        public FuncionarioTerceiro(String nome, int CargaHoraria, double ValorHora, String empresaOrigem, double taxaServico){
            this.CargaHoraria = CargaHoraria;
            this.ValorHora = ValorHora;
            this.SetNome(nome);
            this._empresaOrigem = empresaOrigem;
            this.taxaServico = taxaServico;

        }


        public override double CalculoSalario(){
            return (this.CargaHoraria * this.ValorHora) * this.taxaServico;
        }
        public override void ImprimeDados(){
            Console.WriteLine($"Nome: {this.GetNome()}, Empresa de Origem: {this.GetEmpresaOrigem()}, Salario: {this.CalculoSalario():F2}.");
        }

        

    }
}

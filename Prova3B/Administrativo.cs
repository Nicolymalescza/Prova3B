using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova3B
{
    public class Administrativo : Funcionario
    {
        public double Transporte { get; set; }
        public double Alimentacao { get; set; }

        public Administrativo() { }
        public Administrativo(string nome, string cpf, string matricula, DateTime dataNasc, string sexo, double salario, double transporte, double alimentacao) : base(nome, cpf, matricula, dataNasc, sexo, salario)
        {
            Transporte = transporte;
            Alimentacao = alimentacao;
        }

        public override double Beneficio(double salario)
        {
            //double valeTransporte = 150;
            return salario + 0.15;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova3B
{
    public class Medico : Funcionario
    {
        public string CRM { get; set; }
        public double HoraExtra { get; set; }
        public string Especialidade { get; set; }

        public Medico() { }
        public Medico(string nome, string cpf, string matricula, DateTime dataNasc, string sexo, double salario,string cRM, double horaExtra, string especialidade): base( nome, cpf, matricula, dataNasc, sexo, salario)
        {
            CRM = cRM;
            HoraExtra = horaExtra;
            Especialidade = especialidade;
        }
        
        public override double Beneficio(double salario)
        {
            double auxilio = 0.20;
            return salario + auxilio; 
        }
    }
}

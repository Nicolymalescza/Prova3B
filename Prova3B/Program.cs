using Prova3B;
using System;
public class  Program
{
    static void Main(string[] args)
    {
        string nome;
        string cpf;
        string matricula;
        DateTime dataNasc;
        string sexo;
        double salario;

        List<Funcionario> list = new List<Funcionario>();
        Funcionario fun = new Funcionario();
        Medico funMedico = new Medico();
        Administrativo funAdm = new Administrativo();


        while (true) 
        {
            Console.WriteLine("Selecione o tipo de funcionario desejado\n0 - Sair\n1 - Funcionario Normal\n2 - Médico\n3 - Administrativo");
            int opc = Convert.ToInt32(Console.ReadLine());  

            switch (opc)
            {
                case 0:
                    goto sair;


                    case 1://Funcionario Normal
                    //Funcionario fun = new Funcionario();
                    Console.Write("Infome seu nome: ");
                    fun.Nome = Console.ReadLine();

                    Console.Write("Infome seu cpf: ");
                    fun.Cpf = Console.ReadLine();

                    Console.Write("Infome sua matricula: ");
                    fun.Matricula = Console.ReadLine();

                    Console.Write("Infome sua data de nasciemnto: ");
                    fun.DataNasc = Convert.ToDateTime(Console.ReadLine());

                    Console.Write("Infome seu sexo: ");
                    fun.Sexo = Console.ReadLine();

                    Console.Write("Infome seu salario: ");
                    fun.Salario = Convert.ToDouble(Console.ReadLine());
                    break;

                    case 2://Médico  
                    //Medico funMedico = new Medico();
                    Console.Write("Infome seu nome: ");
                    funMedico.Nome = Console.ReadLine();

                    Console.Write("Infome seu cpf: ");
                    funMedico.Cpf = Console.ReadLine();

                    Console.Write("Infome sua matricula: ");
                    funMedico.Matricula = Console.ReadLine();

                    Console.Write("Infome sua data de nasciemnto: ");
                    funMedico.DataNasc = Convert.ToDateTime(Console.ReadLine());

                    Console.Write("Infome seu sexo: ");
                    funMedico.Sexo = Console.ReadLine();

                    Console.Write("Infome seu salario: ");
                    funMedico.Salario = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Infome seu CRM: ");
                    funMedico.CRM = Console.ReadLine();

                    Console.Write("Infome suas horas extras: ");
                    funMedico.HoraExtra = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Infome sua expecialidade: ");
                    funMedico.Especialidade = Console.ReadLine();
                    break;


                    case 3://Administrativo
                    Console.Write("Infome seu nome: ");
                    funAdm.Nome = Console.ReadLine();

                    Console.Write("Infome seu cpf: ");
                    funAdm.Cpf = Console.ReadLine();

                    Console.Write("Infome sua matricula: ");
                    funAdm.Matricula = Console.ReadLine();

                    Console.Write("Infome sua data de nasciemnto: ");
                    funAdm.DataNasc = Convert.ToDateTime(Console.ReadLine());

                    Console.Write("Infome seu sexo: ");
                    funAdm.Sexo = Console.ReadLine();

                    Console.Write("Infome seu salario: ");
                    funAdm.Salario = Convert.ToDouble(Console.ReadLine());

                    break;
            }
        }
        sair:;


        Console.ReadKey();
    }
}
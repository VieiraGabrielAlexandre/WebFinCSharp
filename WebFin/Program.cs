using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFin.Funcionarios;

namespace WebFin
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            Funcionario funcionario = new Funcionario();
            Diretor diretor = new Diretor();

            string nomeFuncionario = Console.ReadLine();
            double salarioFuncionario = Convert.ToDouble(Console.ReadLine());
            funcionario.Nome = nomeFuncionario;
            funcionario.Salario = salarioFuncionario;
            gerenciador.Registrar(funcionario);

            string nomeDiretor = Console.ReadLine();
            double salarioDiretor = Convert.ToDouble(Console.ReadLine());
            diretor.Nome = nomeDiretor;
            diretor.Salario = salarioDiretor;
            gerenciador.Registrar(diretor);

            Console.WriteLine("Dados Funcionarios");
            Console.WriteLine(funcionario.Nome);
            Console.WriteLine(funcionario.Salario);

            Console.WriteLine("Dados Diretores");
            Console.WriteLine(diretor.Nome);
            Console.WriteLine(diretor.Salario);

            Console.WriteLine("Beneficios");
            Console.WriteLine(gerenciador.GetTotalBonificacao());


            Console.ReadLine();

        }
    }
}

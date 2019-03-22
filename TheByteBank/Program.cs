using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheByteBank.Funcionarios;
using TheByteBank.Sistemas;

namespace TheByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            UsarSistema();
            Console.ReadLine();
        }
        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            GerenteDeConta camila = new GerenteDeConta("529.432.090-65");
            camila.Nome = "Camila";
            camila.Senha = "abc";

            Diretor roberta = new Diretor("623.232.148-19");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "12345";

            Console.WriteLine(sistemaInterno.Logar(roberta, "123"));
            Console.WriteLine(sistemaInterno.Logar(camila, "abc"));
            Console.WriteLine(sistemaInterno.Logar(parceiro, "12345"));

        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Funcionario pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Funcionario roberta = new Diretor("623.232.148-19");
            roberta.Nome = "Roberta";

            Funcionario igor = new Auxiliar("133.892.248-01");
            igor.Nome = "Igor";
                
            Funcionario camila = new GerenteDeConta("529.432.090-65");
            camila.Nome = "Camila";

            Funcionario arthur = new Desenvolvedor("378.316.478-80");
            arthur.Nome = "Arthur";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);
            gerenciadorBonificacao.Registrar(arthur);

            Console.WriteLine("Total de Bonificações do Mês " + gerenciadorBonificacao.GetTotalBonificacao());

        }
    }
}

using ByteBank.Funcionarios;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            CaclcularBonificacao();
            Console.ReadLine();

        }

        public static void CaclcularBonificacao()
        {

            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer("546.879.157-20");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("852.654.754-62");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("987.456.321-34");
            igor.Nome = "Igor";

            GerenteDeConta camila = new GerenteDeConta("253.653.154-91");
            camila.Nome = "Camila";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de bonificação do mês " + gerenciadorBonificacao.GetTotalBonioficacao());
        }
    }
}

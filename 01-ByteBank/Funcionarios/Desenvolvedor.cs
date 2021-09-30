using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string cpf) : base(cpf, 2000)
        {

        }

        public override void AumentarSalario()
        {
            Salario *= 0.15;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.1;
        }
    }
}

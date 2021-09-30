using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Funcionarios
{
    public class GerenteDeConta : Funcionario
    {
        public GerenteDeConta(string cpf) : base(cpf, 4000)
        {

        }
        public override double GetBonificacao()
        {
            return Salario *= 0.25;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }
    }
}

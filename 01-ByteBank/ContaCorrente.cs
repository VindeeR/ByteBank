namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }

        public static int TotalDeContasCriadas { get; private set; }

        private int _agencia;
        public int Agencia {
            get {
                return _agencia;
            }
            set
            {
                if (value <= 0) {
                    return;
                }

                _agencia = value;
            }
        }

        public int Conta { get; set; }

        private double _saldo = 100;
        public double Saldo{
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    _saldo = value;
                    return;
                }
            }
        }


        public ContaCorrente(int agencia, int conta)
        {
            Agencia = agencia;
            Conta = conta;

            TotalDeContasCriadas++;
        }


        public bool Sacar(double valor)
        {
            if ((this._saldo - valor) >= 0)
            {
                this._saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }


        public void Depositar(double valor)
        {
            this._saldo += valor;
        }


        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }
}
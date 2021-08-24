using System;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrente = new ContaCorrente();

            contaCorrente.titular = "Gabriela";
            contaCorrente.numeroAgencia = 0182;
            contaCorrente.numeroConta = 1587412;
            contaCorrente.saldo = 100.00;

            Console.WriteLine(contaCorrente.titular);
            Console.WriteLine(contaCorrente.numeroAgencia);
            Console.WriteLine(contaCorrente.numeroConta);
            Console.WriteLine(contaCorrente.saldo);

            Console.ReadLine();
        }
    }
}

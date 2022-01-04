namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoBruno = new ContaCorrente();
            contaDoBruno.titular = "Bruno";
            
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";

            contaDoBruno.Sacar(50);

            contaDoBruno.Depositar(500);

            contaDoBruno.Transferir(100, contaDaGabriela);

        }
    }
}
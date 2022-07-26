using ProjetoByteBank;

namespace bytebank
{
    public class ContaCorrente
    {
        public Cliente titular;
        public string conta;
        public int numero_agencia;
        public string nome_agencia;
        public double saldo;
        public bool ativa;

        public bool Sacar(double valor)
        {
            if(saldo < valor || valor < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            saldo = saldo + valor;
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if(saldo < valor || valor < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                destino.saldo = destino.saldo + valor;
                return true;
            }
        }
            
    }
}
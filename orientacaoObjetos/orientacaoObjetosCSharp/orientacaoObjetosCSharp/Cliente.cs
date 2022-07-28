using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoByteBank
{
    public class Cliente
    {
        public Cliente()
        {
            TotalDeClientesCadastrados += 1;
        }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Profissao { get; set; }
        public static int TotalDeClientesCadastrados { get; set; }






    }
}

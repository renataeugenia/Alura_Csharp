using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAdmByteBank.Funcionarios
{
  public class Diretor
    {
        #region Propriedades


        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }

        #endregion

        #region Metodos
        public double getBonificacao()
        {
            return Salario;
        }


        #endregion


    }
}

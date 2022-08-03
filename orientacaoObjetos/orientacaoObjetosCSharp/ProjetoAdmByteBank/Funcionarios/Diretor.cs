using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAdmByteBank.Funcionarios
{
  public class Diretor:Funcionario
    {
      

        #region Metodos
        // metodo sobrescrito classe filha e utilização da palavra base. para acessar comportamento d classe mae.
        public override double getBonificacao()
        {
            return Salario * 0.50 + base.getBonificacao();
        }


        #endregion


    }
}

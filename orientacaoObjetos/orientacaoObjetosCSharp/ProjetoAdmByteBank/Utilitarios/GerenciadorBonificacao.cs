using ProjetoAdmByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAdmByteBank.Utilitarios
{
    public class GerenciadorBonificacao
    {
        private double totalBonificacao;

        #region Sobrecarga de Metodos

        public void Registrar(Funcionario funcionario)
        {
            this.totalBonificacao += funcionario.getBonificacao();
        }
             
        #endregion


        #region Metodos

        public double getBonificacao()
        {
            return this.totalBonificacao;
        }
        #endregion
    }


}

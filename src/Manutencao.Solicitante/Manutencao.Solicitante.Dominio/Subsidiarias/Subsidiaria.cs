using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manutencao.Solicitante.Dominio.Subsidiarias
{
    public class Subsidiaria : Entidade
    {
        public Subsidiaria(string nome)
        {
            ExcecaoDeDominio.LancarQuando(string.IsNullOrEmpty(nome), "Nome da subsidiária é inválido");
            Nome = nome;
        }

        public string Nome { get; private set; }
    }
}

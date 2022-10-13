using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manutencao.Solicitante.Aplicacao
{
    public interface IRepositorio<TEntidade>
    {
        List<TEntidade> Consultar();
        TEntidade ObterPorId(string id);
        void Adicionar(TEntidade entity);
    }
}

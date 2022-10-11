using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manutencao.Solicitante.Dominio
{
    public class ExcecaoDeDominio : Exception
    {
        public ExcecaoDeDominio(string mensagem) : base(mensagem) { }

        public static void LancarQuando(bool regraInvalida, string mensagem)
        {
            if (regraInvalida)
                throw new ExcecaoDeDominio(mensagem);
        }
    }
}

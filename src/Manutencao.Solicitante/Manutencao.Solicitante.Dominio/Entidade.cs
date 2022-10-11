using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manutencao.Solicitante.Dominio
{
    public abstract class Entidade
    {
        public string Id { get; set; }

        protected Entidade()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manutencao.Solicitante.Aplicacao.SolicitacoesDeManutencao
{
    public class SolicitacaoDeManutencaoDto
    {
        public string SubsidiariaId { get; set; }
        public int SolicitanteId { get; set; }
        public string NomeDoSolicitante { get; set; }
        public int TipoDeSolicitacaoDeManutencao { get; set; }
        public string Justificativa { get; set; }
        public string NumeroDoContrato { get; set; }
        public DateTime InicioDesejadoParaManutencao { get; set; }
    }
}

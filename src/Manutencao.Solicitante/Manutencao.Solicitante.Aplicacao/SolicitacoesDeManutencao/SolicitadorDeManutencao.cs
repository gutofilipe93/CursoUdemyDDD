using Manutencao.Solicitante.Aplicacao.Subsidiarias;
using Manutencao.Solicitante.Dominio.SolicitacoesDeManutencao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manutencao.Solicitante.Aplicacao.SolicitacoesDeManutencao
{
    public class SolicitadorDeManutencao
    {
        private readonly ISolicitacaoDeManutencaoRepositorio _solicitacaoDeManutencaoRepositorio;
        private readonly ISubsidiariaRepository _subsidiariaRepository;

        public SolicitadorDeManutencao(ISolicitacaoDeManutencaoRepositorio solicitacaoDeManutencaoRepositorio, ISubsidiariaRepository subsidiariaRepository)
        {
            _solicitacaoDeManutencaoRepositorio = solicitacaoDeManutencaoRepositorio;
            _subsidiariaRepository = subsidiariaRepository;
        }

        public void Solicitar(SolicitacaoDeManutencaoDto dto)
        {
            var subsidiaria = _subsidiariaRepository.ObterPorId(dto.SubsidiariaId);

            var tipoDeSolicitacaoManutencao = Enum.Parse<TipoDeSolicitacaoDeManutencao>(dto.TipoDeSolicitacaoDeManutencao.ToString());
            var solicitacaoDeManutencao = new SolicitacaoDeManutencao(subsidiaria.Id, dto.SolicitanteId, dto.NomeDoSolicitante,
                                                                      tipoDeSolicitacaoManutencao, dto.Justificativa, dto.NumeroDoContrato,
                                                                       "Jardinagem SA", "0000000000000", "Henrique Almeida", DateTime.Now.AddDays(356), dto.InicioDesejadoParaManutencao);
            
            _solicitacaoDeManutencaoRepositorio.Adicionar(solicitacaoDeManutencao);
        }
    }
}

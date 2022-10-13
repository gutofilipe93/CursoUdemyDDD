using Manutencao.Solicitante.Aplicacao.SolicitacoesDeManutencao;
using Manutencao.Solicitante.Dominio.SolicitacoesDeManutencao;
using Nosbor.FluentBuilder.Lib;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Manutencao.Solicitante.Testes.Aplicacao.SolicitacoesDeManutencao
{
    public class SolicitadorDeManutencaoTeste
    {
        private readonly SolicitacaoDeManutencaoDto _dto;
        private readonly SolicitadorDeManutencao _solicitador;
        private readonly SolicitacaoDeManutencao _solicitacaoDeManutencao;
        private readonly ISolicitacaoDeManutencaoRepositorio _solicitacaoDeManutencaoRepositorio;
        

        public SolicitadorDeManutencaoTeste()
        {
            _dto = new SolicitacaoDeManutencaoDto
            {
                SubsidiariaId = "XPTO-ABC",
                SolicitanteId = 1,
                NomeDoSolicitante = "Ricardo José",
                TipoDeSolicitacaoDeManutencao = TipoDeSolicitacaoDeManutencao.Jardinagem.GetHashCode(),
                Justificativa = "Grama Alta",
                NumeroDoContrato = "2135",
                InicioDesejadoParaManutencao = DateTime.Now.AddMonths(2)
            };

            _solicitacaoDeManutencaoRepositorio = Substitute.For<ISolicitacaoDeManutencaoRepositorio>();            
            _solicitacaoDeManutencao = FluentBuilder<SolicitacaoDeManutencao>.New().With(s => s.IdentificadorDaSubsidiaria, _dto.SubsidiariaId).Build();            
            
            _solicitador = new SolicitadorDeManutencao(_solicitacaoDeManutencaoRepositorio,null);
        }

        [Fact]
        public void Deve_salvar_solicitacao_de_manutencao()
        {
            _solicitador.Solicitar(_dto);

            _solicitacaoDeManutencaoRepositorio.Received(1)
                .Adicionar(Arg.Is<SolicitacaoDeManutencao>(solicitacao =>
                    solicitacao == _solicitacaoDeManutencao));
        }
      
    }
}

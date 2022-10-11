using ExpectedObjects;
using Manutencao.Solicitante.Dominio.SolicitacoesDeManutencao;
using Manutencao.Solicitante.Testes._Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Manutencao.Solicitante.Testes.Dominio.SolicitacoesDeManutencao
{
    public class SolicitanteTeste
    {
        private const int Identificador = 55;
        private const string Nome = "Henrique Almeida";

        [Fact]
        public void Deve_criar_solicitante()
        {
            var solicitanteEsperado = new
            {
                Identificador,
                Nome
            };

            var solicitante = new Autor(solicitanteEsperado.Identificador, solicitanteEsperado.Nome);

            solicitanteEsperado.ToExpectedObject().ShouldMatch(solicitante);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void Deve_validar_nome_do_solicitante(string nomeInvalido)
        {
            const string mensagemEsperada = "Nome do solicitante é inválido";

            AssertExtensions.ThrowsWithMessage(() => new Autor(Identificador, nomeInvalido), mensagemEsperada);
        }
    }
}

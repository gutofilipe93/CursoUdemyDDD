using ExpectedObjects;
using Manutencao.Solicitante.Dominio.Subsidiarias;
using Manutencao.Solicitante.Testes._Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Manutencao.Solicitante.Testes.Dominio.Subsidiarias
{
    public class SubsidiariaTeste
    {
        [Fact]
        public void Deve_criar_subsidiaria()
        {
            var subsidiariaEsperada = new
            {
                Nome = "Campo Grande",
            };

            var subsidiaria = new Subsidiaria(subsidiariaEsperada.Nome);

            subsidiariaEsperada.ToExpectedObject().ShouldMatch(subsidiaria);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void Deve_validar_nome(string nomeInvalido)
        {
            const string mensagemEsperada = "Nome da subsidiária é inválido";

            AssertExtensions.ThrowsWithMessage(() => new Subsidiaria(nomeInvalido), mensagemEsperada);
        }
    }
}

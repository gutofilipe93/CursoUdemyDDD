using Manutencao.Solicitante.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Manutencao.Solicitante.Testes._Util
{
    public static class AssertExtensions
    {
        public static void ThrowsWithMessage(Action testCode, string messageExpected)
        {
            var message = Assert.Throws<ExcecaoDeDominio>(testCode).Message;
            Assert.Equal(messageExpected, message);
        }

        public static void ThrowsWithMessageAsync(Func<Task> testCode, string messageExpected)
        {
            var result = Assert.ThrowsAsync<ExcecaoDeDominio>(testCode).Result;
            Assert.Equal(messageExpected, result.Message);
        }
    }
}

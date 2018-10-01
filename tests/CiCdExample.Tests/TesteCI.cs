using Xunit;

namespace CiCdExample.Tests
{
    public class TesteCI
    {
        [Fact]
        public void Teste()
        {
            Assert.True((1 + 1) == 2);
        }

        [Fact]
        public void Teste2()
        {
            Assert.True((1 + 2) == 3);
        }

        [Fact]
        public void Teste3()
        {
            Assert.True((1 + 3) == 4);
        }

    }
}

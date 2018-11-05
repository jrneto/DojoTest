using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TesteNF.Utils.UnitTesting
{
    [TestClass] 
    public class TributacaoHelperTeste01
    {
        [TestMethod]
        public void TestarCalculoPIS()
        {
            Assert.AreEqual(TributacaoHelper
                .CalcularPIS(8400.00), 54.60);
        }

        [TestMethod]
        public void TestarCalculoCOFINS()
        {
            Assert.AreEqual(TributacaoHelper
                .CalcularCOFINS(8400.00), 252.00);
        }

        [TestMethod]
        public void TestarCalculoIRPJ()
        {
            Assert.AreEqual(TributacaoHelper
                .CalcularIRPJ(8400.00), 126.00);
        }

        [TestMethod]
        public void TestarCalculoCSLL()
        {
            Assert.AreEqual(TributacaoHelper
                .CalcularCSLL(8400.00), 84.00);
        }
    }
}

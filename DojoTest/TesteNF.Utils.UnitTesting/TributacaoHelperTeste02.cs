using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TesteNF.Utils.UnitTesting
{
    [TestClass]
    public class TributacaoHelperTeste02
    {
        [TestMethod]
        public void TestarCalculoPIS()
        {
            Assert.AreEqual(TributacaoHelper
                .CalcularPIS(7728.00), 50.23);
        }

        [TestMethod]
        public void TestarCalculoCOFINS()
        {
            Assert.AreEqual(TributacaoHelper
                .CalcularCOFINS(7728.00), 231.84);
        }

        [TestMethod]
        public void TestarCalculoIRPJ()
        {
            Assert.AreEqual(TributacaoHelper
                .CalcularIRPJ(7728.00), 115.92);
        }

        [TestMethod]
        public void TestarCalculoCSLL()
        {
            Assert.AreEqual(TributacaoHelper
                .CalcularCSLL(7728.00), 77.28);
        }
    }
}

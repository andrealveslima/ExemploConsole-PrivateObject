using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjetoDeUnitTests
{
    [TestClass]
    public class ClasseASerTestadaTest
    {
        [TestMethod]
        public void TesteDaAPIPrivada()
        {
            ExemploConsole_PrivateObject.ClasseASerTestada obj = new ExemploConsole_PrivateObject.ClasseASerTestada();
            PrivateObject privateObj = new PrivateObject(obj);

            // Testando MetodoPrivado.
            var retorno = (bool)privateObj.Invoke("MetodoPrivado");
            Assert.IsTrue(retorno);

            // Testando MetodoPrivado com parâmetro.
            retorno = (bool)privateObj.Invoke("MetodoPrivado", false);
            Assert.IsFalse(retorno);

            // Testando _atributoPrivado.
            Assert.AreEqual("Teste", privateObj.GetField("_atributoPrivado"));
            privateObj.SetField("_atributoPrivado", "Novo valor");
            Assert.AreEqual("Novo valor", privateObj.GetField("_atributoPrivado"));

            // Testando PropriedadeComSetterPrivado.
            privateObj.SetProperty("PropriedadeComSetterPrivado", 51);
            Assert.AreEqual(51, obj.PropriedadeComSetterPrivado);

            PrivateType privateType = new PrivateType(typeof(ExemploConsole_PrivateObject.ClasseASerTestada));

            // Testando _atributoEstaticoPrivado.
            Assert.AreEqual("Teste estático", privateType.GetStaticField("_atributoEstaticoPrivado"));
            privateType.SetStaticField("_atributoEstaticoPrivado", "Novo valor estático");
            Assert.AreEqual("Novo valor estático", privateType.GetStaticField("_atributoEstaticoPrivado"));

            // Testando MetodoEstaticoPrivado.
            retorno = (bool)privateType.InvokeStatic("MetodoEstaticoPrivado");
            Assert.IsFalse(retorno);
        }
    }
}

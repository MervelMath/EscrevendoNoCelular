using Microsoft.VisualStudio.TestTools.UnitTesting;
using EscrevendoNoCelular.ConsoleApp;
namespace ValidarSaidas.Test
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void TestarEntradaIguai()
        {
            Controlador mensagem = new Controlador();
            string test = mensagem.DividirMensagem("ABC");
            Assert.AreEqual("2_22_222", test);
        }


        [TestMethod]
        public void TestarEntradaPratica()
        {
            Controlador mensagem = new Controlador();
            string test = mensagem.DividirMensagem("SEMPRE ACESSO O DOJOPUZZLES");
            Assert.AreEqual("77773367_7773302_222337777_777766606660366656667889999_9999555337777", test);
        }


    }
}

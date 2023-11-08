using libreria_de_clases;

namespace pruebas_de_testeos
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void VerificarIgualdadDeJugadores()
        {
            JugadorDeBasket jugadorDeBasket = new JugadorDeBasket(500,"aro",34, "agustin", "landeira", 31, EDeporte.Basquet);
            JugadorDeFutbol jugadorDeFutbol = new JugadorDeFutbol(32,"delantero",21,"agustin","landeira",23,EDeporte.Futbol);

            bool rta = jugadorDeBasket == jugadorDeFutbol;

            Assert.IsTrue(rta);
        }
    }
}
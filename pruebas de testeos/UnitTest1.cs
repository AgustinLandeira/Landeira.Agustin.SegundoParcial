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

        [TestMethod]
        public void VerificarDesigualdadDeJugadores()
        {
            JugadorDeBasket jugadorDeBasket = new JugadorDeBasket(500, "aro", 34, "agustin", "landeira", 31, EDeporte.Basquet);
            JugadorDeFutbol jugadorDeFutbol = new JugadorDeFutbol(32, "delantero", 21, "francis", "fernandez", 23, EDeporte.Futbol);

            bool rta = jugadorDeFutbol == jugadorDeBasket;

            Assert.IsFalse(rta);
        }

        [TestMethod]
        public void VerificarPromedioCorrecto()
        {
            JugadorDeFutbol jugadorDeFutbol = new JugadorDeFutbol(32, "delantero", 21, "agustin", "landeira", 23, EDeporte.Futbol);

            
            string promedio = jugadorDeFutbol.CalcularPromedio();
            float resultado = (float)jugadorDeFutbol.Goles / jugadorDeFutbol.partidosJugados;
            string promedioEsperado = resultado.ToString("0.00");

            Assert.AreEqual(promedioEsperado,promedio);
        }

        [TestMethod]
        public void VerificarListaNoNula()
        {
            JugadorDeBeisbol beisbolista = new JugadorDeBeisbol("bate",23,34,"barry","alen",21,EDeporte.Beisbol);
            Registro<Jugadores> miRegistro = new Registro<Jugadores>();

            
            List<Jugadores> lista = miRegistro.ListaJugadores;

            Assert.IsNotNull(lista);

        }

    }
}
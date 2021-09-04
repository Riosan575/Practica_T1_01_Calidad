using NUnit.Framework;
using Practica_T1_01_Calidad;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_T1_01_CalidadTest
{
    public class JuegoUtilitiesTest
    {
        private Jugador jugador = new Jugador { Nombre = "Angel"};
        private Jugador jugador2 = new Jugador { Nombre = "Benja"};

        [Test]
        public void Caso01()
        {
            var ganador = new Ganador(new List<Jugador>());
            jugador.Eleccion = "Papel";
            jugador2.Eleccion = "Tijera";
            var result = ganador.VerGanador(jugador);
            Assert.AreEqual("Gano", result);
        }
        [Test]
        public void Caso02()
        {
            var ganador = new Ganador(new List<Jugador>());
            jugador.Eleccion = "Piedra";
            jugador2.Eleccion = "Tijera";
            var result = ganador.VerGanador(jugador);
            Assert.AreEqual("Gano", result);
        }
        [Test]
        public void Caso03()
        {
            var ganador = new Ganador(new List<Jugador>());
            jugador.Eleccion = "Tijera";
            jugador2.Eleccion = "Tijera";
            var result = ganador.VerGanador(jugador);
            Assert.AreEqual("Empate", result);
        }
        [Test]
        public void Caso04()
        {
            var ganador = new Ganador(new List<Jugador>());
            jugador.Eleccion = "Tijera";
            jugador2.Eleccion = "Papel";
            var result = ganador.VerGanador(jugador);
            Assert.AreEqual("Gano", result);
        }
        [Test]
        public void Caso05()
        {
            var ganador = new Ganador(new List<Jugador>());
            jugador.Eleccion = "Tijera";
            jugador2.Eleccion = "Papel";
            var result = ganador.VerGanador(jugador);
            Assert.AreEqual("Gano", result);
        }
        [Test]
        public void Caso06()
        {
            var ganador = new Ganador(new List<Jugador>());
            jugador.Eleccion = "Tijera";
            jugador2.Eleccion = "Papel";
            var result = ganador.VerGanador(jugador);
            Assert.AreEqual("Gano", result);
        }
        [Test]
        public void Caso07()
        {
            var ganador = new Ganador(new List<Jugador>());
            jugador.Eleccion = "Tijera";
            jugador2.Eleccion = "Papel";
            var result = ganador.VerGanador(jugador);
            Assert.AreEqual("Gano", result);
        }
        [Test]
        public void Caso08()
        {
            var ganador = new Ganador(new List<Jugador>());
            jugador.Eleccion = "Tijera";
            jugador2.Eleccion = "Papel";
            var result = ganador.VerGanador(jugador);
            Assert.AreEqual("Gano", result);
        }
        [Test]
        public void Caso09()
        {
            var ganador = new Ganador(new List<Jugador>());
            jugador.Eleccion = "Tijera";
            jugador2.Eleccion = "Papel";
            var result = ganador.VerGanador(jugador);
            Assert.AreEqual("Gano", result);
        }
        [Test]
        public void Caso10()
        {
            var ganador = new Ganador(new List<Jugador>());
            jugador.Eleccion = "Tijera";
            jugador2.Eleccion = "Papel";
            var result = ganador.VerGanador(jugador);
            Assert.AreEqual("Gano", result);
        }
        [Test]
        public void Caso11()
        {
            var ganador = new Ganador(new List<Jugador>());
            jugador.Eleccion = "Tijera";
            jugador2.Eleccion = "Papel";
            var result = ganador.VerGanador(jugador);
            Assert.AreEqual("Gano", result);
        }
        [Test]
        public void Caso12()
        {
            var ganador = new Ganador(new List<Jugador>());
            jugador.Eleccion = "Tijera";
            jugador2.Eleccion = "Papel";
            var result = ganador.VerGanador(jugador);
            Assert.AreEqual("Gano", result);
        }
    }
}

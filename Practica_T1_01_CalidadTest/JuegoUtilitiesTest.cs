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
        public void VerGanadorCaso01()
        {
            var ganador = new Ganador(new List<Jugador>());
            jugador.Eleccion = "Tijera";
            jugador2.Eleccion = "Papel";
            var result = ganador.VerGanador(jugador,jugador2);
            Assert.AreEqual("gana jugador 1", result);
        }
        [Test]
        public void VerGanadorCaso02()
        {
            var ganador = new Ganador(new List<Jugador>());
            jugador.Eleccion = "Papel";
            jugador2.Eleccion = "Tijera";
            var result = ganador.VerGanador(jugador, jugador2);
            Assert.AreEqual("gana jugador 2", result);
        }
        [Test]
        public void VerGanadorCaso03()
        {
            var ganador = new Ganador(new List<Jugador>());
            jugador.Eleccion = "Papel";
            jugador2.Eleccion = "Papel";
            var result = ganador.VerGanador(jugador, jugador2);
            Assert.AreEqual("Empate", result);
        }
        [Test]
        public void VerGanadorCaso04()
        {
            var ganador = new Ganador(new List<Jugador>());
            jugador.Eleccion = "";
            jugador2.Eleccion = "";
            var result = ganador.VerGanador(jugador, jugador2);
            Assert.AreEqual("", result);
        }
        [Test]
        public void VerGanadorCaso05()
        {
            var ganador = new Ganador(new List<Jugador>());
            jugador.Eleccion = "Piedra";
            jugador2.Eleccion = "Tijera";
            var result = ganador.VerGanador(jugador, jugador2);
            Assert.AreEqual("gana jugador 1", result);
        }
        [Test]
        public void VerGanadorCaso06()
        {
            var ganador = new Ganador(new List<Jugador>());
            jugador.Eleccion = "Tijera";
            jugador2.Eleccion = "Piedra";
            var result = ganador.VerGanador(jugador, jugador2);
            Assert.AreEqual("gana jugador 2", result);
        }
        [Test]
        public void VerGanadorCaso07()
        {
            var ganador = new Ganador(new List<Jugador>());
            jugador.Eleccion = "Piedra";
            jugador2.Eleccion = "Piedra";
            var result = ganador.VerGanador(jugador, jugador2);
            Assert.AreEqual("Empate", result);
        }
        [Test]
        public void VerGanadorCaso08()
        {
            var ganador = new Ganador(new List<Jugador>());
            jugador.Eleccion = "Tijera";
            jugador2.Eleccion = "Tijera";
            var result = ganador.VerGanador(jugador, jugador2);
            Assert.AreEqual("Empate", result);
        }
        [Test]
        public void VerGanadorCaso09()
        {
            var ganador = new Ganador(new List<Jugador>());
            jugador.Eleccion = "Papel";
            jugador2.Eleccion = "Piedra";
            var result = ganador.VerGanador(jugador, jugador2);
            Assert.AreEqual("gana jugador 1", result);
        }
        [Test]
        public void VerGanadorCaso10()
        {
            var ganador = new Ganador(new List<Jugador>());
            jugador.Eleccion = "Piedra";
            jugador2.Eleccion = "Papel";
            var result = ganador.VerGanador(jugador, jugador2);
            Assert.AreEqual("gana jugador 2", result);
        }
        [Test]
        public void VerGanadorCaso11()
        {
            var ganador = new Ganador(new List<Jugador>());
            jugador.Eleccion = "Piedra";
            jugador2.Eleccion = " ";
            var result = ganador.VerGanador(jugador, jugador2);
            Assert.AreEqual("gana jugador 1", result);
        }
        [Test]
        public void VerGanadorCaso12()
        {
            var ganador = new Ganador(new List<Jugador>());
            jugador.Eleccion = " ";
            jugador2.Eleccion = "Tijera";
            var result = ganador.VerGanador(jugador, jugador2);
            Assert.AreEqual("gana jugador 2", result);
        }
        [Test]
        public void VerGanadorCaso13()
        {
            var ganador = new Ganador(new List<Jugador>());
            jugador.Eleccion = " ";
            jugador2.Eleccion = "Papel";
            var result = ganador.VerGanador(jugador, jugador2);
            Assert.AreEqual("gana jugador 2", result);
        }
        [Test]
        public void VerGanadorCaso14()
        {
            var ganador = new Ganador(new List<Jugador>());
            jugador.Eleccion = "Tijera";
            jugador2.Eleccion = " ";
            var result = ganador.VerGanador(jugador, jugador2);
            Assert.AreEqual("gana jugador 1", result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_T1_01_Calidad
{
    public class Ganador
    {
        private List<Jugador> jugador;

        public Ganador(List<Jugador> jugador)
        {
            this.jugador = jugador;
        }
        public string VerGanador(Jugador jugador1, Jugador jugador2)
        {
            if (jugador1.Eleccion == "Tijera" && jugador2.Eleccion == "Papel")
                return "gana jugador 1";
            if (jugador1.Eleccion == "Papel" && jugador2.Eleccion == "Tijera")
                return "gana jugador 2";
            if (jugador1.Eleccion == "Papel" && jugador2.Eleccion == "Papel")
                return "Empate";
            if (jugador1.Eleccion == " " && jugador2.Eleccion == " ")
                return " ";
            if (jugador1.Eleccion == "Piedra" && jugador2.Eleccion == "Tijera")
                return "gana jugador 1";
            if (jugador1.Eleccion == "Tijera" && jugador2.Eleccion == "Piedra")
                return "gana jugador 2";
            if (jugador1.Eleccion == "Piedra" && jugador2.Eleccion == "Piedra")
                return "Empate";
            if (jugador1.Eleccion == "Tijera" && jugador2.Eleccion == "Tijera")
                return "Empate";
            if (jugador1.Eleccion == "Papel" && jugador2.Eleccion == "Piedra")
                return "gana jugador 1";
            if (jugador1.Eleccion == "Piedra" && jugador2.Eleccion == "Papel")
                return "gana jugador 2";
            if (jugador1.Eleccion == "Piedra" && jugador2.Eleccion == " ")
                return "gana jugador 1";
            if (jugador1.Eleccion == " " && jugador2.Eleccion == "Tijera")
                return "gana jugador 2";
            if (jugador1.Eleccion == " " && jugador2.Eleccion == "Papel")
                return "gana jugador 2";
            if (jugador1.Eleccion == "Tijera" && jugador2.Eleccion == " ")
                return "gana jugador 1";
            return "";
        }
    }
}

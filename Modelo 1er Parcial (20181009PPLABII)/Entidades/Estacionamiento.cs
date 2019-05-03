using System;
using System.Collections.Generic;

namespace Entidades
{
    public class Estacionamiento
    {
        private int espacioDisponible;
        private string nombre;
        private List<Vehiculo> vehiculos;

        private Estacionamiento()
        {

        }

        public Estacionamiento(string nombre, int espacioDisponible)
        {

        }

        public static explicit operator string(Estacionamiento e)
        {
            return "";
        }

        public static bool operator !=(Estacionamiento e, Vehiculo v)
        {
            return false;
        }

        public static bool operator ==(Estacionamiento e, Vehiculo v)
        {
            if (e != v)
                return false;
            else
                return true;
        }

        public static string operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            return "";
        }

        public static Estacionamiento operator +(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            return new Estacionamiento();
        }
    }
}

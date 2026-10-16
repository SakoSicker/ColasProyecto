using System;
using System.Collections.Generic;
using System.Text;

namespace ColasProyecto
{
    internal class Colas
    {
        private string[] _cola;
        private int _frente;
        private int _tope;
        private int _contador;

        public Colas (int capacidad)
        {
            _cola = new string[capacidad];
            _frente = 0;
            _tope = 0;
            _contador = 0;
        }

        public void Agregar(string dato)
        {
            if (_contador == _cola.Length)
            {
                throw new Exception("La cola circular está llena.");
            }

            _cola[_tope] = dato;
            _tope = (_tope + 1) % _cola.Length;
            _contador++;
        }

        public void Eliminar()
        {
            if (_contador == 0)
            {
                throw new Exception("La cola circular está vacía.");
            }

            _cola[_frente] = string.Empty;
            _frente = (_frente + 1) % _cola.Length;
            _contador--;
        }

        public string ObtenerDatos()
        {
            StringBuilder datos = new StringBuilder();
            int indice = _frente;

            for (int i = 0; i < _contador; i++)
            {
                datos.AppendLine(_cola[indice]);
                indice = (indice + 1) % _cola.Length;
            }

            return datos.ToString();
        }
    }
}
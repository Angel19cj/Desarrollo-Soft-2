using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microondas
{
    internal class Tiempo
    {
        private int minutos;
        private int segundos;
        private int horas;

        public int Horas
        {
            get { return horas; }
            set
            {
                if (value < 10)
                {
                    horas = value;
                }
                else
                {
                    horas = 0;
                }
            }
        }

        public int Minutos
        {
            get { return minutos; }
            set
            {
                if (value < 60)
                {
                    minutos = value;
                }
                else
                {
                    minutos = 0;
                }
            }
        }

        public int Segundos
        {
            get { return segundos; }
            set
            {
                if (value < 60)
                {
                    segundos = value;
                }
                else
                {
                    segundos = 0;
                }
            }
        }

        //constructor
        public Tiempo(int horas, int minutos, int segundos)
        {
            Horas = horas;
            Minutos = minutos;
            Segundos = segundos;
        }
    }
}

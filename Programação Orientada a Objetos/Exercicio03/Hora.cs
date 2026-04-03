using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio03
{
    internal class Hora
    {
        private int _hora;
        private int _minuto;
        private int _segundo;

        public Hora(int hora, int minuto, int segundo)
        {
            if(!ValidarHorario(hora, minuto, segundo))
                throw new ArgumentException("Horário inválido");

            _hora = hora;
            _minuto = minuto;
            _segundo = segundo;
        }

        public static bool ValidarHorario(int hora, int minuto, int segundo)
        {
            return (hora >= 0 && hora <= 23) &&
                   (minuto >= 0 && minuto <= 59) &&
                   (segundo >= 0 && segundo <= 59);
        }

        public Hora IncrementarMinutos(int minutosAdicionar)
        {
            int novoMinuto = _minuto + minutosAdicionar;

            int novaHora = _hora + (novoMinuto / 60);

            novoMinuto = novoMinuto % 60;

            novaHora = novaHora % 24;

            return new Hora(novaHora, novoMinuto, _segundo);
        }

        private int TotalSegundos()
        {
            return _hora * 3600 + _minuto * 60 + _segundo;
        }
        public string Comparar(Hora outra)
        {
            int atual = TotalSegundos();
            int outro = outra.TotalSegundos();

            if (atual > outro)
                return "Adiante";

            if (atual < outro)
                return "Atrás";

            return "Igual";
        }

        public override string ToString()
        {
            return $"{_hora:D2}:{_minuto:D2}:{_segundo:D2}";
        }
    }
}

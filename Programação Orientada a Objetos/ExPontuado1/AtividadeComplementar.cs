using System;
using System.Collections.Generic;
using System.Text;

namespace ExPontuado1
{
    abstract class AtividadeComplementar
    {
        protected string _desc;
        protected int _cargaHoraria;
        protected int _maxCreditos = 4;

        public AtividadeComplementar(string desc, int cargaHoraria)
        {
            _desc = desc;
            _cargaHoraria = cargaHoraria;
        }
        public abstract int CalcularCreditos();
    }
}

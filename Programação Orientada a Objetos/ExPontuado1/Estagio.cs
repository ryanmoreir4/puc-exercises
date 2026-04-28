using System;
using System.Collections.Generic;
using System.Text;

namespace ExPontuado1
{
    class Estagio : AtividadeComplementar
    {
        public Estagio(string desc, int cargaHoraria)
            : base(desc, cargaHoraria)
        {           
        }
        public override int CalcularCreditos()
        {
            int creditos = _cargaHoraria / 45;

            if (creditos > _maxCreditos)
                creditos = _maxCreditos;
            return creditos;
        }
    }
}

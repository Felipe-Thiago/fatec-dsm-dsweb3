using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1.Model
{
    class Vilao : Pessoa
    {
        public string NomeVilao { get; set; }
        public string PlanetaOrigem { get; set; }
        public string Parceiro { get; set; }
        public string SuperPoder { get; set;}   

        public Vilao() : base()
        {
            NomeVilao = null;
            PlanetaOrigem = null;
            Parceiro = null;
            SuperPoder = null;
        }

        public override void calcularIdade(int anoAtual)
        {
            base.Idade = (anoAtual - base.AnoNasc) / 3;

        }
    }
}

using System;
using System.Collections.Generic;
using WindowsFormsApp1.Model.Data;

namespace WindowsFormsApp1.Model
{
    class AmigoHeroi : Pessoa
    {
        public string Hobby { get; set; }
        public string AtividadeProf { get; set; }

        public AmigoHeroi() : base()
        {
            Hobby = null;
            AtividadeProf = null;

        }
        public override void calcularIdade(int anoAtual)
        {
            base.Idade = anoAtual - base.AnoNasc;

        }
        
    }
}

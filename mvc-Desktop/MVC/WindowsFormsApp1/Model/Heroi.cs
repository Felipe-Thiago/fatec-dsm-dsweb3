using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1.Model
{
    class Heroi : Pessoa
    {
        //Propriedade - atributos específicos do Herói
        public string NomeHeroi { get; set; }
        public string PlanetaOrigem { get; set; }
        public string AtividadeProf { get; set; }
        public string Parceiro { get; set; }
        public string SuperPoder { get; set; }
        public string Grupo { get; set; }
        public string PontoFraco { get; set; }

        //construtor

        public Heroi() : base()
        {
            NomeHeroi = null;
            PlanetaOrigem = null;
            AtividadeProf = null;
            Parceiro = null;
            SuperPoder = null;
            Grupo = null;
            PontoFraco = null;


        }
        
        
        
        //Implementação do método abstrato -cacular idade-
        //É um método override (sobrescrito) porque será adaptado
        //para a classe herói
        public override void calcularIdade(int anoAtual)
        {
            base.Idade = (anoAtual - base.AnoNasc) / 5;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsFormsApp1.Model
{
    abstract class Pessoa
    {
        // declaração dos atributos
        private int idPessoa;
        private string nomePessoa;
        private int anoNasc;
        private int idade;
        private string email;
        // Construtor da classe, serve para inicializar os atributos da classe
        public Pessoa()
        {
            idPessoa = 0;
            nomePessoa = null;
            anoNasc = 0;
            idade = 0;
            email = null;
        }
        // Propriedades
        public int IdPessoa
        {
            get { return idPessoa; }
            set { idPessoa = value; }
        }
        public string NomePessoa
        {
            get { return nomePessoa; }
            set { nomePessoa =  value; }
        }
        public int AnoNasc
        {
            get { return anoNasc; }
            set { anoNasc = value; }
        }
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        //definir a assinatura do método abstrato
        public abstract void calcularIdade(int anoAtual);
    }
}

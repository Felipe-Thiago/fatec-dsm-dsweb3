using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Controller
{
    class HeroiController
    {
        public void inserirHeroi(Heroi heroi)
        {
            //if((heroi.NomePessoa != string.Empty) && (heroi.NomeHeroi != string.Empty) 
            if (heroi.NomePessoa != string.Empty)
            {
                // heroiModel é um objeto da classe HeroiModel
                // será usado para levar os dados do herói para a camada model
                HeroiModel heroiModel = new HeroiModel();

                if (heroiModel.Create(heroi) == true)
                {
                    MessageBox.Show("Heroi Cadastrado com sucesso", "Atenção",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Os Dados Nome, Nome Heroi e Planeta de Origem de" +
                        "Origem não podem ser vazios", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Information) ;

                    }
                }
            else
            {
                MessageBox.Show("Herói não cadastrado", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            }
        public bool consultarHeroi(Heroi heroi)
        {
            if (heroi.IdPessoa > 0)
            {
                HeroiModel heroiModel = new HeroiModel();
                return (heroiModel.Read(heroi));
            }
            else
            {
                return false;
            }
        }
        public List<Object> consultarHeroi()
        {
            //criando um objeto heroiModel da classe heroi Model
            //executar uma consulta de tdoos os heróis cadastrados
            HeroiModel heroiModel = new HeroiModel();
            return (heroiModel.Read());
        }
        public void atualizaHeroi(Heroi heroi)
        {
            if ((heroi.IdPessoa > 0) && (heroi.NomePessoa != string.Empty) &&
                (heroi.NomeHeroi != string.Empty) && (heroi.PlanetaOrigem != string.Empty))
            {
                //criando um obj heroiModel da classe heroiModel
                //enviar os dados do objeto heroi para a camada model
                HeroiModel heroiModel = new HeroiModel();
                if (heroiModel.Update(heroi))
                {
                    MessageBox.Show("Dados do Heroi atualizado com sucesso!!!", "ATENÇÃO",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Dados do Herói não atualizados: ", "ALERTA",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            
        }
        public void excluirHeroi(Heroi heroi)
        {
            if (heroi.IdPessoa > 0)
            {
                HeroiModel heroiModel = new HeroiModel();
                if (heroiModel.Delete(heroi))
                {
                    MessageBox.Show("Heroi Excluído com Sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    MessageBox.Show("Não foi possível excluir o Herói", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("O campo Id é obrigatório \n\nFavor Preencher", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
    }
}

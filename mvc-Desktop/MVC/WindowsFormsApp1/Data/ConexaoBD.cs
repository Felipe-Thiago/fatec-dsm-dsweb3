using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.SqlTypes;


namespace WindowsFormsApp1.Model.Data
{
    class ConexaoBD
    {
        // String de conexão com o Bnaco de Dados
        // Autentificação do Windows.
        private static string strConexao = "Data Source = localhost;" +
                                           "Initial Catalog = DBHeroisViloes;" +
                                           "Persist Security Info = True"; //Autenticação
                                           // "User ID=sa; Password=dba"; //Autenticação
        //User ID=sa;Password=dba
        //localhost pode ser o IP da maquina também.
        // Autentificação User/Pass

        //Representa a conexao do Banco
        private static SqlConnection conexao = null;
        //SqlConnection faz conexão com o banco de dados
        //Métodos que permite
        public static SqlConnection obterConexao()
        {
            try
            {
                //Criar conexao
                conexao = new SqlConnection(strConexao);
                //a conexao foi feita com sucesso. Vamos abrir o Banco de Dados
                conexao.Open();
                Console.WriteLine("Conexão OK");
                }
            catch (SqlException sqle)
            {
                conexao = null;
                MessageBox.Show("Conexão Error :" + sqle);
                //Mostrar o erro que ocorreu no campo
            }
            return conexao;
        }
        public static void fecharConexao()
        {
            if (conexao != null)
            {
                conexao.Close();
            }
        }
    }
}

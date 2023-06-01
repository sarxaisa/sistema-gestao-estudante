using MySql.Data.MySqlClient;
using System.Data;

namespace sistema_gestao_estudante
{
    internal class Meu_BD
    {
       private MySqlConnection conexao = new MySqlConnection("datasource=localhost;username=root;password=;database=sga_estudantes_bd_T4");
       
        public MySqlConnection getConexao
        {
            get
            {
                return conexao;
            }
        } 
       
        public void abrirConexao()
        {
            if (conexao.State == ConnectionState.Closed)
            {
                conexao.Open();
            }
        }
        public void fecharConexao()
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }
}

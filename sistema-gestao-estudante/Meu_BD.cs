using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace sistema_gestao_estudante
{
    internal class Meu_BD
    {
        MySqlConnection conexao = new MySqlConnection("datasource=localhost;username=root;password=;database=sga_estudantes_bd_T4");
    }
}

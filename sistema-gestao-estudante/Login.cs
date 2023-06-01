using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sistema_gestao_estudante
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Meu_BD bancoDeDados = new Meu_BD();

            MySqlDataAdapter adaptador = new MySqlDataAdapter();
            DataTable tabela = new DataTable();
            MySqlCommand comando= new MySqlCommand("SELECT * FROM `usuários` WHERE `username` = @usn AND `password`= @psd", bancoDeDados.getConexao);

            comando.Parameters.Add("@usn", MySqlDbType.VarChar).Value = textBox1.Text;
            comando.Parameters.Add("@psd", MySqlDbType.VarChar).Value = textBox2.Text;

            adaptador.SelectCommand= comando;
            adaptador.Fill(tabela);
           
            if (tabela.Rows.Count > 0)
            {
                MessageBox.Show("SIM");
            }
            else
            {
                MessageBox.Show("NÃO");
            }
        }
        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("../../Imagens/User.png");
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

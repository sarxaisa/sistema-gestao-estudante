using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_gestao_estudante
{
    public partial class FormInserirEstudantes : Form
    {
        public FormInserirEstudantes()
        {
            InitializeComponent();
        }

        private void Nome_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormInserirEstudantes_Load(object sender, EventArgs e)
        {

        }

        private void btnEnviarFotos(object sender, EventArgs e)
        {
            OpenFileDialog abrirArquivo = new OpenFileDialog();
            abrirArquivo.Filter = "Selecione a Foto (*. jpg;*.png;*gif)|*.jpg;*png;*.gif"; 

            if (abrirArquivo.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFoto.Image = Image.FromFile(abrirArquivo.FileName);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxFoto_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Estudante estudante = new Estudante();
            string nome = textBoxNome.Text;
            string telefone = txtBoxTelefone.Text;
            DateTime nascimento = dataDeNascimento.Value;
            string endereco = txtBoxEndereco.Text;
            string genero = "feminino";
            string sobrenome = txtBoxSobrenome.Text;
            if (buttonFeminino.Checked)
            {
                genero = "masculino";
            }



            MemoryStream foto = new MemoryStream();



            int anoDeNascimento = datedeNascimento.Value.Year;
            int anoAtual = DateTime.Now.Year;
            if ((anoAtual - anoDeNascimento < 10 ||
                (anoAtual - anoDeNascimento > 100)))
            {
                MessageBox.Show("A idade precisa ser entre 10 e 100 anos.",
                    "Idade Invalida",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Verificar())
            {
                pictureFoto.Image.Save(foto, pictureBoxFoto.Image.RawFormat);
                if (estudante.inserirEstudante(nome, sobrenome, nascimento, telefone, genero, foto))
                {
                    MessageBox.Show("Novo estudante cadatrado", "Sucesso!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

        bool Verificar()
        {
            if ((txtNome.Text.Trim() == "") ||
                (txtSobrenome.Text.Trim() == "") ||
                ((txtEndereco).Text.Trim() == "") ||
                ((txtTelefone).Text.Trim() == "") ||
                (pictureBoxFoto.Image == null))
            {
                return false;
            }



        }
       
        private void textBoxNome(object sender, EventArgs e)
        {

        }

        private void textBoxSobrenome(object sender, EventArgs e)
        {

        }

        private void textBoxEndereco(object sender, EventArgs e)
        {

        }

        private void txtBoxTelefone(object sender, EventArgs e)
        {

        }
    }
    }


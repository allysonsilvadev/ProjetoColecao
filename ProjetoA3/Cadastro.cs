using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoA3
{
    public partial class Cadastro : Form
    {

        List<ListaJogos> lista;
        int indice;

        public Cadastro(List<ListaJogos> lista, int indice = -1)
        {
            InitializeComponent();

            this.lista = lista;
            this.indice = indice;

            if (indice >= 0) //Editando um item
            {
                ListaJogos jogoSelecionado = lista[indice];
                lblTitulo.Text = jogoSelecionado.nome;
                txtNome.Text = jogoSelecionado.nome;
                txtPreco.Text = jogoSelecionado.preco.ToString();
                txtTempo.Text = jogoSelecionado.tempoJogado.ToString();
                pictureBox.Image = jogoSelecionado.imagem;
            }
            else
            {
                btnExcluir.Hide();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = "";
            float preco = 0;
            float tempoJogado = 0;

            if (txtNome.Text == "")
            {
                MessageBox.Show("Por favor, insira o nome do jogo.");
                return;
            }
            if (txtPreco.Text != "" && !float.TryParse(txtPreco.Text, out preco))
            {
                MessageBox.Show("Por favor, insira um valor válido para o preço.");
                return;
            }
            if (txtTempo.Text != "" && !float.TryParse(txtTempo.Text, out tempoJogado))
            {
                MessageBox.Show("Por favor, insira um valor válido para o tempo jogado.");
                return;
            }

            nome = txtNome.Text;
            ListaJogos jogo;

            if (indice >= 0) // Editando um Item
            {
                jogo = lista[indice];
                jogo.nome = nome;
            }
            else
            {
                jogo = new ListaJogos(nome);
                lista.Add(jogo);
            }

            jogo.preco = preco;
            jogo.tempoJogado = tempoJogado;
            jogo.imagem = pictureBox.Image;
            Close();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            lista.RemoveAt(indice);
            Close();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Arquivos de Imagem | *.jpg; *.png";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap imagem = new Bitmap(fileDialog.FileName);
                pictureBox.Image = imagem;
            }
        }
    }
}

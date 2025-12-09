namespace ProjetoA3
{
    public partial class Principal : Form
    {
        List<ListaJogos> lista = new List<ListaJogos>();

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            lista.Add(new ListaJogos("The Last of Us"));
            lista.Add(new ListaJogos("God of War"));
            lista.Add(new ListaJogos("Horizon Zero Dawn"));
            lista.Add(new ListaJogos("Call of Duty"));
            lista.Add(new ListaJogos("Assassin's Creed"));
            lista.Add(new ListaJogos("Red Dead Redemption 2"));

            AtualizarLista();

        }

        void AtualizarLista()
        {
            listView.Items.Clear();
            foreach (var item in lista)
            {
                listView.Items.Add(new ListViewItem(item.nome));
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro(lista);
            cadastro.ShowDialog();
            AtualizarLista();
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = listView.SelectedIndices[0];
            Cadastro cadastro = new Cadastro(lista, indice);
            cadastro.ShowDialog();
            AtualizarLista();
        }
    }
}

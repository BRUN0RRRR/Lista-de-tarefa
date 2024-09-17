namespace Lista_de_tarefa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Botão para adicionar tarefa
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ent_tarefa.Text))
            {
                // Adiciona o texto da TextBox na ListBox
                lista.Items.Add(ent_tarefa.Text);
                // Limpa a TextBox após adicionar
                ent_tarefa.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, insira uma tarefa válida.");
            }
        }

        // Botão para remover tarefa
        private void button2_Click(object sender, EventArgs e)
        {
            if (lista.SelectedIndex != -1)
            {
                // Remove o item selecionado
                lista.Items.RemoveAt(lista.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Selecione uma tarefa para remover.");
            }
        }

        // Botão para limpar a lista de tarefas
        private void button3_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
        }

        // Botão para editar tarefa
        private void btneditar_Click(object sender, EventArgs e)
        {
            if (lista.SelectedIndex != -1)
            {
                if (!string.IsNullOrWhiteSpace(ent_tarefa.Text))
                {
                    // Atualiza o item selecionado com o novo texto
                    lista.Items[lista.SelectedIndex] = ent_tarefa.Text;
                    ent_tarefa.Clear();
                }
                else
                {
                    MessageBox.Show("Por favor, insira uma tarefa válida para editar.");
                }
            }
            else
            {
                MessageBox.Show("Selecione uma tarefa para editar.");
            }
        }
    }
}

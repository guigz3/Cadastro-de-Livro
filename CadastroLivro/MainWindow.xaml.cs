using System.Windows;
using CadastroLivro.Data;
using CadastroLivro.Models;

namespace CadastroLivro
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            var livro = new Livro
            {
                Titulo = TxtTitulo.Text,
                Autor = TxtAutor.Text
            };

            using (var db = new AppDbContext())
            {
                db.Livros.Add(livro);
                db.SaveChanges();
            }

            TxtMensagem.Text = "Livro salvo com sucesso!";
            TxtTitulo.Clear();
            TxtAutor.Clear();
        }
    }
}
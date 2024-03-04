public class LibraryItem
{
    public string Title { get; set; }
    public string Author { get; set; }
    // Mais propriedades relacionadas a livros, DVDs, revistas, etc.
    
    public void AddNewItem(string title, string author)
    {
       // Adicionar novo Livro - viola SRP
    }

    // adicionar - Método para mostrar Livro
}
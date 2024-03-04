### Criar um Sistema de Gestão de Bibliotecas
Vamos criar um sistema de gestão de livros, que depois permite que sejam também Revistas, DVDs, etc.

## 1. Criar, Revista, DVD que implementam (ou extendem) o LibraryItem (ou ILibraryItem)

## 2. Criar uma Classe de Manutenção de Livros:
- Esta classe deve ser responsável por adicionar, remover e atualizar livros no inventário da biblioteca.
- Garantir que esta classe adira ao SRP, focando-se exclusivamente nas tarefas de manutenção de livros.

## 3. Criar uma Classe Autor e uma Classe de Gestão de Autores:
- A classe Autor deve conter propriedades como Nome, Biografia e uma Lista de Livros.
- A classe de Gestão de Autores deve tratar de adicionar, atualizar e eliminar autores, aderindo ao SRP.

## 4. Modificar a classe Livro para incluir uma propriedade Autor.
- Atualizar a classe de Manutenção de Livros para garantir que, quando um livro é adicionado ou atualizado, o autor correspondente é vinculado a este livro.

## 5. Adicionar funcionalidade para gerir diferentes tipos de contribuidores da biblioteca
- Por exemplo, Editores, Ilustradores. Usar o OCP para garantir que estes novos tipos possam ser adicionados sem modificar as classes de gestão existentes.

## 6. Estender a classe LibraryDisplay para incluir opções de exibição mais sofisticadas
- Por exemplo filtragem por autor, tipo de item, etc. Considerar como desenhar esta extensão para cumprir com o SRP e OCP.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace books_manager.Books
{
    public class BooksService
    {
        private List<Book> _books;

        public BooksService()
        {
            _books = new List<Book>();
            LoadData();
        }

        private void LoadData()
        {
            Book Book1 = new Book(1, "Vazul", 2, 150, 250, true);
            Book Book2 = new Book(2, "Sfarsitul Vietii", 5, 300, 500, false);
            Book Book3 = new Book(3, "Culegere Mate", 1, 235, 150, true);
            Book Book4 = new Book(4, "Dictionar engleza", 1, 500, 500, false);
            Book Book5 = new Book(5, "Povestiri Din Folclorul Maghiar", 7, 100, 50, true);

            _books.Add(Book1);
            _books.Add(Book2);
            _books.Add(Book3);
            _books.Add(Book4);
            _books.Add(Book5);
        }

        public void AfisareBooks()
        {
            foreach (Book x in _books)
            {
                Console.WriteLine(x.BooksInfo());
            }
        }

        public List<Book> FindAllBooksByIds(List<int> bookIds)
        {
            List<Book> filteredBooks= new List<Book>();

            for(int i = 0; i < _books.Count; i++)
            {
                if (bookIds.Contains(_books[i].Id))
                {
                    filteredBooks.Add(_books[i]);
                }
                
            }

            return filteredBooks;
        }

        public void ShowAllBooksAvailable()
        {
            foreach(Book x in _books)
            {
                if (x.Disponibila == true)
                {
                    Console.WriteLine(x.BooksInfo());
                }
            }
        }

        public Book FindBookById(int idBook)
        {
            foreach (Book x in _books)
            {
                if(x.Id == idBook)
                {
                    return x;                
                }
            }
            return null;
        }
      
        public void DeleteBook(int idBook)
        {
            Book book = FindBookById(idBook);
            _books.Remove(book);
        }

        public void AddBook(Book book6)
        {
            _books.Add(book6);
        }
    }
}

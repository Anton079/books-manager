using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace books_manager
{
    public class BooksService
    {
        private List<Book> _Books;

        public BooksService()
        {
            _Books = new List<Book>();
            this.LoadData();
        }

        public void LoadData()
        {
            Book Book1 = new Book(1,"Vazul", 2, 150, 250, true);
            Book Book2 = new Book(2, "Sfarsitul Vietii", 5, 300, 500, false);
            Book Book3 = new Book(3, "Culegere Mate", 1, 235, 150, true);
            Book Book4 = new Book(4, "Dictionar engleza", 1, 500, 500, false);
            Book Book5 = new Book(5, "Povestiri Din Folclorul Maghiar", 7, 100, 50, true);

            this._Books.Add(Book1);
            this._Books.Add(Book2);
            this._Books.Add(Book3);
            this._Books.Add(Book4);
            this._Books.Add(Book5);
        }

        public void AfisareBooks()
        {
            foreach(Book x in _Books)
            {
                Console.WriteLine(x.BooksInfo());
            }
        }
    }
}

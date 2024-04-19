using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace books_manager.Books
{
    public class Book
    {
        private int _id;
        private string _modelCarte;
        private int _volumul;
        private int _pagini;
        private int _greutate;
        private bool _disponibila;

        public Book(int id, string modeleCarte, int volumul, int pagini, int greutate, bool disponibila)
        {
            _id = id;
            _modelCarte = modeleCarte;
            _volumul = volumul;
            _pagini = pagini;
            _greutate = greutate;
            _disponibila = disponibila;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string ModelCarte
        {
            get { return _modelCarte; }
            set { _modelCarte = value; }
        }

        public int Volumul
        {
            get { return _volumul; }
            set { _volumul = value; }
        }

        public int Pagini
        {
            get { return _pagini; }
            set { _pagini = value; }
        }

        public int Greutate
        {
            get { return _greutate; }
            set { _greutate = value; }
        }

        public bool Disponibila
        {
            get { return _disponibila; }
            set { _disponibila = value; }
        }

        public string BooksInfo()
        {
            string text = " ";
            text += "Id Book " + Id + "\n";
            text += "Model de carte " + ModelCarte + "\n";
            text += "Volumul cartii " + Volumul + "\n";
            text += "Pagini " + Pagini + "\n";
            text += "Greutatea " + Greutate + "\n";
            text += "Disponibila " + Disponibila + "\n";
            return text;
        }
    }
}

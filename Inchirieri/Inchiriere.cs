using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace books_manager.Inchirieri
{
    public class Inchiriere
    {
        // id idUser idBook
        private int _id;
        private int _idUser;
        private int _idBook;

        public Inchiriere(int id, int idUser, int idBook)
        {
            _id = id;
            _idUser = idUser;
            _idBook = idBook;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int IdUser
        {
            get { return _idUser; }
            set { _idUser = value; }
        }

        public int IdBook
        {
            get { return _idBook; }
            set { _idBook = value; }
        }

        public string InchiriereInfo()
        {
            string text = " ";
            text += "Idul" + Id + "\n";
            text += "Idul User " + IdUser + "\n";
            text += "Id Book" + IdBook + "\n";
            return text;
        }

    }
}

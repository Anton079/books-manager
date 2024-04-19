using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using books_manager.Books;
using books_manager.Inchirieri;

namespace books_manager
{
    public class View
    {
        private User _user;
        private BooksService _booksService;
        private InchiriereService _inchiriereService;

        //todo:1->a vedea istoricul inchirierilor
        //2--> afisa cartile dsiponibile
        //3--> cautarea de carti




        public View()
        {
            _user = new User(2, "andrei@gmail.com", "fewgfweg", 07457541);
            _booksService = new BooksService();
            _inchiriereService = new InchiriereService();
        }

        public void Meniu()
        {
            Console.WriteLine("Apasati tasta 1 pentru a afisa toate cartile din biblioteca");
            Console.WriteLine("Apasati tasta 2 pentru a afisa toate cartile disponibile din biblioteca");
            Console.WriteLine("Apasati tasta 3 pentru a afisa  istoricul unui user");
            Console.WriteLine("Apasati tasta 4 pentru a inchiria o carte");
            Console.WriteLine("Apasati tasta 5 pentru a edita o carte");
            Console.WriteLine("Apasati tasta 6 pentru a sterge o carte din biblioteca");
            Console.WriteLine("Apasati tasta 7 pentru a adauga o carte in biblioteca");

        }

        public void play()
        {
            bool running = true;
            while(running)
            {
                Meniu();
                string alegere = Console.ReadLine();

                switch(alegere)
                {
                    case "1":
                        _booksService.AfisareBooks();
                        break;

                    case "2":
                        _booksService.ShowAllBooksAvailable();
                        break;

                    case "3":
                        AfisareIstoricInchirieriByIdUser();
                        break;


                    case "4":
                        InchiriereCarte();
                        break;     
                        
                    case "5":
                        EditBook();
                        break;

                    case "6":
                        RemoveBookFromBiblioteca();
                        break;

                    case "7":
                        AddBookInBiblioteca();
                        break;

                }
            }
        }

        public void AfisareIstoricInchirieriByIdUser()
        {           
            List<int> idBooks = _inchiriereService.FiltrareInchirieriByUser(_user.Id);

            
            List<Book> BooksById = _booksService.FindAllBooksByIds(idBooks);
            for (int i = 0; i < BooksById.Count; i++)
            {
                Console.WriteLine(BooksById[i].BooksInfo());
            }
        }

        public void InchiriereCarte()
        {
            Console.WriteLine("Introduceti id cartii ce doriti sa o inchiriati");
            int idCarte = Int32.Parse(Console.ReadLine());

            Book book = _booksService.FindBookById(idCarte);

            if (book != null && book.Disponibila)
            {

                Inchiriere inchiriere = new Inchiriere(_inchiriereService.GenerateId(), this._user.Id, book.Id);


                this._inchiriereService.AddInchiriere(inchiriere);
     
                book.Disponibila = false;
                Console.WriteLine("Cartea a fost inchiriata cu succes");

            }
            else if(book == null)
            {
                Console.WriteLine("Cartea nu exita");
            }
            else  if(!book.Disponibila)
            {
                Console.WriteLine("Cartea nu este disponibila");
            }
        }

        public void EditBook()
        {
            Console.WriteLine("Introduce-ti id-ul cartii pe care o modificati (1-5)");
            int carteAleasa = Int32.Parse(Console.ReadLine());

            Book book = _booksService.FindBookById(carteAleasa);
            if ( book!= null)
            {
                Console.WriteLine("Ce vrei sa editezi din carte dintre  model, volumul, pagini, greutate");
                string editAles = Console.ReadLine();

                switch (editAles.ToLower())
                {
                    case "model":

                        Console.WriteLine("introduceti noul model");
                        string modelNou = Console.ReadLine();
                        book.ModelCarte = modelNou;
                        break;

                    case "volum":
                        Console.WriteLine("introduceti noul volum");
                        int volumNou = Int32.Parse(Console.ReadLine());

                        Console.ReadLine();
                        break;

                    case "pagini":
                        Console.WriteLine("introduceti nr de pagini");
                        int paginiNou = Int32.Parse(Console.ReadLine());

                        Console.ReadLine();
                        break;

                    case "greutate":
                        Console.WriteLine("introduceti noua greutate");
                        int greutate = Int32.Parse(Console.ReadLine());

                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Optiunea aleasa nu este valida.");
                        break;
                }

                //if( editAles.Equals("model" )) {
                //    Console.WriteLine("introduceti noul model");
                //    string modelNou = Console.ReadLine();
                //    book.ModelCarte = modelNou;
                //}

                //if(editAles.Equals("volumul"))  {
                //    Console.WriteLine("introduceti noul volum");
                //    int volumNou = Int32.Parse(Console.ReadLine());
                //    book.Volumul = volumNou;
                //}

                //if (editAles.Equals("pagini"))
                //{
                //    Console.WriteLine("introduceti noul nr de pagini");
                //    int paginiNou = Int32.Parse(Console.ReadLine());
                //    book.Pagini = paginiNou;
                //}

                //if (editAles.Equals("greutate"))
                //{
                //    Console.WriteLine("introduceti noua greutate");
                //    int greutateNou = Int32.Parse(Console.ReadLine());
                //    book.Greutate = greutateNou;
                //}

                Console.WriteLine("S-a editat cartea!");

            }



            
            
        }
        
        public void RemoveBookFromBiblioteca()
        {
            Console.WriteLine("Ce carte vrei sa stergi?");
            int alegereBook = Int32.Parse(Console.ReadLine());

            Book book = _booksService.FindBookById(alegereBook);

            if (book != null)
            {
                if (book.Disponibila == true)
                {

                    _booksService.DeleteBook(book.Id);
                    Console.WriteLine("Cartea a fost stearsa cu succes!");
                }
                else
                {
                    Console.WriteLine("Cartea nu poate fi stearsa pentru ca nu este disponibila");
                }
            }
            else
            {
                Console.WriteLine("Id ul cartii nu a fost gasit sau nu exista!");
            }
        }

        public void AddBookInBiblioteca()
        {
            int idGeneratNou = _inchiriereService.GenerateId();

            Console.WriteLine("Ce model de carte o sa fie");
            string modelCarteNou = Console.ReadLine();

            Console.WriteLine("Ce volum o sa fie cartea");
            int volumCarteNou = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Cate pagini o sa aiba cartea");
            int paginiCarteNou = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Ce greutate o sa aiba cartea");
            int greutateCarteNou = Int32.Parse(Console.ReadLine());

            bool disponibilitateCarteNou = true;

            Book book6 = new Book(idGeneratNou, modelCarteNou, volumCarteNou, paginiCarteNou, greutateCarteNou, disponibilitateCarteNou);

            _booksService.AddBook(book6);
           
        }

    }
}

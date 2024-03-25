using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace books_manager
{
    public class UserService
    {
        private List<User> _UserS;

        public UserService()
        {
            _UserS = new List<User>();
            this.LoadData();
        }

        public void LoadData()
        {
            User User1 = new User("1", "andrei@gmail.com", "fewgfweg", 07457541);
            User User2 = new User("2", "mihai@gmail.com", "yun", 074124912);
            User User3 = new User("3", "mihai@gmail.com", "gtrhr", 07452352);
            User User4 = new User("4", "antonio@gmail.com", "fwefw", 07453252);
            User User5 = new User("5", "Raul@gmail.com", "liulfngfn", 0746546542);

            this._UserS.Add(User1);
            this._UserS.Add(User2);
            this._UserS.Add(User3);
            this._UserS.Add(User4);
            this._UserS.Add(User5);
        }

        public void AfisareUser()
        {
            foreach(User x in _UserS)
            {
                Console.WriteLine(x.UserInfo());
            }
        }
    }
}

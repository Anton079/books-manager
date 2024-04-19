using books_manager;
using books_manager.Books;

internal class Program
{
    private static void Main(string[] args)
    {

        UserService userService = new UserService();

        userService.AfisareUser();

        

    }
}
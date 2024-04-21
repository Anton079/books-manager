using books_manager;
using books_manager.Books;

internal class Program
{
    private static void Main(string[] args)
    {

        UserService userService = new UserService();

        User UserTest = new User(6, "RamusAta@gmail.com", "fgerhgre", 07364363);

        userService.AddUser(UserTest);


        userService.SaveData();

    }
}
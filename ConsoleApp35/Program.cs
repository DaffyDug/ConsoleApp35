using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Central_Account menu = new Central_Account(null, null);
        Dictionary<string, string> LoginAndPassword = new Dictionary<string, string>();
        while (true)
        {
            menu.Central_Menu();
            string intvalue = Console.ReadLine();
            if (intvalue == "1")
            {
                menu.Create_LoginAndPassword(LoginAndPassword);
            }
            if (intvalue == "2")
            {

                Console.WriteLine("введите логин: ");
                string login = Console.ReadLine();
                Console.WriteLine("введите пароль: ");
                string password = Console.ReadLine();
                if (LoginAndPassword.ContainsKey(login) == true)
                {
                    if (LoginAndPassword.ContainsValue(password) == true)
                    {

                        menu.Acount_Menu(LoginAndPassword);
                    }
                }
            }
        }
    }
}
class Menu
{
    public void Central_Menu()
    {
        Console.WriteLine("1. создать логин");
        Console.WriteLine("2. вход в акаунт");
        Console.WriteLine("3. ввести инфу о юзерах");
    }
}
class Users : Menu
{
    private string _userLogin;
    private string _userPassword;
    public Users(string userlogin, string userpassword)
    {
        _userLogin = userlogin;
        _userPassword = userpassword;
    }
    public void Create_LoginAndPassword(Dictionary<string, string> LoginAndPassword)
    {
        Console.WriteLine("введите логин: ");
        string Login = Console.ReadLine();
        Console.WriteLine("введите пароль: ");
        string Password = Console.ReadLine();
        _userLogin = Login;
        _userPassword = Password;
        LoginAndPassword.Add(_userLogin, _userPassword);
    }
    public void Check_LoginAndPassword(Dictionary<string, string> LoginAndPassword)
    {
        try
        {
            LoginAndPassword[_userLogin] = null;
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("ошибка, нету созданных пользователей");
        }
    }
}

class Central_Account : Users
{
    public string _userLogin;
    public string _userPassword;

    public Central_Account(string userlogin, string userpassword) : base(userlogin, userpassword)
    {
        _userLogin = userlogin;
        _userPassword = userpassword;
    }

    public void menu()
    {
        Console.WriteLine("1. выйти из акаунта");
        Console.WriteLine("2. удалить задачу");
        Console.WriteLine("3. добавить задачу");
        Console.WriteLine("4. показать все задачи");
    }

    public void Acount_Menu(Dictionary<string, string> LoginAndPassword)
    {
        Users users = new Users(null, null);

        while (true)
        {
            menu();
            string intvalue = Console.ReadLine();
            if (intvalue == "1")
            {
                break;
            }
            else if (intvalue == "2")
            {

            }
            else if (intvalue == "3")
            {

            }
            else if (intvalue == "4")
            {




            }
        }
    }
//    public void Notes(Dictionary<string, List<NotesEx>> array1, Users users)
//    {

//        var asdf = Dictionary<string, List<NotesEx>> array = new Dictionary<string, List<NotesEx>>();
//        asdf.Add(users._userLogin, NotesEx);
//        array.Add(array1);
//    }
//}

//public class NotesEx
//{
//    private string name;
//    private string description;
//    private DateTime dateTime;
//}


using System.Runtime.CompilerServices;

internal class User
{
    private string _username;
    private string _password;

    public string UserName
    {
        get
        {
            return _username;
        }
        set
        {
            _username = value;
        }
    }

    public string Password
    {
        get { return _password; }
        set
        {
            if(CheckPassword(value)==true)
            {
                _password = value;
            }
        }
    } 
    public User(string password,string username)
    {
        this.Password = password;
        this.UserName = username;
    }
    public bool CheckPassword(string Password)
    {
        bool status=false;
        if(Password.Length>7 && Password.Any(char.IsUpper))
        {
            status = true;
        }
        else
        {
            Console.WriteLine("The password must contain 8 characters,digits and Uppercase character");
        }
        return status;

    }

}
 



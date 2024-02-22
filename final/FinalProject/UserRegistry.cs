public class UserRegistry
{
    private Dictionary<string, User> _usernameRegistry;
    private Dictionary<string, User> _emailRegistry;

    public UserRegistry()
    {
        _usernameRegistry = new Dictionary<string, User>();
        _emailRegistry = new Dictionary<string, User>();
    }

    public bool IsUsernameTaken(string username)
    {
        return _usernameRegistry.ContainsKey(username);
    }

    public bool IsEmailTaken(string email)
    {
        return _emailRegistry.ContainsKey(email);
    }

    public bool RegisterUser(User user)
    {
        if (IsUsernameTaken(user._userName))
        {
            Console.WriteLine("The username is already in use.");
            return false;
        }

        if (IsEmailTaken(user._email))
        {
            Console.WriteLine("Email is already in use.");
            return false;
        }

        _usernameRegistry.Add(user._userName, user);
        _emailRegistry.Add(user._email, user);
        Console.WriteLine("Username succesfully registered!!");
        return true;
    }
}
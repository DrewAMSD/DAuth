namespace DAuth;

public class Authenticator
{
    private static readonly string _validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!?$@#%&";
    private static readonly Random _rand = new Random();

    public static string getValidChars()
    {
        return _validChars;
    }

    public static string GenerateRandomPassword()
    {
        string password = "";
        int passwordLength = 12;

        for (int i = 0; i < passwordLength; i++)
        {
            int randomIndex = _rand.Next(_validChars.Length);
            password += _validChars[randomIndex];
        }

        return password;
    }
}
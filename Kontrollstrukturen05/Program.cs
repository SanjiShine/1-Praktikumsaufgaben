namespace Kontrollstrukturen05;

class Program
{

    static bool PasswordValidation(string password)
    {
        int nZiffer = 0;

        if (password.Length < 8)
        {
            return false;

        } else { 

            for (int i = 0; i < password.Length; i++)
            {
                char c = password[i];

                if (c < 'A' && c > 'Z' || c > 'a' && c > 'z' || c < '0' && c > '9')
                {
                    return false;
                }

                if (c >= '0' && c <= '9')
                {
                    nZiffer++;
                }
            }

            if (nZiffer < 3)
            {
                return false;
            }
        }

        return true;
      
    }

    static void Main(string[] args)
    {
        string password;

        do
        {
            Console.Write("Geben Sie Ihre Passwort bitte ein: ");
            password = Console.ReadLine();

            if (!PasswordValidation(password))
            {
                Console.WriteLine("Ungültiges Passwort!\n");
            }

        } while (!PasswordValidation(password));

            Console.WriteLine("Gültiges Passwort!");

    }
}

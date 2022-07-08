var isStrongPassword = false;
var possibleChars = new List<char>{'!', '@', '#', '$', '%', '^', '&', '*', '(', ')'};

while (!isStrongPassword)
{
    Console.WriteLine("test");
    Console.Write("Wprowadź hasło: ");
    var password = Console.ReadLine();
    var isPasswordContainsSpecialChar = password.Any(x => possibleChars.Contains(x));
    
    if (!password.Any(char.IsUpper))
    {
        Console.WriteLine("Nowe hasło musi zawierać przynajmniej 1 wielką literę!");
    }
    else if (!password.Any(char.IsDigit))
    {
        Console.WriteLine("Nowe hasło musi zawierać przynajmniej 1 cyfrę!");
    }
    else if (password.Trim().Length < 6)
    {
        Console.WriteLine("Nowe hasło musi zawierać przynajmniej 6 znaków!");
    }
    else if (!isPasswordContainsSpecialChar)
    {
        Console.WriteLine("Nowe hasło musi zawierać przynajmniej 1 znak specjalny!");
    }
    else
    {
        Console.WriteLine("Silne hasło");
        isStrongPassword = true;
    }
}



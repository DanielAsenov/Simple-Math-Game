var date = DateTime.Now;
string name = GetName();

Menu(name);

string GetName()
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Please enter your name:");
    var name = Console.ReadLine();
    return name;
}

void Menu(string name)
{
    Console.Clear();

    Console.ForegroundColor = ConsoleColor.Green;

    Console.WriteLine("==================================");
    Console.WriteLine($"        Welcome {name}");
    Console.WriteLine($"        {DateTime.Now}");
    Console.WriteLine("==================================");

    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("==================================");
    Console.WriteLine("        MATH GAME MENU");
    Console.WriteLine("==================================");
    Console.ResetColor();

    Console.WriteLine();

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine($@"A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit");
    Console.WriteLine();
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Choose an option: ");
    Console.ResetColor();




    var gameSelected = Console.ReadLine();

    switch (gameSelected.Trim().ToLower())
    {
        case "a":
            AdditionGame("Addition game");
            break;
        case "s":
            SubtractionGame("Subtraction game");
            break;
        case "m":
            MultiplicationGame("Multiplication game");
            break;
        case "d":
            DivisionGame("Division game");
            break;
        case "q":
            Console.WriteLine("Goodbye.");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid input.");
            Environment.Exit(0);
            break;
    }
}


void AdditionGame(string message)
{
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(message);

    var random = new Random();
    int score = 0;
    int tries = 5;

    int firstNumber;
    int secondNumber;


    for (int i = 0; i < 10; i++)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(message);


        firstNumber = random.Next(1, 15);
        secondNumber = random.Next(1, 15);

        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"{firstNumber} + {secondNumber}");

        var answer = Console.ReadLine();


        if (int.TryParse(answer, out int userAnswer))
        {
            if (userAnswer == firstNumber + secondNumber)
            {
                score++;
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct answer.");
            }
            else
            {
                tries--;

                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Incorrect answer. {tries} tries left.");

                if (tries == 0)
                {
                    Console.Clear();
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Game Over. {name}, your final score is {score}");
                    Console.WriteLine("Press Any Key to exit...");
                    Console.ReadLine();
                    break;
                }
            }
        }
        else
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please enter a valid number.");
        }

        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();

        if (i == 9)
        {
            Console.Clear();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Game Over. {name}, your final score is: {score}.");
            Console.WriteLine("Press Any Key to exit...");
            Console.ReadLine();
        }

    }
}

void SubtractionGame(string message)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(message);

    var random = new Random();
    int score = 0;
    int tries = 5;

    int firstNumber;
    int secondNumber;


    for (int i = 0; i < 10; i++)
    {
        Console.Clear();
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(message);


        firstNumber = random.Next(1, 15);
        secondNumber = random.Next(1, 15);

        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"{firstNumber} - {secondNumber}");

        var answer = Console.ReadLine();

        if (int.TryParse(answer, out int userAnswer))
        {
            if (userAnswer == firstNumber - secondNumber)
            {
                score++;
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct answer.");
            }
            else
            {
                tries--;
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Incorrect answer. {tries} tries left.");

                if (tries == 0)
                {
                    Console.Clear();
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Game Over. {name}, your final score is {score}");
                    Console.WriteLine("Press Any Key to exit...");
                    Console.ReadLine();
                    break;
                }
            }
        }
        else
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please enter a valid number.");
        }

        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();

        if (i == 9)
        {
            Console.Clear();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Game Over. {name}, your final score is: {score}.");
            Console.WriteLine("Press Any Key to exit...");
            Console.ReadLine();
        }

    }
}

void MultiplicationGame(string message)
{
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(message);

    var random = new Random();
    int score = 0;
    int tries = 5;

    int firstNumber;
    int secondNumber;


    for (int i = 0; i < 10; i++)
    {
        Console.Clear();
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(message);


        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"{firstNumber} * {secondNumber}");

        var answer = Console.ReadLine();

        if (int.TryParse(answer, out int userAnswer))
        {
            if (userAnswer == firstNumber * secondNumber)
            {
                score++;
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct answer.");
            }
            else
            {
                tries--;
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Incorrect answer. {tries} tries left.");

                if (tries == 0)
                {
                    Console.Clear();
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Game Over. {name}, your final score is {score}");
                    Console.WriteLine("Press Any Key to exit...");
                    Console.ReadLine();
                    break;
                }
            }
        }
        else
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please enter a valid number.");
        }

        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();

        if (i == 9)
        {
            Console.Clear();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Game Over. {name}, your final score is: {score}.");
            Console.WriteLine("Press Any Key to exit...");
            Console.ReadLine();
        }
    }
}

void DivisionGame(string message)
{
    int score = 0;
    int tries = 5;

    for (int i = 0; i < 10; i++)
    {
        Console.Clear();
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(message);

        var divisionNumbers = GetDivisionNumbers();
        var firstNumber = divisionNumbers[0];
        var secondNumber = divisionNumbers[1];

        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"{firstNumber} / {secondNumber}");
        var answer = Console.ReadLine();

        if (int.TryParse(answer, out int userAnswer))
        {
            if (userAnswer == firstNumber / secondNumber)
            {
                score++;
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct answer.");
            }
            else
            {
                tries--;
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Incorrect answer. {tries} tries left.");

                if (tries == 0)
                {
                    Console.Clear();
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Game Over. {name}, your final score is {score}");
                    Console.WriteLine("Press Any Key to exit...");
                    Console.ReadLine();
                    break;
                }
            }
        }
        else
        {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please enter a valid number.");
        }

        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();

        if (i == 9)
        {
            Console.Clear();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Game Over. {name}, your final score is: {score}.");
            Console.WriteLine("Press Any Key to exit...");
            Console.ReadLine();
        }
    }
}

int[] GetDivisionNumbers()
{
    var random = new Random();
    var firstNumber = random.Next(1, 25);
    var secondNumber = random.Next(1, 25);

    var result = new int[2];

    while (firstNumber % secondNumber != 0)
    {
        firstNumber = random.Next(1, 25);
        secondNumber = random.Next(1, 25);
    }

    result[0] = firstNumber;
    result[1] = secondNumber;

    return result;
}
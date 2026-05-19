var date = DateTime.Now;
string name = GetName();

Menu(name);

string GetName()
{
    Console.WriteLine("Please enter your name:");
    var name = Console.ReadLine();
    return name;
}

void Menu(string name)
{
    Console.Clear();

    Console.WriteLine($"Hello {name}. It's {date}. This is your math's game.");
    Console.WriteLine(@$"What game would you like to play today? Choose from the options below:
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the program");



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
    Console.WriteLine(message);

    var random = new Random();
    int score = 0;
    int tries = 5;

    int firstNumber;
    int secondNumber;


    for (int i = 0; i < 10; i++)
    {
        Console.Clear();
        Console.WriteLine(message);


        firstNumber = random.Next(1, 15);
        secondNumber = random.Next(1, 15);

        Console.WriteLine($"{firstNumber} + {secondNumber}");

        var answer = Console.ReadLine();


        if (int.TryParse(answer, out int userAnswer))
        {
            if (userAnswer == firstNumber + secondNumber)
            {
                score++;
                Console.WriteLine("Correct answer.");
            }
            else
            {
                tries--;

                Console.WriteLine($"Incorrect answer. {tries} tries left.");

                if (tries == 0)
                {
                    Console.Clear();
                    Console.WriteLine($"Game Over. {name}, your final score is {score}");
                    Console.WriteLine("Press Any Key to exit...");
                    Console.ReadLine();
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid number.");
        }

        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();

        if (i == 9)
        {
            Console.Clear();
            Console.WriteLine($"Game Over. {name}, your final score is: {score}.");
            Console.WriteLine("Press Any Key to exit...");
            Console.ReadLine();
        }

    }
}

void SubtractionGame(string message)
{
    Console.WriteLine(message);

    var random = new Random();
    int score = 0;
    int tries = 5;

    int firstNumber;
    int secondNumber;


    for (int i = 0; i < 10; i++)
    {
        Console.Clear();
        Console.WriteLine(message);


        firstNumber = random.Next(1, 15);
        secondNumber = random.Next(1, 15);

        Console.WriteLine($"{firstNumber} - {secondNumber}");

        var answer = Console.ReadLine();

        if (int.TryParse(answer, out int userAnswer))
        {
            if (userAnswer == firstNumber - secondNumber)
            {
                score++;
                Console.WriteLine("Correct answer.");
            }
            else
            {
                tries--;

                Console.WriteLine($"Incorrect answer. {tries} tries left.");

                if (tries == 0)
                {
                    Console.Clear();
                    Console.WriteLine($"Game Over. {name}, your final score is {score}");
                    Console.WriteLine("Press Any Key to exit...");
                    Console.ReadLine();
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid number.");
        }

        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();

        if (i == 9)
        {
            Console.Clear();
            Console.WriteLine($"Game Over. {name}, your final score is: {score}.");
            Console.WriteLine("Press Any Key to exit...");
            Console.ReadLine();
        }

    }
}

void MultiplicationGame(string message)
{
    Console.WriteLine(message);

    var random = new Random();
    int score = 0;
    int tries = 5;

    int firstNumber;
    int secondNumber;


    for (int i = 0; i < 10; i++)
    {
        Console.Clear();
        Console.WriteLine(message);


        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} * {secondNumber}");

        var answer = Console.ReadLine();

        if (int.TryParse(answer, out int userAnswer))
        {
            if (userAnswer == firstNumber * secondNumber)
            {
                score++;
                Console.WriteLine("Correct answer.");
            }
            else
            {
                tries--;

                Console.WriteLine($"Incorrect answer. {tries} tries left.");

                if (tries == 0)
                {
                    Console.Clear();
                    Console.WriteLine($"Game Over. {name}, your final score is {score}");
                    Console.WriteLine("Press Any Key to exit...");
                    Console.ReadLine();
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid number.");
        }

        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();

        if (i == 9)
        {
            Console.Clear();
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
        Console.WriteLine(message);

        var divisionNumbers = GetDivisionNumbers();
        var firstNumber = divisionNumbers[0];
        var secondNumber = divisionNumbers[1];

        Console.WriteLine($"{firstNumber} / {secondNumber}");
        var answer = Console.ReadLine();

        if (int.TryParse(answer, out int userAnswer))
        {
            if (userAnswer == firstNumber / secondNumber)
            {
                score++;
                Console.WriteLine("Correct answer.");
            }
            else
            {
                tries--;

                Console.WriteLine($"Incorrect answer. {tries} tries left.");

                if (tries == 0)
                {
                    Console.Clear();
                    Console.WriteLine($"Game Over. {name}, your final score is {score}");
                    Console.WriteLine("Press Any Key to exit...");
                    Console.ReadLine();
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid number.");
        }

        Console.WriteLine("Press Enter to continue...");
        Console.ReadLine();

        if (i == 9)
        {
            Console.Clear();
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
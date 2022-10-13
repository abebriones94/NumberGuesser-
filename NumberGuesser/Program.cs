// Namespace, Main Class, and Entry Point Method

GetAppInfo(); // Run GetAppInfo Function to get info

GreetUser(); // Ask for user name and greet 

while(true) {


// Create a new Random Object 
Random random = new Random();

// Init correct number 
int correctNumber = random.Next(1, 11);

// Init Guess Var
int guess = 0;

// Ask user for number
Console.WriteLine("Guess a number between 1 and 10");

// While guess is not correct
while (guess != correctNumber)
{
    // Get user input
    string? input = Console.ReadLine();

    // Make sure its a number
    if (!int.TryParse(input, out guess))
    {

        // Print error message 
        PrintColorMessage(ConsoleColor.Red,"Please use an actual number");

        // Keep going 
        continue;
    }

    // Cast to int and put in guess
    guess = Int32.Parse(input);

    // Match guess to correct number
    if (guess != correctNumber)
    {
        PrintColorMessage(ConsoleColor.Red,"Wrong Number, please try again");
    }
}

// Output success message

PrintColorMessage(ConsoleColor.Yellow, "You are CORRECT! You guessed it!");


// Ask to play again
Console.WriteLine("Play again? [Y or N]");

// Get Answer
string answer = Console.ReadLine().ToUpper();

if (answer == "Y") {
    continue;
}
else if (answer == "N") {
    return;
}
else 
{
    return;
}

}

// Get and DISPLAY App Info 

static void GetAppInfo() {

    // Set App Vars
string appName = "Number Guesser";
string appVersion = "1.0.0";
string appAuthor = "Abe Briones";

// Change Text Color
Console.ForegroundColor = ConsoleColor.Green;

// Write Out App Info
Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

// Reset Text Color
Console.ResetColor();
}

// Ask user name AND greet 

static void GreetUser() {
    // Ask User Name
Console.WriteLine("What is your name?");

// Get User Input
string? inputName = Console.ReadLine();

Console.WriteLine("Hello {0}, let's play a game...", inputName);
}


// Print color message 

static void PrintColorMessage(ConsoleColor color, string message) {

            // Change Text Color
        Console.ForegroundColor = color;

        // Tell User Its NOT a number
        Console.WriteLine(message);

        // Reset Text Color
        Console.ResetColor();
}
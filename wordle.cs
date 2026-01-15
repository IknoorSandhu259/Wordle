using System;

string[] words = { "apple", "grape", "peach", "berry", "mango" };
Random rand = new Random();
string secret = words[rand.Next(words.Length)];

string guess;
int attempts = 6;

Console.WriteLine("Welcome to Wordle!");

while (attempts > 0) {
    Console.Write("\nEnter a 5-letter word: ");
    guess = Console.ReadLine().ToLower();

    if (guess.Length != 5) {
        Console.WriteLine("Word must be 5 letters.");
        continue;
    }

    for (int i = 0; i < 5; i++) {
        if (guess[i] == secret[i]) {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        else if (secret.Contains(guess[i])) {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        else {
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        Console.Write(guess[i]);
        Console.ResetColor();
    }

    Console.WriteLine();

    if (guess == secret) {
        Console.WriteLine("You guessed the word!");
        return;
    }

    attempts--;
    Console.WriteLine("Attempts left: " + attempts);
}

Console.WriteLine("\nGame over! The word was: " + secret);
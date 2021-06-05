using System;

namespace Hangman_Assignment
{
    class Program
    {
        static void Main(string[] args) // The main start of the program
        {
            StartGame();
            Console.ReadLine();
            Console.Clear();
            GenerateRandomWords();
        }

        static void RestartActualGame() // The method here is created to restart the game
        {
            Console.Clear();
            StartGame();
            Console.ReadLine();
            Console.Clear();
            GenerateRandomWords();
        }

        static void GenerateRandomWords() // method made for random word generator
        {
            Random rnd = new Random();
            int numOfWords = rnd.Next(1, 6); // it randomly generates ranging from 1-5, selecting a case for a specific word to guess

            switch (numOfWords)
            {
                case 1:
                    Word1();
                    break;
                case 2:
                    Word2();
                    break;
                case 3:
                    Word3();
                    break;
                case 4:
                    Word4();
                    break;
                case 5:
                    Word5();
                    break;
            }
        }

        static void StartGame() // this begins with the game rules
        {
            Console.WriteLine(" ***     Hangman The Game v0.01     *** ");
            Console.WriteLine(" ");
            Console.WriteLine("|| GAME RULES (READ VERY IMPORTANT) ||");
            Console.WriteLine("1) You have to guess a word by typing a letter");
            Console.WriteLine("2) If you guess all the letters right and know the word, then you have to type the FULL word in order to win");
            Console.WriteLine("3) You only have 8 lives");
            Console.WriteLine("4) If you guess the word with less than 8 mistakes, you win");
            Console.WriteLine("5) Or else with no lives left, you lose");
            Console.WriteLine("6) You get a hint whenever you lose a few lives");
            Console.WriteLine("7) Good luck!");
            Console.WriteLine("");
            Console.WriteLine("Press Enter key to begin");
        }

        static void RestartGame() // restart function for the user if they want to try the game again
        {
            Console.WriteLine("Do you want to play again? y / n"); 
            string restart;
            restart = Console.ReadLine();

            switch (restart)
            {
                case "y":
                    RestartActualGame();
                    break;
                case "Y": // user inputting either lowercase or uppercase "y" to restart the game
                    RestartActualGame();
                    break;
                case "n":
                    break;
                default:
                    break;
            }
        }

        static void Word1() // this method is the actual program of guessing the word and inputting letters
                            // (same goes for the other Word methods)
        {
            string secretWord = "secret"; // the word that the user has to guess
            string typing = ""; // user input
            char[] guess = new char[secretWord.Length];
            int liveCount = 9; // starting live
            int liveLimit = 0; // ending live
            bool fail = false;

            for (int dash = 0; dash < secretWord.Length; dash++) // to print out dashes
                guess[dash] = '-';

            while (typing != secretWord && !fail) // using while to repeat the code
            {
                switch (liveCount) // lives system, starts at 8 and decreases to 0 if wrong guesses
                {

                    case 0:
                        Console.WriteLine("");
                        break;
                    case 1:
                        Console.WriteLine("");
                        break;
                    case 2:
                        Console.WriteLine("");
                        break;
                    case 3:
                        Console.WriteLine("");
                        break;
                    case 4:
                        Console.WriteLine("(Hint: this word means keeping something hidden from someone else)");
                        break;
                    case 5:
                        Console.WriteLine("");
                        break;
                    case 6:
                        Console.WriteLine("");
                        break;
                    case 7:
                        Console.WriteLine("");
                        break;
                    case 8:
                        Console.WriteLine("");
                        break;
                }

                switch (typing) // to read the user input of letters
                {
                    case "s":

                        for (int i = 0; i < secretWord.Length; i++) /* this code will convert the dashes to letters 
                                                                     * when user input the right letter, it depends on the array */
                        {
                            guess[0] = secretWord[0];
                        }

                        break;
                    case "e":

                        for (int i = 0; i < secretWord.Length; i++)
                        {
                            guess[1] = secretWord[1];
                            guess[4] = secretWord[4];
                        }

                        break;
                    case "c":

                        for (int i = 0; i < secretWord.Length; i++)
                        {
                            guess[2] = secretWord[2];
                        }

                        break;
                    case "r":

                        for (int i = 0; i < secretWord.Length; i++)
                        {
                            guess[3] = secretWord[3];
                        }

                        break;
                    case "t":

                        for (int i = 0; i < secretWord.Length; i++)
                        {
                            guess[5] = secretWord[5];
                        }

                        break;

                    default:
                        liveCount--; // lives would decrease if user guesses the wrong letter
                        break;
                }

                if (liveCount > liveLimit) /* the liveCount starts at 8 and once it reaches equals to 0, 
                                            * it will set the bool fail to true */
                {
                    Console.WriteLine("Lives: {0}", liveCount); // displays number of lives
                    Console.WriteLine(guess); // prints dashes
                    Console.Write("Enter a letter: ");
                    typing = Console.ReadLine(); // reads user's input
                    Console.Clear();
                }
                else
                {
                    fail = true;
                }

                if (fail) // once the fail bool is set to true, it will display the losing message
                {
                    Console.WriteLine("Sorry! the word is {0}", secretWord);
                    Console.WriteLine("You lose!");
                    RestartGame();
                   
                }
                else if (typing == secretWord) // if the user guesses the word right, it will display a win message
                {
                    Console.WriteLine("Correct! The word is {0}", secretWord);
                    Console.WriteLine("You win!");
                    RestartGame();
                    
                }
            }
        }

        static void Word2()
        {
            string secretWord = "orange";
            string typing = "";
            char[] guess = new char[secretWord.Length];
            int liveCount = 9;
            int liveLimit = 0;
            bool fail = false;

            for (int dash = 0; dash < secretWord.Length; dash++)
                guess[dash] = '-';

            while (typing != secretWord && !fail)
            {
                switch (liveCount)
                {

                    case 0:
                        Console.WriteLine("");
                        break;
                    case 1:
                        Console.WriteLine("");
                        break;
                    case 2:
                        Console.WriteLine("");
                        break;
                    case 3:
                        Console.WriteLine("");
                        break;
                    case 4:
                        Console.WriteLine("(Hint: this word is a colour and a fruit)");
                        break;
                    case 5:
                        Console.WriteLine("");
                        break;
                    case 6:
                        Console.WriteLine("");
                        break;
                    case 7:
                        Console.WriteLine("");
                        break;
                    case 8:
                        Console.WriteLine("");
                        break;
                }

                switch (typing)
                {
                    case "o":

                        for (int i = 0; i < secretWord.Length; i++)
                        {
                            guess[0] = secretWord[0];
                        }

                        break;
                    case "r":

                        for (int i = 0; i < secretWord.Length; i++)
                        {
                            guess[1] = secretWord[1];                           
                        }

                        break;
                    case "a":

                        for (int i = 0; i < secretWord.Length; i++)
                        {
                            guess[2] = secretWord[2];
                        }

                        break;
                    case "n":

                        for (int i = 0; i < secretWord.Length; i++)
                        {
                            guess[3] = secretWord[3];
                        }

                        break;
                    case "g":

                        for (int i = 0; i < secretWord.Length; i++)
                        {
                            guess[4] = secretWord[4];
                        }

                        break;
                    case "e":

                        for (int i = 0; i < secretWord.Length; i++)
                        {
                            guess[5] = secretWord[5];
                        }

                        break;

                    default:
                        liveCount--;
                        break;
                }

                if (liveCount > liveLimit)
                {
                    Console.WriteLine("Lives: {0}", liveCount);
                    Console.WriteLine(guess);
                    Console.Write("Enter a letter: ");
                    typing = Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    fail = true;
                }

                if (fail)
                {
                    Console.WriteLine("Sorry! the word is {0}", secretWord);
                    Console.WriteLine("You lose!");
                    RestartGame();
                }
                else if (typing == secretWord)
                {
                    Console.WriteLine("Correct! The word is {0}", secretWord);
                    Console.WriteLine("You win!");
                    RestartGame();
                }
            }
        }
        static void Word3()
        {
            string secretWord = "kangaroo";
            string typing = "";
            char[] guess = new char[secretWord.Length];
            int liveCount = 9;
            int liveLimit = 0;
            bool fail = false;

            for (int dash = 0; dash < secretWord.Length; dash++)
                guess[dash] = '-';

            while (typing != secretWord && !fail)
            {
                switch (liveCount)
                {

                    case 0:
                        Console.WriteLine("");
                        break;
                    case 1:
                        Console.WriteLine("");
                        break;
                    case 2:
                        Console.WriteLine("");
                        break;
                    case 3:
                        Console.WriteLine("");
                        break;
                    case 4:
                        Console.WriteLine("(Hint: its an animal that jumps around)");
                        break;
                    case 5:
                        Console.WriteLine("");
                        break;
                    case 6:
                        Console.WriteLine("");
                        break;
                    case 7:
                        Console.WriteLine("");
                        break;
                    case 8:
                        Console.WriteLine("");
                        break;
                }

                switch (typing)
                {
                    case "k":

                        for (int i = 0; i < secretWord.Length; i++)
                        {
                            guess[0] = secretWord[0];
                        }

                        break;
                    case "a":

                        for (int i = 0; i < secretWord.Length; i++)
                        {
                            guess[1] = secretWord[1];
                            guess[4] = secretWord[4];
                        }

                        break;
                    case "n":

                        for (int i = 0; i < secretWord.Length; i++)
                        {
                            guess[2] = secretWord[2];
                        }

                        break;
                    case "g":

                        for (int i = 0; i < secretWord.Length; i++)
                        {
                            guess[3] = secretWord[3];
                        }

                        break;
                    case "r":

                        for (int i = 0; i < secretWord.Length; i++)
                        {
                            guess[5] = secretWord[5];
                        }

                        break;
                    case "o":

                        for (int i = 0; i < secretWord.Length; i++)
                        {
                            guess[6] = secretWord[6];
                            guess[7] = secretWord[7];
                        }

                        break;

                    default:
                        liveCount--;
                        break;
                }

                if (liveCount > liveLimit)
                {
                    Console.WriteLine("Lives: {0}", liveCount);
                    Console.WriteLine(guess);
                    Console.Write("Enter a letter: ");
                    typing = Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    fail = true;
                }

                if (fail)
                {
                    Console.WriteLine("Sorry! the word is {0}", secretWord);
                    Console.WriteLine("You lose!");
                    RestartGame();
                }
                else if (typing == secretWord)
                {
                    Console.WriteLine("Correct! The word is {0}", secretWord);
                    Console.WriteLine("You win!");
                    RestartGame();
                }
            }
        }
        static void Word4()
        {
            string secretWord = "pearl";
            string typing = "";
            char[] guess = new char[secretWord.Length];
            int liveCount = 9;
            int liveLimit = 0;
            bool fail = false;

            for (int dash = 0; dash < secretWord.Length; dash++)
                guess[dash] = '-';

            while (typing != secretWord && !fail)
            {
                switch (liveCount)
                {

                    case 0:
                        Console.WriteLine("");
                        break;
                    case 1:
                        Console.WriteLine("");
                        break;
                    case 2:
                        Console.WriteLine("");
                        break;
                    case 3:
                        Console.WriteLine("");
                        break;
                    case 4:
                        Console.WriteLine("(Hint: a shiny thing you found inside an oyster)");
                        break;
                    case 5:
                        Console.WriteLine("");
                        break;
                    case 6:
                        Console.WriteLine("");
                        break;
                    case 7:
                        Console.WriteLine("");
                        break;
                    case 8:
                        Console.WriteLine("");
                        break;
                }

                switch (typing)
                {
                    case "p":

                        for (int i = 0; i < secretWord.Length; i++)
                        {
                            guess[0] = secretWord[0];
                        }

                        break;
                    case "e":

                        for (int i = 0; i < secretWord.Length; i++)
                        {
                            guess[1] = secretWord[1];
                        }

                        break;
                    case "a":

                        for (int i = 0; i < secretWord.Length; i++)
                        {
                            guess[2] = secretWord[2];
                        }

                        break;
                    case "r":

                        for (int i = 0; i < secretWord.Length; i++)
                        {
                            guess[3] = secretWord[3];
                        }

                        break;
                    case "l":

                        for (int i = 0; i < secretWord.Length; i++)
                        {
                            guess[4] = secretWord[4];
                        }

                        break;
                  
                    default:
                        liveCount--;
                        break;
                }

                if (liveCount > liveLimit)
                {
                    Console.WriteLine("Lives: {0}", liveCount);
                    Console.WriteLine(guess);
                    Console.Write("Enter a letter: ");
                    typing = Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    fail = true;
                }

                if (fail)
                {
                    Console.WriteLine("Sorry! the word is {0}", secretWord);
                    Console.WriteLine("You lose!");
                    RestartGame();
                }
                else if (typing == secretWord)
                {
                    Console.WriteLine("Correct! The word is {0}", secretWord);
                    Console.WriteLine("You win!");
                    RestartGame();
                }
            }
        }
        static void Word5()
        {
            string secretWord = "umbrella";
            string typing = "";
            char[] guess = new char[secretWord.Length];
            int liveCount = 9;
            int liveLimit = 0;
            bool fail = false;

            for (int dash = 0; dash < secretWord.Length; dash++)
                guess[dash] = '-';

            while (typing != secretWord && !fail)
            {
                switch (liveCount)
                {

                    case 0:
                        Console.WriteLine("");
                        break;
                    case 1:
                        Console.WriteLine("");
                        break;
                    case 2:
                        Console.WriteLine("");
                        break;
                    case 3:
                        Console.WriteLine("");
                        break;
                    case 4:
                        Console.WriteLine("(Hint: its a portable device that covers to protect you from a rain or sunlight");
                        break;
                    case 5:
                        Console.WriteLine("");
                        break;
                    case 6:
                        Console.WriteLine("");
                        break;
                    case 7:
                        Console.WriteLine("");
                        break;
                    case 8:
                        Console.WriteLine("");
                        break;
                }

                switch (typing)
                {
                    case "u":

                        for (int i = 0; i < secretWord.Length; i++)
                        {
                            guess[0] = secretWord[0];
                        }

                        break;
                    case "m":

                        for (int i = 0; i < secretWord.Length; i++)
                        {
                            guess[1] = secretWord[1];
                        }

                        break;
                    case "b":

                        for (int i = 0; i < secretWord.Length; i++)
                        {
                            guess[2] = secretWord[2];
                        }

                        break;
                    case "r":

                        for (int i = 0; i < secretWord.Length; i++)
                        {
                            guess[3] = secretWord[3];
                        }

                        break;
                    case "e":

                        for (int i = 0; i < secretWord.Length; i++)
                        {
                            guess[4] = secretWord[4];
                        }

                        break;
                    case "l":

                        for (int i = 0; i < secretWord.Length; i++)
                        {
                            guess[5] = secretWord[5];
                            guess[6] = secretWord[6];
                        }

                        break;
                    case "a":

                        for (int i = 0; i < secretWord.Length; i++)
                        {
                            guess[7] = secretWord[7];
                        }

                        break;
                    default:
                        liveCount--;
                        break;
                }

                if (liveCount > liveLimit)
                {
                    Console.WriteLine("Lives: {0}", liveCount);
                    Console.WriteLine(guess);
                    Console.Write("Enter a letter: ");
                    typing = Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    fail = true;
                }

                if (fail)
                {
                    Console.WriteLine("Sorry! the word is {0}", secretWord);
                    Console.WriteLine("You lose!");
                    RestartGame();
                }
                else if (typing == secretWord)
                {
                    Console.WriteLine("Correct! The word is {0}", secretWord);
                    Console.WriteLine("You win!");
                    RestartGame();
                }
            }
        }
    }
}

using System;

namespace test.test
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "";
            bool converted = false;
            string done = "";
            static void morse()
            {
                char[] letters = { ' ', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
                string[] morseLetters = { "    ", ". ___", "___ . . .", "___ . ___ .", "___ . .", ".", ". . ___ .", "___ ___ .", ". . . .", ". .", ". ___ ___ ___", "___ . ___", ". ___ . .", "___ ___", "___ .", "___ ___ ___", ". ___ ___ .", "___ ___ . ___", ". ___ .", ". . .", "_", ". . ___", ". . . ___", ". ___ ___", "___ . . ___", "___ . ___ ___", "___ ___ . .", ". ___ ___ ___ ___", ". . ___ ___ ___", ". . . ___ ___", ". . . . ___", ". . . . .", "___ . . . .", "___ ___ . . .", "___ ___ ___ . .", "___ ___ ___ ___ .", "___ ___ ___ ___ ___" };
                string newText = "";
                Console.WriteLine("Enter text you want to change to Morse code");
                string? textToChange = Console.ReadLine();
                if (textToChange != null)
                {
                    Console.WriteLine("null");
                }

                textToChange = textToChange.ToLower();
                for (int textToChangeIndex = 0; textToChangeIndex < textToChange.Length; textToChangeIndex++)
                {
                    for (short letterIndex = 0; letterIndex < letters.Length; letterIndex++)
                    {
                        if (textToChange[textToChangeIndex] == letters[letterIndex])
                        {
                            newText += morseLetters[letterIndex];
                            newText += "   ";
                            break;
                        }
                    }
                }

                Console.WriteLine("Text in Morse Code");
                Console.WriteLine(newText);
                Console.ReadKey();
            }
            // binary converter function
            static void ban()
            {

                char[] letters = { ' ', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
                int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

                Console.WriteLine("enter text to be converted to binary");
                string convert = Console.ReadLine();
                string newText = "";
                for (int textToChangeIndex = 0; textToChangeIndex < convert.Length; textToChangeIndex++)
                {
                    for (short letterIndex = 0; letterIndex < letters.Length; letterIndex++)
                    {
                        if (convert[textToChangeIndex] == letters[letterIndex])
                        {
                            int number = numbers[letterIndex];
                            string numberAsString = Convert.ToString(number, 2);

                            newText += "0b" + numberAsString;
                            newText += "   ";
                            break;
                        }
                    }
                }

                Console.WriteLine(newText);
            }
            static void hex()
            {
                Console.WriteLine("Hello World!");

                char[] letters = { ' ', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

                int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

                Console.WriteLine("enter text to be converted to hexadecimal");
                string convert = Console.ReadLine();
                string newText = "";
                for (int textToChangeIndex = 0; textToChangeIndex < convert.Length; textToChangeIndex++)
                {
                    for (short letterIndex = 0; letterIndex < letters.Length; letterIndex++)
                    {
                        if (convert[textToChangeIndex] == letters[letterIndex])
                        {
                            int number = numbers[letterIndex];
                            string numberAsString = Convert.ToString(number, 16);

                            newText += "0x" + numberAsString;
                            newText += "   ";

                            break;
                        }
                    }
                }
                Console.WriteLine(newText);
            }


            while (converted == false)
            {
                Console.WriteLine("welome to strings to things which conversion would you like to make today");
                Console.WriteLine("morse code type 1 to select");
                Console.WriteLine("binary type 2 to select");
                Console.WriteLine("hexadecimal type 3 to select");
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    morse();
                    Console.WriteLine("type 'end' to close program");
                    done = Console.ReadLine();
                    if (done == "end")
                    {
                        converted = true;
                    }
                }
                if (choice == "2")
                {
                    ban();
                    Console.WriteLine("type 'end' to close program");
                    done = Console.ReadLine();
                    if (done == "end")
                    {
                        converted = true;
                    }
                }
                if (choice == "3")
                {
                    hex();
                    Console.WriteLine("type 'end' to close program");
                    done = Console.ReadLine();
                    if (done == "end")
                    {
                        converted = true;
                    }

                }
                else
                {
                    Console.WriteLine("input " + choice +" was invalid try again");

                }
            }






        }
    }
}

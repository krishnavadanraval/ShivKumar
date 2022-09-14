using System;
using System.Security.Cryptography.X509Certificates;

namespace PrintDiamondPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {

            {
                //get the input letter entered by user
                String str = UserInput();
                if (str.Length == 1)
                {
                    if (char.IsUpper(Convert.ToChar(str)) != true)
                    {
                        Console.WriteLine("Input must be in Upper case between A and Z ");
                    }
                    else
                    {
                        PrintDiamond(Convert.ToChar(str));
                    }
                       
                }
               
                }
            }
        public static string UserInput()
            {
                try
                {
                    Console.WriteLine("Enters a Letter between A and Z ");

                    string strMesssage = "";
                    String strInput = Console.ReadLine();

                    if (strInput.Length > 1)
                    {
                        Console.Write("Please Enter a Letter between A and Z");
                        strMesssage = "invalid input";
                        return strMesssage;
                    }
                    else
                    {
                        return strInput;
                    }
                   
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return ex.Message;
                }
            }
            static void PrintDiamond(char user_letter)
            {
                int letter_number = 0;
                char[] letter = new char[26]
               {
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U',
                'V', 'W', 'X', 'Y', 'Z'
               };


                //array of strings alphabets 
                string[] diamond = new string[52];
                Console.WriteLine("");
                //search for letter number in the array letter
                for (int i = 0; i < letter.Length; i++)
                {
                    if (letter[i] == user_letter)
                    {
                        letter_number = i;
                        break;
                    }
                }

                //construct diamond for input letter

                for (int i = 0; i <= letter_number; i++)
                {
                    //add initial spaces
                    for (int j = 0; j < letter_number - i; j++)
                    {
                        diamond[i] += " ";
                    }

                    //add letter (first time)
                    diamond[i] += letter[i];

                    //add space between letters
                    if (letter[i] != 'A')
                    {
                        for (int j = 0; j < 2 * i - 1; j++)
                        {
                            diamond[i] += " ";
                        }
                        //add letter (second time)
                        diamond[i] += letter[i];
                    }
                    // Draw the first part of the diamond as it's composing
                    Console.WriteLine(diamond[i]);
                }

                for (int i = letter_number - 1; i >= 0; i--)
                {
                    // Draw the second part of the diamond
                    // Writing the diamond Array in reverse order
                    Console.WriteLine(diamond[i]);
                }

                // Mark a pause
                Console.ReadKey();
            }

        }

    }


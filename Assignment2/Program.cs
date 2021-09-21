using System;
using System.IO;

namespace Assignment2
{
    class Program
    {
        bool emptyFile(string file)
        {
            // if file exists, empty the file
            if (File.Exists(file))
            {
                File.WriteAllText(file, "");
                return true;
            }
            return false;
        }
        void writeInFile(string file, string paraText)
        {
            // if file exists, empty the file otherwise streamWriter will create a new file
            emptyFile(file);
            //StreamWriter opens file for writing
            StreamWriter sw = new StreamWriter(file);
            //Write paraText string to the file
            sw.Write(paraText);
            sw.Close();
        }
        bool isStringWordExists(string textInFile, string inputString, int index)
        {
            /* if user input is "it" the we will find exact "it" word string in file.
                 Possible solutions: " it " , " it," , " it."," it;"                    */
            
            char ch;
            bool flag = false;
            //Check wether string 1st character matches and string is at start in the file i.e. with no prefix or if it prefix with space                
            if (textInFile[index] == inputString[0] && (index == 0 || textInFile[index - 1] == ' '))
            {
                flag = true;
                //check wether complete string word matches with input string by starting from 2nd character of string to the end of the string
                for (int j = index + 1; j < (index + inputString.Length); j++)
                {
                    if (textInFile[j] != inputString[j - index])
                    {   // set flag to false as string mismatch found
                        flag = false;
                        break;
                    }
                }
                //check for suffix to this string are as per above possible solution i.e space or . or , or ;
                ch = textInFile[index + inputString.Length];
                if (!(ch == ' ' || ch == ',' || ch == '.' || ch == ';'))
                {
                    flag = false;
                }
            }
            return flag;
        }

        int getOccurrence(string file,string inputString)
        {
            //Find count of occurrances of given word string

            int i, count=0;
            //Read contents of the file
            string textInFile = File.ReadAllText(file);
            
            for (i = 0; i < textInFile.Length; i++)
            {
                if (isStringWordExists(textInFile, inputString, i)) 
                {   //We found 1 occurrence of given string word in the file
                    count++;
                }
            }
            return count;
        }
        int getLineNumber(string file, string inputString, int inputNumber)
        {   // We are initially at line no 1
            int lineNumber = 1, i, count = 0;
            //Read contents of the file
            string textInFile = File.ReadAllText(file);

            for (i = 0; i < textInFile.Length; i++)
            {
                //count new lines
                if (textInFile[i] == '\n')
                    lineNumber++;

                if (isStringWordExists(textInFile,inputString,i))
                {   
                    count++;
                    //if count equals input number then break outer for loop return it
                    if (count == inputNumber)
                        break;
                    
                }
            }
            return lineNumber;
        }

        static void Main(string[] args)
        {
            string inputString = "",file = "../../../DataFiles/file1.txt";
            string paraText = "\tLorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard \ndummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has\nsurvived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised\n in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like \nAldus PageMaker including versions of Lorem Ipsum.\n\n\tIt is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point \nof using Lorem Ipsum is that it has a more - orless normal distribution of letters, as opposed to using 'Content here, content here', \nmaking it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, \nand a search for 'lorem ipsum' will uncover many web sites still in their infancy.Various versions have evolved over the years, sometimes by \naccident, sometimes on purpose(injected humour and the like).\n\n\tIt has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised \nin the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like \nAldus PageMaker including versions of Lorem Ipsum.";
            int inputNumber, occurrenceCount=0, lineNumber;

            Program p = new Program();

            //Create/Open a file and write string paraText to the file
            p.writeInFile(file, paraText);

            //Take input string from user
            Console.Write("Enter Input string: ");
            inputString = Console.ReadLine();

            //Display occurrance of string word in the file
            occurrenceCount = p.getOccurrence(file, inputString);
            Console.WriteLine("Total occurrances of word \"{0}\" are: {1} ",inputString,occurrenceCount);
            
            //Take input integer from user
            Console.Write("\nEnter integer input: ");
            inputNumber = int.Parse(Console.ReadLine());
            //Check if inputNumber is invalid i.e. out of the range 1 to occrrence count
            if(inputNumber < 1 || inputNumber > occurrenceCount)
            {
                Console.WriteLine("Invalid integer input.");
                return;
            }

            //Find line number where input number'th occurrance of string exists in the file.
            lineNumber = p.getLineNumber(file, inputString, inputNumber);
            //Display line number if it is valid i.e. greater than 0
            if(lineNumber > 0)
                Console.WriteLine("Answer: Line {0}",lineNumber);
            else
                Console.WriteLine("We found invalid line number!");
           
        }
    }
}

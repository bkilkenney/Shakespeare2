using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shakespeare2
{
    class Program
    {
        static void Main(string[] args)
        {
            //StreamReader reader = new StreamReader("C:\\Users\\bkilkenney\\Documents\\Visual Studio 2015\\Projects\\Shakespeare2.txt");

            //int lineNumber = 0;

            //// Read first line from the text file
            //string line = reader.ReadLine();


            ////Everything above this point will print the first line*******************************

            ////Read the other lines from the text file
            //while (line != null)
            //{
            //    lineNumber++;
            //    Console.WriteLine("Line {0}: {1}", lineNumber, line);
            //    line = reader.ReadLine();
            //}

            //// Close the resource after you've finished using it
            //reader.Close();

            //Everything from this line up will print the whole thing****************************************



            //Everything below this will replace lower case with upper case vowels***************************************


            StreamReader reader = new StreamReader("C:\\Users\\bkilkenney\\Documents\\Visual Studio 2015\\Projects\\Shakespeare2.txt");

            int lineNumber = 0;

            string line = reader.ReadToEnd();
            string result = line.Replace("a", "A").Replace("e", "E").Replace("i", "I").Replace("o", "O").Replace("u", "U");

            Console.WriteLine(result);


            while (line != null)  //space between paragraphs are not null
            {
                lineNumber++;
                result = line.Replace("a", "A").Replace("e", "E").Replace("i", "I").Replace("o", "O").Replace("u", "U");
                Console.WriteLine("Line {0}: {1}", lineNumber, result);

//Above line same as WL("Line " + lineNumber + ": " + result);

                line = reader.ReadLine();
            }

            // Close txt file after you're finished using it
            reader.Close();
        }
    }
}


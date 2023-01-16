using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace AlgorithmPrograms
{
    class MessageDemoUsingRegex
    {
        static string sentence = "Hello <<name>>, We have your full name as <<Name1>> in our system.your contact number is 91 - xxxxxxxxxx.Please, let us know in case of any clarification Thank you BridgeLabz 15/01/2023.";
        public static void DisplayMessage()
        {
            string namePattern = "^[<]*name[>]*";
            string fullNamePattern = "[<]*Name1[>]*";
            string numPattern = "[x]{10}";
            string dateTimePattern = "^[15]+[/]+[01]+[/]+[2023]";
            Regex regexname = new Regex(namePattern);
            Regex regexfullName = new Regex(fullNamePattern);
            Regex numberpattern = new Regex(numPattern);
            Regex dateTime = new Regex(dateTimePattern);

            if (regexname.IsMatch("<<name>>"))
            {
                Console.WriteLine("Enter your name");
                string name = Console.ReadLine();
                sentence = sentence.Replace("<<name>>", name);

            }
            if (regexfullName.IsMatch("<<Name1>>"))
            {
                Console.WriteLine("Enter the full name:");
                string fullName = Console.ReadLine();
                sentence = sentence.Replace("<<Name1>>", fullName);
            }

            if (numberpattern.IsMatch("xxxxxxxxxx"))
            {
                Console.WriteLine("Enter the Phone Number");
                string phone = Console.ReadLine();
                sentence = sentence.Replace("xxxxxxxxxx", phone);
            }
            if (dateTime.IsMatch("15/01/2023"))
            {
                string date = DateTime.Now.ToString("MM/dd/yyyy");
                sentence = sentence.Replace("15/01/2023", date);

            }
            Console.WriteLine(sentence + " ");

        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;

namespace AdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName1 = null;
            string userName2 = null;
            string user1Gender = null;
            string user1 = null;
            List <string> maleName = new List <string> { };
            Instructions(out userName1, out userName2, user1Gender, maleName);
            user1 = Scene1(userName1, user1);
            if (user1 == "a" || user1 == "finish eating")
            {
                MirrorScene(userName1, user1);
            }
            if (user1 == "b" || user1 == "ask him to come back")
            {

            }
        }

        static void Instructions(out string userName1, out string userName2, string user1Gender, List<string> maleName)
        {
            Console.WriteLine("Welcome to my Drama adventure game.");
            Console.WriteLine("Created by Chris Small. \n");
            Console.WriteLine("To play you will be given a certain situation.");
            Console.WriteLine("A question will be posed as to what you should do.");
            Console.WriteLine("You will answer with one of the given responses. \n");
            Console.WriteLine("Player 1, what is your name?");
            userName1 = Console.ReadLine();
            userName1 = userName1.ToUpper();
            Console.WriteLine("Player 2, what is your name?");
            userName2 = Console.ReadLine();
            userName2 = userName2.ToUpper();
            GenderFind(maleName, userName1);
            
            Console.WriteLine($"Your name is {userName1}, you are a high school student. Your best friend is named {userName2}.");
            Console.WriteLine($"{userName1}, you live at home with Mum and Dad. School is hard, your dad is an alcoholic, everything seems to be coming apart. \n");
        }
        static string Scene1(string userName1, string user1)
        {
            Console.Clear();
            Console.WriteLine("Dad walks into the kitchen. You are eating cereal. He takes a stare at you then leaves.");
            Console.WriteLine($"{userName1} What do you do?");
            Console.WriteLine("A: finish eating. B: Ask him to come back. /n");
            user1 = Console.ReadLine();
            user1 = user1.ToLower();
            return user1;
        }
        static string MirrorScene(string userName1, string user1)
        {
            Console.Clear();
            Console.WriteLine($"{userName1} walks to their bedroom. While getting ready for school {userName1} stares at themselves in the mirror. Bruises and scars are showing" +
                $"{userName1} is in so much physical pain");
            Console.WriteLine("Do you bother going to school? after all you are the top of your class. (Y/N) \n");
            user1 = Console.ReadLine();
            user1 = user1.ToLower();
            return user1;
        }
        static void GenderFind(List<string> maleName, string userName1)
        {
            string user1GenderM = null;
            string user1GenderF = null;
            StreamReader read = new StreamReader("MaleNames.txt");
            while(user1GenderM != userName1)
            {
                user1GenderM = read.ReadLine();
            }
            
            if (user1GenderM == userName1)
            {
                Console.WriteLine("Your a male");
            }
            else
            {
                StreamReader read1 = new StreamReader("FemaleNames.txt");
                while (user1GenderF != userName1)
                {
                    user1GenderF = read1.ReadLine();
                }
                Console.WriteLine("Your a female");
            }
        }
    }
}

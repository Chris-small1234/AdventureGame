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
            string user2Gender = null;
            string user1 = null;
            List <string> maleName = new List <string> {null};
            List<string> femaleName = new List<string> {null};
            Instructions(out userName1, out userName2, user1Gender, maleName);
            GenderFind(maleName, userName1, femaleName, out user1Gender, out user2Gender, userName2);
            
            user1 = Scene1(userName1, user1, userName2, user1Gender, user2Gender);
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
            
            
            Console.WriteLine($"Your name is {userName1}, you are a high school student. Your best friend is named {userName2}.");
            Console.WriteLine($"{userName1}, you live at home with Mum and Dad. School is hard, your dad is an alcoholic, everything seems to be coming apart. \n");
        }
        static string Scene1(string userName1, string user1, string userName2, string user1Gender, string user2Gender)
        {
            Console.Clear();
            Console.WriteLine($"{userName1} you are a {user1Gender}. {userName2} you are a {user2Gender}.");
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
        static void GenderFind(List<string> maleName, string userName1, List<string> femaleName, out string user1Gender, out string user2Gender, string userName2)
        {
            string nameStringM = null;
            string nameStringF = null;
            user1Gender = null;
            user2Gender = null;
            
            //User 1 Gender finding
            int countM = 0;
            StreamReader read = new StreamReader("MaleNames.txt");
            while(read.EndOfStream == false)
            {
                nameStringM = read.ReadLine();
                maleName.Add(nameStringM);
            }
            for (int i = 0; i < maleName.Count; i++)
            {
                if (userName1 == maleName[countM])
                {
                    user1Gender = "male";
                }
                countM++;
            }
            int countF = 0;
            StreamReader read1 = new StreamReader("FemaleNames.txt");
            while (read1.EndOfStream == false)
            {
               nameStringF = read1.ReadLine();
               femaleName.Add(nameStringF);
            }
            for (int i = 0; i < femaleName.Count; i++)
            {
                if (userName1 == femaleName[countF])
                {
                    user1Gender = "female";
                }
                countF++;
            }

            //User 2 Gender finding
            int countM2 = 0;
            StreamReader read2 = new StreamReader("MaleNames.txt");
            while (read2.EndOfStream == false)
            {
                nameStringM = read2.ReadLine();
                maleName.Add(nameStringM);
            }
            for (int i = 0; i < maleName.Count; i++)
            {
                if (userName2 == maleName[countM2])
                {
                    user2Gender = "male";
                }
                countM2++;
            }
            int countF2 = 0;
            StreamReader read3 = new StreamReader("FemaleNames.txt");
            while (read3.EndOfStream == false)
            {
                nameStringF = read3.ReadLine();
                femaleName.Add(nameStringF);
            }
            Console.WriteLine();
            for (int i = 0; i < femaleName.Count; i++)
            {
                if (userName2 == femaleName[countF2])
                {
                    user2Gender = "female";
                }
                countF2++;
            }
            Console.WriteLine();
        }
    }
}

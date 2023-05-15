using Kursach.BL.Controller;
using System;
using Kursach.BL.Controller.mocks;

namespace Profkom.CMD
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Session.StartSession();

            Console.WriteLine("ahahaha");

            if(Session.Posts.Count < 1) 
            {
                Console.WriteLine("");
                Person.AddPostProfk();
            }

            if(Session.Organizations.Count < 1)
            {
                Console.WriteLine("");
                Person.AddOrganization();
            }
            string ans;

            Console.WriteLine("Wanna add new post? y/n: ");
            while ((ans = Console.ReadLine()) == "Y" || ans == "y")
            {
                Person.AddPostProfk();
                Console.WriteLine("Wanna add new post? y/n: ");
            }

            Console.WriteLine("Wanna add new organization?? y/n");
            while ((ans = Console.ReadLine()) == "Y" || ans == "y")
            {
                Person.AddOrganization();
                Console.WriteLine("Wanna add new organization?? y/n");
            }
            Console.Clear();
            Console.WriteLine("Add new person? y/n");
            while ((ans = Console.ReadLine()) == "Y" || ans == "y")
            {
                Person.AddPerson();
                Console.Clear();
                Console.WriteLine("Add new person? y/n");
            }

            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database_connection
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter new post - 1 \nView table - 2 \nExit - 3");
                var user_selection = Console.ReadLine();

                switch (user_selection)
                {
                    case ("1"):
                        addPost();        
                        break;
                    case ("2"):
                        showTable();      
                        break;
                    case ("3"):
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }

                Console.ReadLine();
                Console.Clear();
            }
        }


        static void showTable()
        {
            foreach (var item in DataAccess.getPosts())
            {
                Console.WriteLine(item.First_Name + " | " +
                    item.Last_Name + " | " +
                    item.Text);
            }
        }

        static void addPost()
        {
            Console.WriteLine("First Name: ");
            var fn = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            var ln = Console.ReadLine();
            Console.WriteLine("Email: ");
            var email = Console.ReadLine();
            Console.WriteLine("Text: ");
            var text = Console.ReadLine();

            DataAccess.addPost(fn, ln, email, text);

        }

    }
}

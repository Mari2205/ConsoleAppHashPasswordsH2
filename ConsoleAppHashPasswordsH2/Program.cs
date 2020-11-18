using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHashPasswordsH2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileManager fileManager = new FileManager();
            Ui ui = new Ui();

            ui.GetHedding();

            Console.WriteLine("pleace make a password : ");
            string usrPassword = Console.ReadLine();
            string password = usrPassword;

            Console.WriteLine("Login with a password : ");
            string CheckPassword = Console.ReadLine();

            byte[] salt = Hash.GenerateSalt();
            var hashedPassword1 = Hash.HashPasswordWithSalt(Encoding.UTF8.GetBytes(password), salt);
            var hashedPassword2 = Hash.HashPasswordWithSalt(Encoding.UTF8.GetBytes(CheckPassword), salt);

            fileManager.WriteToFile(hashedPassword1);


            Console.WriteLine("Checking list of Passwords...");
            foreach (var kode in fileManager.ReadFromFile())
            {
                if (Convert.ToBase64String(hashedPassword2) == kode.ToString())
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You have entered the correct password");
                    Console.ResetColor();

                    ui.ShowHashData(password, salt, hashedPassword1);
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You have entered an invalid password");
                    Console.ResetColor();
                }
            }

            Console.ReadKey();


        }
    }
}

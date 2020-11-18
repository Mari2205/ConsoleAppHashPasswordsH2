using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHashPasswordsH2
{
    class Ui
    {
        public void GetHedding()
        {
            string head = @"
 /$$   /$$                     /$$            
| $$  | $$                    | $$            
| $$  | $$  /$$$$$$   /$$$$$$$| $$$$$$$       
| $$$$$$$$ |____  $$ /$$_____/| $$__  $$      
| $$__  $$  /$$$$$$$|  $$$$$$ | $$  \ $$      
| $$  | $$ /$$__  $$ \____  $$| $$  | $$      
| $$  | $$|  $$$$$$$ /$$$$$$$/| $$  | $$      
|__/  |__/ \_______/|_______/ |__/  |__/      
                                                                                                                   
";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(head);
            Console.ResetColor();
        }

        public void ShowHashData(string password, byte[] salt, byte[] hashedPassword)
        {
            Console.WriteLine("\nHash Password with Salt Demonstration in .NET");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Password : " + password);
            Console.WriteLine("Salt = " + Convert.ToBase64String(salt));

            Console.WriteLine("\nHashed Password = " + Convert.ToBase64String(hashedPassword)); // sign up password

        }
    }
}

using System.Reflection.Metadata;

namespace First
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string FirstName, string LastName, string Login, int LoginLength, bool HasPet, int Age, string[] FavColors) User;
            for(int j = 0; j < 3; j++)
            {
                User.FavColors = new string[3];
                Console.WriteLine("Enter Firstname");
                User.FirstName = Console.ReadLine();
                Console.WriteLine("Enter Lastname");
                User.LastName = Console.ReadLine();
                Console.WriteLine("Enter Login");
                User.Login = Console.ReadLine();
                User.LoginLength = User.Login.Length;
                Console.WriteLine("Do you have pets? Yes/ No");
                if (Console.ReadLine().ToLower() == "yes")
                    User.HasPet = true;
                else
                    User.HasPet = false;
                Console.WriteLine("Enter users Age");
                User.Age = int.Parse(Console.ReadLine());
                for (int i = 0; i < User.FavColors.Length; i++)
                {
                    Console.WriteLine($"Enter your favourite color number {i}");
                    User.FavColors[i] = Console.ReadLine();
                }
            }
            
        }
    }
}

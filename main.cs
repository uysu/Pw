using (System);

namespace Git
{
    class Git
    {
        static void Main (string[] args)
        {
            System.Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            System.Console.WriteLine(name.Length); 
            System.Console.WriteLine($"Hello {name}!");
        }
    }

}
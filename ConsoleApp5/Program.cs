namespace ConsoleApp5
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("Please Enter your age");
            int age = Int32.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine(name + " can buy alchohol!");
            } else if (age < 18)
            {
                Console.WriteLine("Wow your just a baby");
            } else {
                Console.WriteLine("Please run the app again and enter a valid age")
            };

            if (name.Length <= 2) {
                Console.WriteLine("Please enter a name with more than 3 characters");
            }
        }
    }
}

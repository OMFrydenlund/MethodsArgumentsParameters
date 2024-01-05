namespace MethodsArgumentsParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InitialQuery();
            SarcasticResponse();
            /*
            typing the method content here without extracting, then extracting outside the scope auto pass args
            and auto sets matching parameters for the extracted method. (Parameters recieve generic names)
            */

            Console.ReadLine();
        }

        static void InitialQuery()
        {
            Console.WriteLine("So who am I speaking to? ");
            string userName = Console.ReadLine();
            Console.WriteLine("\nAnd how old are you?");
            int userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nSo you're telling me, " + userName + ", that you're " + userAge +
                              " years old. I doubt that, let's see here...");
        }

        static void SarcasticResponse()
        {
            String name = "Mig";
            int age = 10;

            Sarcasm(name, age);
        }

        static void Sarcasm(string victimOfSarcasm, int notRealAge)
        {
            Console.WriteLine("Well aint that something " + victimOfSarcasm + "!");
            Console.WriteLine("\nApparently you're " + notRealAge + " years old. Go figure. Now get lost >:|");
        }
    }
}

namespace MethodsArgumentsParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name = "Mig";
            int age = 10;

            Sarcasm(name, age);
            /*
            typing the method content here without extracting, then extracting outside the scope auto pass args
            and auto sets matching parameters for the extracted method. (Parameters recieve generic names)
            */

            Console.ReadLine();

        }

        static void Sarcasm(string victimOfSarcasm, int notRealAge)
        {
            Console.WriteLine("Well aint that something " + victimOfSarcasm);
            Console.WriteLine("Apparently you're " + notRealAge + " years old. Go figure");
        }
    }
}

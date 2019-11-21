using System;

namespace class5g
{
    public class Output
    {
        // Declare the delegate type.
        public delegate void Writer(string output);
        public delegate void NewWriter(float output);
        // Declare a method with a header that matches the delegate type.
        public void Display(string output)
        {
            Console.WriteLine(output);
        }
        public void Display(float output)
        {
            Console.WriteLine(output);
        }
    }

    public class Program
    {
        public static void Main()
        {
            // Declare an instance of Output.
            Output output = new Output();

            // Instantiate delegate with a reference to Output.Display().
            Output.Writer writer = new Output.Writer(output.Display);

            // Invoke the Display() method with the delegate reference.
            writer("Hello from Delegate.");
            Output.NewWriter newwriter = new Output.NewWriter(output.Display);
            newwriter(4.6f);
            Console.ReadLine();
        }
    }

}

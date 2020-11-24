using System;

namespace BasicInputAndOutput
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            // read a character
            Console.WriteLine("Enter a character:");
            int key = Console.Read();
            Console.Write("Your character ASCII code: " + key);
            Console.Write(Environment.NewLine);

            // read a key info
            Console.WriteLine("Press a key:");
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            Console.Write("Your key code: " + keyInfo.Key + "\n");
            Console.Write("Your key modifiers: " + keyInfo.Modifiers + "\n");
            Console.Write("Your key char: " + keyInfo.KeyChar + "\n");
            Console.Write(Environment.NewLine);

            /*
                Console.Read() accepts values into the input stream until Enter is pressed.
                Each subsequent call to Console.Read() reads a single character from that input.
                Console.ReadLine() retrieves a full line from the input stream. Do you see what's going wrong?

                If you type in "XYZ" and press Enter at Console.Read() you have "YZ<enter>" in the input stream with r set to X. 
                Then Console.ReadLine() picks up the remaining "YZ<enter>" and the program terminates. 
                This quirk is why MSDN recommends not to use Console.Read() favoring Console.ReadLine() and Console.ReadKey() instead.
             */

            // read a string
            Console.WriteLine("Enter a string:");
            // string str = Console.ReadLine();
            Console.Write("Your string: " + Console.ReadLine());
            Console.Write(Environment.NewLine);
        }
    }
}
using System;
using System.IO;
using System.Text;

namespace Console16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            using (var sw = new StreamWriter("test.txt", true, Encoding.Unicode))
            {
                sw.Write("Hello, world. Привет, Мир. ");
                sw.WriteLine("Hello, User.");
            }

            using(var sr = new StreamReader("test.txt", Encoding.Unicode))
            {
                var text = sr.ReadToEnd();
                Console.WriteLine(text);
            }
            Console.ReadLine();
        }
    }
}

using BinaryFormatterIssue.Shared;
using System.Diagnostics;

namespace NetBinaryFormatterIssue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var formatter = new nanoFramework.Serialization.Helper.BinaryFormatter();
            var empty = new EmptyClass();
            var eBytes = formatter.Serialize(empty);
            var eBytesString = BitConverter.ToString(eBytes);
            Debug.WriteLine(eBytesString); // 82-A9-1C-33-C0

            var notEmpty = new NotEmptyClass();
            var neBytes = formatter.Serialize(notEmpty);
            var neBytesString = BitConverter.ToString(neBytes);
            Debug.WriteLine(neBytesString); // 8E-9C-2C-7C-80-00-00-00-00

            Console.WriteLine("Hello, World!");
        }
        

    }
}
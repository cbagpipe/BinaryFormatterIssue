using BinaryFormatterIssue.Shared;
using System.Diagnostics;

namespace NetBinaryFormatterIssue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var empty = new EmptyClass();
            var notEmpty = new NotEmptyClass();

            var formatter1 = new nanoFramework.Serialization.Helper.BinaryFormatter();
            var eBytes1 = formatter1.Serialize(empty);
            var eBytesString1 = BitConverter.ToString(eBytes1);
            Debug.WriteLine(eBytesString1); // 82-A9-1C-33-C0

            var formatter2 = new nanoFramework.Serialization.Helper.BinaryFormatter();
            var neBytes2 = formatter2.Serialize(notEmpty);
            var neBytesString = BitConverter.ToString(neBytes2);
            Debug.WriteLine(neBytesString); // 8E-9C-2C-7C-80-00-00-00-00

            var formatter3 = new nanoFramework.Serialization.Helper.BinaryFormatter();
            var neBytes3 = formatter3.Serialize(notEmpty);
            var neBytesString3 = BitConverter.ToString(neBytes3);
            Debug.WriteLine(neBytesString3); 

            Console.WriteLine("Hello, World!");
        }
        

    }
}
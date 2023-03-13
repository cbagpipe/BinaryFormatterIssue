using BinaryFormatterIssue.Shared;
using System;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace BinaryFormatterIssue
{
    public class Program
    {
        public static void Main()
        {
            var empty = new EmptyClass();
            var eBytes = BinaryFormatter.Serialize(empty);
            var eBytesString = BitConverter.ToString(eBytes);
            Debug.WriteLine(eBytesString); // 82-A9-1C-33-C0

            var notEmpty = new NotEmptyClass();
            var neBytes = BinaryFormatter.Serialize(notEmpty);
            var neBytesString = BitConverter.ToString(neBytes);
            Debug.WriteLine(neBytesString); // BC-EB-EE-C8-80-00-00-00-00

            Debug.WriteLine("Hello from nanoFramework!");

            Thread.Sleep(Timeout.Infinite);

            // Browse our samples repository: https://github.com/nanoframework/samples
            // Check our documentation online: https://docs.nanoframework.net/
            // Join our lively Discord community: https://discord.gg/gCyBu8T
        }
    }
}

using System;
using System.Text;

using GBK2UTF8.src;

namespace GBK2UTF8
{
    class Program
    {
        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var converter = new Converter();
            converter.ConvertDirectory();
            System.Console.WriteLine("Done");
        }
    }
}

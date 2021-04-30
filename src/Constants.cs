using System;
using System.Diagnostics;
using System.IO;

namespace GBK2UTF8.src
{
    public record Constants
    {
        // string ProjRootPath = Environment.GetCommandLineArgs() [0];
        public static string Root { get; } = System.Environment.CurrentDirectory;
        public static string GBKInputDir { get; } = Path.Combine(Root, "sources", "input");
        public static string UTF8OutputDir { get; } = Path.Combine(Root, "sources", "output");
    }
}

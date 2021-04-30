using System.Collections;
using System.IO;
using System.Text;

namespace GBK2UTF8.src
{
    public class Converter : IConverter
    {
        public string InputDirectory { get; set; } = Constants.GBKInputDir;
        public string OutputDirectory { get; set; } = Constants.UTF8OutputDir;

        public void ConvertArchived(string fileName)
        {
            throw new System.NotImplementedException();
        }

        public void ConvertDirectory(string dir)
        {
            try
            {
                var files = Directory.EnumerateFiles(dir, "*.txt", SearchOption.AllDirectories);
                ConvertFiles(files);
            }
            catch (System.Exception err)
            {
                System.Console.WriteLine($"{err.Message}");
            }
        }

        public void ConvertDirectory()
        {
            ConvertDirectory(InputDirectory);
        }

        public void ConvertFile(string filePath)
        {
            var content = File.ReadAllText(filePath, Encoding.GetEncoding("gbk")); // 以操作系统的默认字符集（在简体中文操作系统下，为 GBK）读取内容
            var utf8Encoding = new UTF8Encoding(true); // 是否包含 BOM（byte order mark，字节顺序标记）
            var fileName = Path.GetFileName(filePath);
            var outputPath = Path.Combine(OutputDirectory, fileName); // 将输出目录和文件名组合成新文件的路径
            if (!File.Exists(outputPath))
            {
                System.Console.WriteLine($"Converting {fileName}");
                File.WriteAllText(outputPath, content, utf8Encoding); // 以 UTF-8 编码写入新文件
            }
        }

        public void ConvertFiles(IEnumerable files)
        {
            foreach (var item in files)
            {
                if (item.GetType() == typeof(string))
                {
                    ConvertFile(item as string);
                }
            }
        }
    }
}

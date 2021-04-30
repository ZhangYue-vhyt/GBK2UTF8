using System.Collections;

namespace GBK2UTF8.src
{
    public interface IConverter
    {
        void ConvertFile(string filePath);
        void ConvertFiles(IEnumerable files);
        void ConvertDirectory();
        void ConvertDirectory(string dir);
        void ConvertArchived(string fileName);

    }
}

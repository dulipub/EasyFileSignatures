

namespace EasyFileSignatures.Abstrations;

public interface IFileType
{
    int[] Singnature { get; }

    string MediaType { get; }

    string Extension { get; }

    FileType Type { get; }
}

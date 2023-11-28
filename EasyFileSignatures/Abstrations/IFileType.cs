

namespace EasyFileSignatures.Abstrations;

public interface IFileType
{
    public string Name { get; }
    List<byte[]> Singnatures { get; }

    string MediaType { get; }

    string Extension { get; }

    ContentCategory Type { get; }

    Range Range { get; }
}

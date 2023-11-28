

namespace EasyFileSignatures.Abstrations;

public interface IFileDetails
{
    public string Name { get; }

    List<byte[]> Singnatures { get; }

    string MediaType { get; }

    string Extension { get; }

    ContentCategory Category { get; }

    Range Range { get; }
}

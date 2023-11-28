using EasyFileSignatures.Abstrations;

namespace EasyFileSignatures.FileTypes;

public class Jfif : IFileDetails
{
    public List<byte[]> Singnatures { get; private set; }

    public string MediaType { get; private set; }

    public string Extension { get; private set; }

    public ContentCategory Category { get; private set; }

    public Range Range { get; private set; }

    public string Name {get; private set;}

    public Jfif()
    {
        Singnatures = new List<byte[]> {
             new byte[] { 0xFF, 0xD8, 0xFF, 0xE0 }
        };

        MediaType = "image/jpeg";
        Extension = "jpeg";
        Category = ContentCategory.StillImage;
        Range = new Range(0, 4);

        Name = "JFIF_1_02";
    }
}

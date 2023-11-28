using EasyFileSignatures.Abstrations;

namespace EasyFileSignatures.FileTypes;

public class Png : IFileDetails
{
    public List<byte[]> Singnatures { get; private set; }

    public string MediaType { get; private set; }

    public string Extension { get; private set; }

    public ContentCategory Category { get; private set; }

    public Range Range { get; private set; }
    public string Name { get; private set; }

    public Png()
    {
        Singnatures = new List<byte[]> {
             new byte[] { 0x89, 0x50, 0x4E, 0x47, 0x0D, 0x0A, 0x1A, 0x0A }
        };

        MediaType = "image/png";
        Extension = "png";
        Category = ContentCategory.StillImage;
        Range = new Range(0, 8);
        Name = "PNG";
    }
}

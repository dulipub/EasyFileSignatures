using EasyFileSignatures.Abstrations;

namespace EasyFileSignatures.FileTypes;

public class Png : IFileType
{
    public int[] Singnature
    {
        get
        {
            return new int[] { };
        }
    }

    public string MediaType
    {
        get
        {
            return "image/png";
        }
    }

    public string Extension
    {
        get
        {
            return "png";
        }
    }

    public FileType Type
    {
        get
        {
            return FileType.Image;
        }
    }
}

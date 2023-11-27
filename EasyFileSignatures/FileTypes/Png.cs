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
            return string.Empty;
        }
    }

    public string Extension
    {
        get
        {
            return string.Empty;
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
